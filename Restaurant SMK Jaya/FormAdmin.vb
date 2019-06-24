Imports System.Data.SqlClient
Public Class FormAdmin
    Dim konek As New SqlConnection(My.Settings.Properties.Item("ConnectionString").DefaultValue)

    Sub CekKoneksi()
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If
    End Sub

    Sub ButtonNav(s As Object, p As Panel)
        Dim b As Button = CType(s, Button)
        btnEmployee.BackColor = Color.DodgerBlue
        btnEmployee.ForeColor = Color.White
        btnMenu.BackColor = Color.DodgerBlue
        btnMenu.ForeColor = Color.White
        btnMember.BackColor = Color.DodgerBlue
        btnMember.ForeColor = Color.White
        btnPassword.BackColor = Color.DodgerBlue
        btnPassword.ForeColor = Color.White

        b.BackColor = SystemColors.Control
        b.ForeColor = Color.Black

        p.BringToFront()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        ButtonNav(sender, panelEmployee)
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ButtonNav(sender, panelMenu)
    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        ButtonNav(sender, panelMember)
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnEmployeeAdd_Click(sender As Object, e As EventArgs) Handles btnEmployeeAdd.Click
        Dim f As New FormEmployee
        f.ShowDialog()
    End Sub

    Private Sub btnEmployeeEdit_Click(sender As Object, e As EventArgs) Handles btnEmployeeEdit.Click
        Dim f As New FormEmployee
        f.ShowDialog()
    End Sub

    Private Sub btnEmployeeDelete_Click(sender As Object, e As EventArgs) Handles btnEmployeeDelete.Click

    End Sub

    Private Sub btnMenuAdd_Click(sender As Object, e As EventArgs) Handles btnMenuAdd.Click
        Dim f As New FormMenu
        f.ShowDialog()
    End Sub

    Private Sub btnMenuEdit_Click(sender As Object, e As EventArgs) Handles btnMenuEdit.Click
        Dim f As New FormMenu
        f.ShowDialog()
    End Sub

    Private Sub btnMenuDelete_Click(sender As Object, e As EventArgs) Handles btnMenuDelete.Click

    End Sub

    Private Sub btnMemberAdd_Click(sender As Object, e As EventArgs) Handles btnMemberAdd.Click
        Dim f As New FormMember
        f.ShowDialog()
    End Sub

    Private Sub btnMemberEdit_Click(sender As Object, e As EventArgs) Handles btnMemberEdit.Click
        Dim f As New FormMember
        f.ShowDialog()
    End Sub

    Private Sub btnMemberDelete_Click(sender As Object, e As EventArgs) Handles btnMemberDelete.Click

    End Sub
End Class