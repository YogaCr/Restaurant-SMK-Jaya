Imports System.Data.SqlClient
Public Class FormMenu
    Public id As String
    Dim koneksi As New SqlConnection(My.Settings.ConnectionString)
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim filedialog As New OpenFileDialog
        filedialog.Filter = "Image Files|*.jpg;*.jpeg;|*.png|*.gif"
        If filedialog.ShowDialog = DialogResult.OK Then
            pbMenu.Image = Image.FromFile(filedialog.FileName)
            lblNoPhoto.SendToBack()
        End If
    End Sub
End Class