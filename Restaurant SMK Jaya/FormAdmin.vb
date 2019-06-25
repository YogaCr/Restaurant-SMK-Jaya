Imports System.Data.SqlClient
Public Class FormAdmin
    Dim konek As New SqlConnection(My.Settings.Properties.Item("ConnectionString").DefaultValue)
    Dim id As String
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
        id = Nothing
        b.BackColor = SystemColors.Control
        b.ForeColor = Color.Black
        tbOldPassword.Text = ""
        tbNewPassword.Text = ""
        tbConfirmPassword.Text = ""
        p.BringToFront()

    End Sub
    Sub GetEmployee(q As String)
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If
        Dim cmd As New SqlDataAdapter("Select [EmployeeId],[Name],[Email],[Handphone],[Position] from [MsEmployee] where [EmployeeId] like '%" + q + "%' or [Name] like '%" + q + "%' or [Email] like '%" + q + "%' or [Handphone] like '%" + q + "%'", konek)
        Dim ds As New DataSet
        cmd.Fill(ds)
        dgEmployee.DataSource = ds.Tables(0)
        konek.Close()
    End Sub

    Sub GetMenu(q As String)
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If
        Dim cmd As New SqlDataAdapter("Select [MenuId],[Name],[Price] from [MsMenu] where [Name] like '%" + q + "%'", konek)
        Dim ds As New DataSet
        cmd.Fill(ds)
        dgMenu.DataSource = ds.Tables(0)
        konek.Close()
    End Sub

    Sub GetMember(q As String)
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If
        Dim cmd As New SqlDataAdapter("Select [MemberId],[Name],[Email],[JoinDate] from [SelectMember] where [MemberId] like '%" + q + "%' or [Name] like '%" + q + "%' or [Email] like '%" + q + "%'", konek)
        Dim ds As New DataSet
        cmd.Fill(ds)
        dgMember.DataSource = ds.Tables(0)
        konek.Close()
    End Sub



    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        ButtonNav(sender, panelEmployee)
        tbEmployeeCari.Text = ""
        GetEmployee("")
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        ButtonNav(sender, panelMenu)
        tbMenuCari.Text = ""
        GetMenu("")
    End Sub

    Private Sub btnMember_Click(sender As Object, e As EventArgs) Handles btnMember.Click
        ButtonNav(sender, panelMember)
        tbMemberCari.Text = ""
        GetMember("")
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
        GetEmployee("")
    End Sub

    Private Sub btnEmployeeAdd_Click(sender As Object, e As EventArgs) Handles btnEmployeeAdd.Click
        Dim f As New FormEmployee
        If f.ShowDialog() = DialogResult.OK Then
            GetEmployee(tbEmployeeCari.Text)
        End If
    End Sub

    Private Sub btnEmployeeEdit_Click(sender As Object, e As EventArgs) Handles btnEmployeeEdit.Click
        If id Is Nothing Then
            MessageBox.Show(Nothing, "Tolong pilih data terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim f As New FormEmployee
        f.id = id
        If f.ShowDialog() = DialogResult.OK Then
            GetEmployee(tbEmployeeCari.Text)
        End If
    End Sub

    Private Sub btnEmployeeDelete_Click(sender As Object, e As EventArgs) Handles btnEmployeeDelete.Click
        If id Is Nothing Then
            MessageBox.Show(Nothing, "Tolong pilih data terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If MessageBox.Show(Nothing, "Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        CekKoneksi()
        Dim cmd As New SqlCommand("Delete from [MsEmployee] where [EmployeeId]=@id", konek)
        cmd.Parameters.AddWithValue("@id", id)
        If cmd.ExecuteNonQuery = 1 Then
            MessageBox.Show(Nothing, "Hapus pegawai berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetEmployee(tbEmployeeCari.Text)
        End If
    End Sub

    Private Sub btnMenuAdd_Click(sender As Object, e As EventArgs) Handles btnMenuAdd.Click
        Dim f As New FormMenu
        If f.ShowDialog() = DialogResult.OK Then
            GetMenu(tbMenuCari.Text)
        End If
    End Sub

    Private Sub btnMenuEdit_Click(sender As Object, e As EventArgs) Handles btnMenuEdit.Click
        If id Is Nothing Then
            MessageBox.Show(Nothing, "Tolong pilih data terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim f As New FormMenu
        f.id = id
        If f.ShowDialog() = DialogResult.OK Then
            GetMenu(tbMenuCari.Text)
        End If
    End Sub

    Private Sub btnMenuDelete_Click(sender As Object, e As EventArgs) Handles btnMenuDelete.Click
        If id Is Nothing Then
            MessageBox.Show(Nothing, "Tolong pilih data terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show(Nothing, "Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        CekKoneksi()
        Dim cmd As New SqlCommand("Delete from [MsMenu] where [MenuId]=@id", konek)
        cmd.Parameters.AddWithValue("@id", id)
        If cmd.ExecuteNonQuery = 1 Then
            MessageBox.Show(Nothing, "Hapus menu berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetMenu(tbMenuCari.Text)
        End If
    End Sub

    Private Sub btnMemberAdd_Click(sender As Object, e As EventArgs) Handles btnMemberAdd.Click
        Dim f As New FormMember
        If f.ShowDialog() = DialogResult.OK Then
            GetMember(tbMemberCari.Text)
        End If
    End Sub

    Private Sub btnMemberEdit_Click(sender As Object, e As EventArgs) Handles btnMemberEdit.Click
        If id Is Nothing Then
            MessageBox.Show(Nothing, "Tolong pilih data terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim f As New FormMember
        f.id = id
        If f.ShowDialog() = DialogResult.OK Then
            GetMember(tbMemberCari.Text)
        End If
    End Sub

    Private Sub btnMemberDelete_Click(sender As Object, e As EventArgs) Handles btnMemberDelete.Click
        If id Is Nothing Then
            MessageBox.Show(Nothing, "Tolong pilih data terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If MessageBox.Show(Nothing, "Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        CekKoneksi()
        Dim cmd As New SqlCommand("Delete from [MsMember] where [MemberId]=@id", konek)
        cmd.Parameters.AddWithValue("@id", id)
        If cmd.ExecuteNonQuery = 1 Then
            MessageBox.Show(Nothing, "Hapus member berhasil", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetMember(tbMemberCari.Text)
        End If
    End Sub

    Private Sub tbEmployeeCari_TextChanged(sender As Object, e As EventArgs) Handles tbEmployeeCari.TextChanged
        GetEmployee(tbEmployeeCari.Text)
    End Sub

    Private Sub tbMemberCari_TextChanged(sender As Object, e As EventArgs) Handles tbMemberCari.TextChanged
        GetMember(tbMemberCari.Text)
    End Sub

    Private Sub tbMenuCari_TextChanged(sender As Object, e As EventArgs) Handles tbMenuCari.TextChanged
        pbMenu.Image = Nothing
        GetMenu(tbMenuCari.Text)
    End Sub

    Private Sub dgMenu_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgMenu.CellEnter
        id = dgMenu.Item(0, e.RowIndex).Value.ToString
        Dim util As New Util
        pbMenu.Image = util.GetImage(id)
    End Sub

    Private Sub dgEmployee_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgEmployee.CellEnter
        id = dgEmployee.Item(0, e.RowIndex).Value.ToString
    End Sub

    Private Sub dgMember_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgMember.CellEnter
        id = dgMember.Item(0, e.RowIndex).Value.ToString
    End Sub

    Private Sub btnSavePassword_Click(sender As Object, e As EventArgs) Handles btnSavePassword.Click
        Dim util As New Util
        Dim ls As New List(Of TextBox)
        ls.Add(tbOldPassword)
        ls.Add(tbNewPassword)
        ls.Add(tbConfirmPassword)
        If Not util.TextboxValidation(ls) Then
            Return
        End If
        If util.PasswordValidation(tbOldPassword.Text, tbNewPassword.Text, tbConfirmPassword.Text) Then
            MessageBox.Show(Nothing, "Ubah password berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbOldPassword.Text = ""
            tbNewPassword.Text = ""
            tbConfirmPassword.Text = ""
        End If
    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        ButtonNav(sender, panelPassword)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show(Nothing, "Apakah anda yakin ingin keluar?", "Keluar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            My.Settings.Id = ""
            Dim f As New FormLogin
            Close()
        End If
    End Sub
End Class