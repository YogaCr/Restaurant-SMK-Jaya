Imports System.Data.SqlClient
Public Class FormCashier
    Dim konek As New SqlConnection(My.Settings.Properties.Item("ConnectionString").DefaultValue)
    Dim idmenu As String
    Dim dt As New DataTable
    Sub CekKoneksi()
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If
    End Sub

    Sub ButtonNav(s As Object, p As Panel)
        Dim b As Button = CType(s, Button)
        btnAddOrder.BackColor = Color.DodgerBlue
        btnAddOrder.ForeColor = Color.White
        btnPayment.BackColor = Color.DodgerBlue
        btnPayment.ForeColor = Color.White
        btnPassword.BackColor = Color.DodgerBlue
        btnPassword.ForeColor = Color.White

        b.BackColor = SystemColors.Control
        b.ForeColor = Color.Black
        tbOldPassword.Text = ""
        tbNewPassword.Text = ""
        tbConfirmPassword.Text = ""
        p.BringToFront()
    End Sub

    Sub GetMenu()
        CekKoneksi()
        Dim cmd As New SqlDataAdapter("Select [MenuId],[Name],[Price] from [MsMenu]", konek)
        Dim ds As New DataSet
        cmd.Fill(ds)
        dgMenu.DataSource = ds.Tables(0)
        konek.Close()
    End Sub

    Sub GetTable()
        CekKoneksi()
        Dim cmd As New SqlCommand("Select top(1) [TableId] from [MsTable] where [Status]=0", konek)
        Dim reader = cmd.ExecuteReader
        If reader.Read Then
            lblTable.Text = "Table : " + reader.GetInt32(0).ToString
        Else
            MessageBox.Show("Maaf,restoran masih penuh")
        End If
        reader.Close()
        konek.Close()
    End Sub

    Sub GetOrderId()
        CekKoneksi()
        Dim dataId = New DataTable
        dataId.Columns.Add("OrderId")
        Dim cmd As New SqlCommand("Select [OrderId] from [HeaderOrder] where [Payment]='-'", konek)
        Dim reader = cmd.ExecuteReader
        While reader.Read
            Dim check As New SqlCommand("Select [Status] from [DetailOrder] where not [status]='Delivered'", konek)
            Dim r = check.ExecuteReader
            If r.Read Then
                Continue While
            End If
            dataId.Rows.Add(reader.GetString(0))
        End While

        cbOrderId.DataSource = dataId
        cbOrderId.DisplayMember = "OrderId"
        cbOrderId.ValueMember = "OrderId"

        If dataId.Rows.Count > 0 Then
            GetOrderDetail()
        End If

    End Sub



    Private Sub FormCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Columns.Add("MenuId")
        dt.Columns.Add("Name")
        dt.Columns.Add("Qty")
        dt.Columns.Add("Price")
        dt.Columns.Add("Total")
        dgAddOrderList.DataSource = dt
        CekKoneksi()
        Dim cmd As New SqlCommand("Select [Name] from [MsEmployee] where [EmployeeId]=@id", konek)
        cmd.Parameters.AddWithValue("@id", My.Settings.Id)
        Dim reader = cmd.ExecuteReader
        If reader.Read Then
            lblNama.Text = "Welcome, " + reader.GetString(0)
        End If
        reader.Close()

        Dim adapter As New SqlDataAdapter("Select [MemberId],[Name] from [SelectMember]", konek)
        Dim ds As New DataSet
        adapter.Fill(ds)
        cbMemberList.DataSource = ds.Tables(0)
        cbMemberList.ValueMember = "MemberId"
        cbMemberList.DisplayMember = "Name"
        konek.Close()
        GetMenu()

        cbPayment.SelectedIndex = 0
        cbBankName.SelectedIndex = 0

        GetTable()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        ButtonNav(sender, panelAddOrder)
        GetMenu()
        GetTable()
        dt.Clear()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        ButtonNav(sender, panelPayment)
        GetOrderId()
    End Sub

    Private Sub dgMenu_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgMenu.CellEnter
        idmenu = dgMenu.Item(0, e.RowIndex).Value.ToString
        Dim util As New Util
        pbMenu.Image = util.GetImage(dgMenu.Item(0, e.RowIndex).Value.ToString)
    End Sub

    Private Sub btnOrderPlus_Click(sender As Object, e As EventArgs) Handles btnOrderPlus.Click
        Dim util As New Util
        If Not util.NumberValidation(tbOrderQty.Text) Then
            Return
        End If

        If Integer.Parse(tbOrderQty.Text) < 1 Then
            MessageBox.Show(Nothing, "Bilangan tidak boleh kurang dari 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim row As DataRow() = dt.Select("MenuId='" + idmenu + "'")
        If row.Length > 0 Then
            row(0).Item(2) += Integer.Parse(tbOrderQty.Text)
            row(0).Item(4) = row(0).Item(2) * row(0).Item(4)
        Else
            Dim rw As DataRow() = CType(dgMenu.DataSource, DataTable).Select("MenuId='" + idmenu + "'")
            dt.Rows.Add(idmenu, rw(0).Item(1), Integer.Parse(tbOrderQty.Text), rw(0).Item(2), Integer.Parse(tbOrderQty.Text) * rw(0).Item(2))
        End If
    End Sub

    Private Sub btnOrderMin_Click(sender As Object, e As EventArgs) Handles btnOrderMin.Click
        Dim util As New Util
        If Not util.NumberValidation(tbOrderQty.Text) Then
            Return
        End If
        If Integer.Parse(tbOrderQty.Text) < 1 Then
            MessageBox.Show(Nothing, "Bilangan tidak boleh kurang dari 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim row As DataRow() = dt.Select("MenuId=" + idmenu)
        If row IsNot Nothing Then
            If row(0).Item(2) <= Integer.Parse(tbOrderQty.Text) Then
                row(0).Delete()
            Else
                row(0).Item(2) -= Integer.Parse(tbOrderQty.Text)
                row(0).Item(4) = row(0).Item(2) * row(0).Item(4)
            End If

        Else
            MessageBox.Show(Nothing, "Pelanggan belum memesan menu ini", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub checkNotMember_CheckedChanged(sender As Object, e As EventArgs) Handles checkNotMember.CheckedChanged
        If checkNotMember.Checked Then
            cbMemberList.Enabled = False
        Else
            cbMemberList.Enabled = True
        End If
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        If dt.Rows.Count < 1 Then
            MessageBox.Show(Nothing, "Pelanggan belum memesan apapun", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If
        Dim idOrder As String = Date.Now.Year.ToString
        If Date.Now.Month < 10 Then
            idOrder += "0" + Date.Now.Month.ToString
        Else
            idOrder += Date.Now.Month.ToString
        End If

        Dim checkid As New SqlCommand("Select [OrderId] from [HeaderOrder] where [OrderId] like '" + idOrder + "%' order by cast(substring([OrderId],7,4)  as int) desc", konek)
        Dim reader = checkid.ExecuteReader
        If reader.Read Then
            Select Case Integer.Parse(reader.GetString(0).Substring(6, 4))
                Case 1 To 8
                    idOrder += "000" + (Integer.Parse(reader.GetString(0).Substring(6, 4)) + 1).ToString
                Case 9 To 98
                    idOrder += "00" + (Integer.Parse(reader.GetString(0).Substring(6, 4)) + 1).ToString
                Case 99 To 998
                    idOrder += "0" + (Integer.Parse(reader.GetString(0).Substring(6, 4)) + 1).ToString
                Case 999 To 9998
                    idOrder += (Integer.Parse(reader.GetString(0).Substring(6, 4)) + 1).ToString
            End Select
        Else
            idOrder += "0001"
        End If
        reader.Close()

        Dim cmd As New SqlCommand("Insert into [HeaderOrder] values(@id,@employee,@member,@date,'-','-','-',@table)", konek)
        cmd.Parameters.AddWithValue("@id", idOrder)
        cmd.Parameters.AddWithValue("@employee", My.Settings.Id)
        cmd.Parameters.AddWithValue("@table", lblTable.Text.Substring(8))
        If checkNotMember.Checked Then
            cmd.Parameters.AddWithValue("@member", "MBR00001")
        Else
            cmd.Parameters.AddWithValue("@member", cbMemberList.SelectedValue.ToString)
        End If
        cmd.Parameters.AddWithValue("@date", Date.Now)

        If cmd.ExecuteNonQuery = 1 Then
            Dim x = 0
            Dim settable = New SqlCommand("Update [MsTable] set [Status]=1 where [TableId]=@id", konek)
            settable.Parameters.AddWithValue("@id", lblTable.Text.Substring(8))
            settable.ExecuteNonQuery()

            While x < dt.Rows.Count
                Dim insertDetail As New SqlCommand("Insert into [DetailOrder]([OrderId],[MenuId],[Qty],[Price],[Status]) values(@id,@menu,@qty,@price,'Pending')", konek)
                insertDetail.Parameters.AddWithValue("@id", idOrder)
                insertDetail.Parameters.AddWithValue("@menu", dt.Rows(x).Item(0))
                insertDetail.Parameters.AddWithValue("@qty", dt.Rows(x).Item(2))
                insertDetail.Parameters.AddWithValue("@price", dt.Rows(x).Item(4))
                insertDetail.ExecuteNonQuery()
                x += 1
            End While
            MessageBox.Show(Nothing, "Pemesanan berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GetTable()
            dt.Clear()
        Else
            MessageBox.Show(Nothing, "Pemesanan gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPaymentSave_Click(sender As Object, e As EventArgs) Handles btnPaymentSave.Click
        CekKoneksi()
        If cbPayment.SelectedIndex = -1 Then
            MessageBox.Show(Nothing, "Tolong pilih metode pembayaran", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim cmd As New SqlCommand("Update [HeaderOrder] set [Payment]=@payment,[Bank]=@bank,[CardNumber]=@card where [OrderId]=@id", konek)
        cmd.Parameters.AddWithValue("@id", cbOrderId.SelectedValue.ToString)
        If cbPayment.SelectedIndex = 0 Then
            Dim util = New Util
            If Not util.NumberValidation(tbCardNumber.Text) Then
                Return
            End If
            cmd.Parameters.AddWithValue("@payment", "Credit Card")
            cmd.Parameters.AddWithValue("@bank", cbBankName.SelectedValue.ToString)
            cmd.Parameters.AddWithValue("@card", tbCardNumber.Text)
        ElseIf cbPayment.SelectedIndex = 1 Then
            If lblKembalian.Text.Contains("-") Then
                MessageBox.Show(Nothing, "Uang kurang", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim util = New Util
            If Not util.NumberValidation(tbCashBayar.Text) Then
                Return
            End If
            cmd.Parameters.AddWithValue("@payment", "Cash")
            cmd.Parameters.AddWithValue("@bank", "-")
            cmd.Parameters.AddWithValue("@card", "-")
        End If

        If cmd.ExecuteNonQuery = 1 Then
            Dim gettableid = New SqlCommand("Select [Tableid] from [HeaderOrder] where [OrderId]=@id", konek)
            gettableid.Parameters.AddWithValue("@id", cbOrderId.SelectedValue.ToString)
            Dim reader = gettableid.ExecuteReader
            If reader.Read Then
                Dim settable = New SqlCommand("Update [MsTable] set [Status]=0 where [TableId]=@id", konek)
                settable.Parameters.AddWithValue("@id", reader.GetInt32(0))
                settable.ExecuteNonQuery()
            End If
            MessageBox.Show(Nothing, "Pembayaran berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblKembalian.Text = "Rp. 0"
            tbCardNumber.Text = ""
            lblTotal.Text = "Rp. 0"
            GetOrderId()
        Else
            MessageBox.Show(Nothing, "Pembayaran gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cbPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPayment.SelectedIndexChanged
        If cbPayment.SelectedIndex = 0 Then
            gbPayCredit.Visible = True
            gbCash.Visible = False
        ElseIf cbPayment.SelectedIndex = 1 Then
            gbPayCredit.Visible = False
            gbCash.Visible = True
        End If
    End Sub

    Private Sub cbOrderId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOrderId.SelectedIndexChanged
        GetOrderDetail()
    End Sub

    Sub GetOrderDetail()
        If konek.State = ConnectionState.Closed Then
            konek.Open()
        End If

        Dim adapter As New SqlDataAdapter("Select * from [MenuDetail] where [OrderId]='" + cbOrderId.SelectedValue.ToString + "'", konek)
        Dim ds As New DataSet
        adapter.Fill(ds)
        dgPayment.DataSource = ds.Tables(0)

        Dim x = 0
        Dim total = 0
        While x < ds.Tables(0).Rows.Count
            total += Integer.Parse(ds.Tables(0).Rows(x).Item(3))
            x += 1
        End While
        lblTotal.Text = "Rp. " + total.ToString
    End Sub

    Private Sub tbCashBayar_TextChanged(sender As Object, e As EventArgs) Handles tbCashBayar.TextChanged
        If tbCashBayar.Text.Length > 0 Then
            Dim util = New Util
            If Not util.NumberValidation(tbCashBayar.Text) Then
                Return
            End If
        End If

        Dim kembalian = Double.Parse(tbCashBayar.Text) - Double.Parse(lblTotal.Text.Substring(4))
        lblKembalian.Text = "Rp. " + kembalian.ToString
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

    Sub GenerateReport()
        Dim ls As New List(Of String)
        ls.Add("January")
        ls.Add("February")
        ls.Add("March")
        ls.Add("April")
        ls.Add("May")
        ls.Add("June")
        ls.Add("July")
        ls.Add("August")
        ls.Add("September")
        ls.Add("October")
        ls.Add("November")
        ls.Add("December")
        dtReportFrom.MaxDate = dtReportTo.Value
        dtReportTo.MinDate = dtReportFrom.Value
        CekKoneksi()
        Dim fromDate = dtReportFrom.Value
        Dim toDate = dtReportTo.Value
        Dim dt As New DataTable
        dt.Columns.Add("Month")
        dt.Columns.Add("Total")
        While fromDate <= toDate
            Dim idOrder = fromDate.Year.ToString
            If fromDate.Month < 10 Then
                idOrder += "0" + fromDate.Month.ToString
            Else
                idOrder += fromDate.Month.ToString
            End If

            Dim cmd As New SqlCommand("Select coalesce(sum([Price]),0) as total from [DetailOrder] where [OrderId] like '" + idOrder + "%'", konek)
            Dim reader = cmd.ExecuteReader
            If reader.Read Then
                If Not reader.IsDBNull(0) Then
                    dt.Rows.Add(ls(fromDate.Month - 1) + " " + fromDate.Year.ToString, reader.GetValue(0))
                End If

            End If
            fromDate = fromDate.AddMonths(1)
        End While
        chReport.DataSource = dt
        chReport.Series.FindByName("Series1").XValueMember = "Month"
        chReport.Series.FindByName("Series1").YValueMembers = "Total"

    End Sub

    Private Sub dtReportFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtReportFrom.ValueChanged
        GenerateReport()
    End Sub

    Private Sub dtReportTo_ValueChanged(sender As Object, e As EventArgs) Handles dtReportTo.ValueChanged
        GenerateReport()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ButtonNav(sender, panelReport)
        GenerateReport()
    End Sub
End Class