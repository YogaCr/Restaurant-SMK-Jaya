Imports System.Data.SqlClient
Public Class FormEmployee
    Public id As String
    Dim koneksi As New SqlConnection(My.Settings.ConnectionString)
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim util As New Util
        Dim ls As New List(Of TextBox)
        ls.Add(tbName)
        ls.Add(tbEmail)
        ls.Add(tbHandphone)

        If Not util.TextboxValidation(ls) Then
            Return
        End If

        If Not util.EmailValidation(tbEmail.Text) Then
            Return
        End If

        If Not util.NumberValidation(tbHandphone.Text) Then
            Return
        End If
        If cbPosition.SelectedIndex = -1 Then
            MessageBox.Show(Nothing, "Semua field harus terisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If id Is Nothing Then
            AddEmployee()
        Else
            EditEmployee()
        End If

    End Sub

    Sub AddEmployee()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
        Dim empId = ""
        Dim checkid As New SqlCommand("Select top(1) [EmployeeId] from [MsEmployee] order by cast(Substring([EmployeeId],4,3) as int) desc", koneksi)
        Dim reader = checkid.ExecuteReader
        If reader.Read Then
            Select Case Integer.Parse(reader.GetString(0).Substring(3, 3))
                Case 1 To 8
                    empId = "EMP00" + (Integer.Parse(reader.GetString(0).Substring(3, 3)) + 1).ToString
                Case 9 To 98
                    empId = "EMP0" + (Integer.Parse(reader.GetString(0).Substring(3, 3)) + 1).ToString
                Case 99 To 998
                    empId = "EMP" + (Integer.Parse(reader.GetString(0).Substring(3, 3)) + 1).ToString
            End Select
        Else
            empId = "EMP001"
        End If
        reader.Close()
        Dim pass = ""
        Dim abjad = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"

        Dim rand As New Random
        Dim x = 0
        While x < 7
            pass += abjad.Substring(rand.Next(0, abjad.Length - 1), 1)
            x += 1
        End While
        Dim cmd As New SqlCommand("Insert into [MsEmployee] values(@id,@name,@email,@pass,@phone,@position)", koneksi)
        cmd.Parameters.AddWithValue("@id", empId)
        cmd.Parameters.AddWithValue("@name", tbName.Text)
        cmd.Parameters.AddWithValue("@email", tbEmail.Text)
        cmd.Parameters.AddWithValue("@pass", pass)
        cmd.Parameters.AddWithValue("@phone", tbHandphone.Text)
        cmd.Parameters.AddWithValue("@position", cbPosition.SelectedItem)
        If cmd.ExecuteNonQuery = 1 Then
            MessageBox.Show(Nothing, "Berhasil menambahkan pegawai dengan password='" + pass + "'", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show(Nothing, "Gagal menambahkan pegawai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Sub EditEmployee()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
        Dim cmd As New SqlCommand("Update [MsEmployee] set [Name]=@name,[Email]=@email,[Handphone]=@phone,[Position]=@position where [EmployeeId]=@id", koneksi)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", tbName.Text)
        cmd.Parameters.AddWithValue("@email", tbEmail.Text)
        cmd.Parameters.AddWithValue("@phone", tbHandphone.Text)
        cmd.Parameters.AddWithValue("@position", cbPosition.SelectedItem)
        If cmd.ExecuteNonQuery = 1 Then
            Me.DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show(Nothing, "Gagal mengedit pegawai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub FormEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If id IsNot Nothing Then
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
            End If
            Dim cmd As New SqlCommand("Select * from [MsEmployee] where [EmployeeId]=@id", koneksi)
            cmd.Parameters.AddWithValue("@id", id)
            Dim reader = cmd.ExecuteReader
            If reader.Read Then
                tbName.Text = reader.GetString(1)
                tbEmail.Text = reader.GetString(2)
                tbHandphone.Text = reader.GetString(4)
                cbPosition.SelectedItem = reader.GetString(5)
            End If
            reader.Close()
            koneksi.Close()
        End If
    End Sub
End Class