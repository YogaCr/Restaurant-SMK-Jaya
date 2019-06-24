Imports System.Data.SqlClient
Public Class FormChef
    Dim konek As New SqlConnection(My.Settings.Properties.Item("ConnectionString").DefaultValue)

    Sub CekKoneksi()
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If
    End Sub

    Sub ButtonNav(s As Object, p As Panel)
        Dim b As Button = CType(s, Button)
        btnViewOrder.BackColor = Color.DodgerBlue
        btnViewOrder.ForeColor = Color.White
        btnPassword.BackColor = Color.DodgerBlue
        btnPassword.ForeColor = Color.White

        b.BackColor = SystemColors.Control
        b.ForeColor = Color.Black

        p.BringToFront()
    End Sub
    Private Sub FormChef_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CekKoneksi()
        Dim cmd As New SqlCommand("Select [Name] from [MsEmployee] where [EmployeeId]=@id", konek)
        cmd.Parameters.AddWithValue("@id", My.Settings.Id)
        Dim reader = cmd.ExecuteReader
        If reader.Read Then
            lblNama.Text = "Welcome, " + reader.GetString(0)
        End If
        reader.Close()
        konek.Close()
    End Sub
End Class