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
        tbOldPassword.Text = ""
        tbNewPassword.Text = ""
        tbConfirmPassword.Text = ""
        p.BringToFront()
    End Sub

    Sub GetOrderDetail()
        CekKoneksi()
        Dim c As New SqlDataAdapter("Select [DetailId],[MsMenu].[Name],[Qty],[Status] from [DetailOrder] join [MsMenu] on([MsMenu].[MenuId]=[DetailOrder].[MenuId]) where [OrderId]='" + cbOrderId.SelectedValue.ToString + "'", konek)
        Dim d As New DataSet
        c.Fill(d)
        dgAddOrderList.DataSource = d.Tables(0)
    End Sub

    Sub GetOrderId()
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If

        Dim cmd As New SqlDataAdapter("Select [OrderId] from [HeaderOrder] where [Payment]='-'", konek)
        Dim ds As New DataSet
        cmd.Fill(ds)

        cbOrderId.DataSource = ds.Tables(0)
        cbOrderId.DisplayMember = "OrderId"
        cbOrderId.ValueMember = "OrderId"

        GetOrderDetail()
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
        GetOrderId()

    End Sub

    Private Sub cbOrderId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOrderId.SelectedIndexChanged
        GetOrderDetail()
    End Sub

    Private Sub dgAddOrderList_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgAddOrderList.EditingControlShowing
        Dim cb = CType(e.Control, ComboBox)
        RemoveHandler cb.SelectedIndexChanged, AddressOf dgOrderListComboBox
        AddHandler cb.SelectedIndexChanged, AddressOf dgOrderListComboBox
    End Sub

    Sub dgOrderListComboBox(sender As Object, e As EventArgs)
        CekKoneksi()
        Dim cb = CType(sender, ComboBox)
        Dim cmd As New SqlCommand("Update [DetailOrder] set [Status]='" + cb.SelectedItem.ToString + "' where [DetailId]=@id", konek)
        cmd.Parameters.AddWithValue("@id", dgAddOrderList.Item(0, dgAddOrderList.CurrentCell.RowIndex).Value)
        cmd.ExecuteNonQuery
    End Sub

    Private Sub dgAddOrderList_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgAddOrderList.CellEnter
        Dim util As New Util
        pbMenu.Image = util.GetImage(dgAddOrderList.Item(0, e.RowIndex).Value.ToString)
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