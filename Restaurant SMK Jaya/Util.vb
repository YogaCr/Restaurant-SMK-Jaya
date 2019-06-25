Imports System.Data.SqlClient
Public Class Util
    Dim koneksi As New SqlConnection(My.Settings.ConnectionString)
    Function TextboxValidation(tb As List(Of TextBox)) As Boolean
        For Each textbox In tb
            If textbox.Text.Length < 1 Then
                MessageBox.Show(Nothing, "Semua field harus terisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Next
        Return True
    End Function

    Function GetImage(id As String) As Image
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
        Dim cmd As New SqlCommand("Select [Photo] from [MsMenu] where [MenuId]=@id", koneksi)
        cmd.Parameters.AddWithValue("@id", id)
        Dim reader = cmd.ExecuteReader
        If reader.Read() Then
            Return Image.FromStream(reader.GetStream(0))
        End If
        Return Nothing
    End Function

    Function NumberValidation(s As String) As Boolean
        Try
            Double.Parse(s)
            Return True
        Catch ex As Exception
            MessageBox.Show(Nothing, "Tolong masukkan angka saja", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End Try
    End Function

    Function EmailValidation(s As String) As Boolean
        If s.Contains("@") Then
            Return True
        End If
        MessageBox.Show(Nothing, "Format email tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return False
    End Function

    Function PasswordValidation(oldPw As String, newPw As String, confirmPw As String) As Boolean
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If

        Dim cmd As New SqlCommand("Select [password] from [MsEmployee] where [EmployeeId]=@id", koneksi)
        cmd.Parameters.AddWithValue("@id", My.Settings.Id)
        Dim reader = cmd.ExecuteReader
        If reader.Read Then
            If Not oldPw = reader.GetString(0) Then
                reader.Close()
                koneksi.Close()
                MessageBox.Show(Nothing, "Password lama tidak cocok", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If
        reader.Close()
        koneksi.Close()

        Dim lowAlpha = "abcdefghijklmnopqrstuvwxyz"
        Dim upAlpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim number = "0123456789"

        Dim low As Boolean = False
        Dim high As Boolean = False
        Dim num As Boolean = False

        For Each c In newPw
            If lowAlpha.Contains(c.ToString) Then
                low = True
                Exit For
            End If
        Next

        For Each c In newPw
            If upAlpha.Contains(c.ToString) Then
                high = True
                Exit For
            End If
        Next

        For Each c In newPw
            If number.Contains(c.ToString) Then
                num = True
                Exit For
            End If
        Next
        If Not low And Not high And Not num Then
            MessageBox.Show(Nothing, "Password harus mengandung huruf besar,huruf kecil,dan angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not newPw = confirmPw Then
            MessageBox.Show(Nothing, "Password baru harus sama dengan konfirmasi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

End Class
