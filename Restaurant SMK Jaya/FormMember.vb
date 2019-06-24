Imports System.Data.SqlClient
Public Class FormMember
    Public id As String
    Dim koneksi As New SqlConnection(My.Settings.ConnectionString)
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If id Is Nothing Then
            AddMember()
        Else
            EditMember()
        End If
    End Sub

    Sub AddMember()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
        Dim memberId = ""
        Dim checkid As New SqlCommand("Select top(1) [MemberId] from [MsMember] order by cast(Substring([EmployeeId],4,5) as int) desc", koneksi)
        Dim reader = checkid.ExecuteReader
        If reader.Read Then
            Select Case Integer.Parse(reader.GetString(0).Substring(3, 5))
                Case 1 To 8
                    memberId = "MBR0000" + (Integer.Parse(reader.GetString(0).Substring(3, 5)) + 1).ToString
                Case 9 To 98
                    memberId = "MBR000" + (Integer.Parse(reader.GetString(0).Substring(3, 5)) + 1).ToString
                Case 99 To 998
                    memberId = "MBR00" + (Integer.Parse(reader.GetString(0).Substring(3, 5)) + 1).ToString
                Case 999 To 9998
                    memberId = "MBR0" + (Integer.Parse(reader.GetString(0).Substring(3, 5)) + 1).ToString
                Case 9998 To 99998
                    memberId = "MBR" + (Integer.Parse(reader.GetString(0).Substring(3, 5)) + 1).ToString
            End Select
        Else
            memberId = "MBR00001"
        End If
        reader.Close()

        Dim cmd As New SqlCommand("Insert into [MsMember] values(@id,@name,@email,@phone,@date)", koneksi)
        cmd.Parameters.AddWithValue("@id", memberId)
        cmd.Parameters.AddWithValue("@name", tbName.Text)
        cmd.Parameters.AddWithValue("@email", tbEmail.Text)
        cmd.Parameters.AddWithValue("@phone", tbHandphone.Text)
        cmd.Parameters.AddWithValue("@date", Date.Now)
        If cmd.ExecuteNonQuery = 1 Then
            Me.DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show(Nothing, "Gagal menambahkan member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub EditMember()
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If

        Dim cmd As New SqlCommand("Update [MsMember] set [Name]=@name,[Email]=@email,[Handphone]=@phone where [MemberId]=@id", koneksi)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", tbName.Text)
        cmd.Parameters.AddWithValue("@email", tbEmail.Text)
        cmd.Parameters.AddWithValue("@phone", tbHandphone.Text)
        If cmd.ExecuteNonQuery = 1 Then
            Me.DialogResult = DialogResult.OK
            Close()
        Else
            MessageBox.Show(Nothing, "Gagal mengedit member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class