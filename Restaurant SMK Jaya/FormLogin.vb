Imports System.Data.SqlClient
Public Class FormLogin
    Private Sub cbPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbPassword.CheckedChanged
        If cbPassword.Checked Then
            tbPassword.UseSystemPasswordChar = False
        Else
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbEmail.Text.Length < 1 Or tbPassword.Text.Length < 1 Then
            MessageBox.Show(Nothing, "Email atau password tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim konek As New SqlConnection(My.Settings.ConnectionString)
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If

        Dim cmd As New SqlCommand("Select * from [MsEmployee] where [Email]=@email", konek)
        cmd.Parameters.AddWithValue("@email", tbEmail.Text)
        Dim reader = cmd.ExecuteReader
        If reader.Read Then
            If reader.GetString(3) = tbPassword.Text Then
                My.Settings.Id = reader.GetString(0)
                Select Case reader.GetString(5).ToLower
                    Case "admin"
                        Dim f As New FormAdmin
                        f.Show()
                    Case "cashier"
                        Dim f As New FormCashier
                        f.Show()
                    Case "chef"
                        Dim f As New FormChef
                        f.Show()
                End Select

                reader.Close()
                konek.Close()
                Me.Close()
            Else
                MessageBox.Show(Nothing, "Email atau password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show(Nothing, "Email atau password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        reader.Close()
        konek.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
