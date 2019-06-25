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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim util As New Util
        Dim ls As New List(Of TextBox)
        ls.Add(tbName)
        ls.Add(tbPrice)
        If Not util.TextboxValidation(ls) Then
            Return
        End If

        If Not util.NumberValidation(tbPrice.Text) Then
            Return
        End If
        If pbMenu.Image Is Nothing Then
            MessageBox.Show(Nothing, "Semua field harus terisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If koneksi.State = ConnectionState.Closed Then
            koneksi.Open()
        End If
        Dim b As Byte()
        Dim ms As New IO.MemoryStream
        pbMenu.Image.Save(ms, Imaging.ImageFormat.Png)
        b = ms.GetBuffer
        Dim cmd As SqlCommand
        If id Is Nothing Then
            cmd = New SqlCommand("Insert into [MsMenu]([Name],[Price],[Photo]) values(@name,@price,@photo)", koneksi)
        Else
            cmd = New SqlCommand("Update [MsMenu] set [Name]=@name,[Price]=@price,[Photo]=@photo where [MenuId]=@id", koneksi)
            cmd.Parameters.AddWithValue("@id", id)
        End If
        cmd.Parameters.AddWithValue("@name", tbName.Text)
        cmd.Parameters.AddWithValue("@price", tbPrice.Text)
        cmd.Parameters.AddWithValue("@photo", b)

        If cmd.ExecuteNonQuery = 1 Then
            koneksi.Close()
            Me.DialogResult = DialogResult.OK
            Close()
        Else
            koneksi.Close()
            MessageBox.Show(Nothing, "Gagal melakukan operasi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If id IsNot Nothing Then
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
            End If
            Dim cmd As New SqlCommand("Select * from [MsMenu] where [MenuId]=@id", koneksi)
            cmd.Parameters.AddWithValue("@id", id)
            Dim reader = cmd.ExecuteReader
            If reader.Read Then
                tbName.Text = reader.GetString(1)
                tbPrice.Text = reader.GetInt32(2).ToString
                pbMenu.Image = Image.FromStream(reader.GetStream(3))
                pbMenu.BringToFront()
            End If
            reader.Close()
            koneksi.Close()
        End If
    End Sub
End Class