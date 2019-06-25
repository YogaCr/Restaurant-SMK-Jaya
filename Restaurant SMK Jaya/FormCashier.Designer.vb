<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelAddOrder = New System.Windows.Forms.Panel()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.checkNotMember = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbMemberList = New System.Windows.Forms.ComboBox()
        Me.dgAddOrderList = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbOrderQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbMenu = New System.Windows.Forms.PictureBox()
        Me.dgMenu = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOrderPlus = New System.Windows.Forms.Button()
        Me.btnOrderMin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panelPayment = New System.Windows.Forms.Panel()
        Me.btnPaymentSave = New System.Windows.Forms.Button()
        Me.gbPayCredit = New System.Windows.Forms.GroupBox()
        Me.gbCash = New System.Windows.Forms.GroupBox()
        Me.tbCashBayar = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.tbCardNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbBankName = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbPayment = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.cbOrderId = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgPayment = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.panelPassword = New System.Windows.Forms.Panel()
        Me.btnSavePassword = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbNewPassword = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbOldPassword = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.panelReport = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.chReport = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtReportFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtReportTo = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelAddOrder.SuspendLayout()
        CType(Me.dgAddOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPayment.SuspendLayout()
        Me.gbPayCredit.SuspendLayout()
        Me.gbCash.SuspendLayout()
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPassword.SuspendLayout()
        Me.panelReport.SuspendLayout()
        CType(Me.chReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.btnPassword)
        Me.Panel2.Controls.Add(Me.btnPayment)
        Me.Panel2.Controls.Add(Me.btnAddOrder)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 48)
        Me.Panel2.TabIndex = 14
        '
        'btnPassword
        '
        Me.btnPassword.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPassword.FlatAppearance.BorderSize = 0
        Me.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.White
        Me.btnPassword.Location = New System.Drawing.Point(259, 0)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(115, 48)
        Me.btnPassword.TabIndex = 3
        Me.btnPassword.Text = "Password"
        Me.btnPassword.UseVisualStyleBackColor = True
        '
        'btnPayment
        '
        Me.btnPayment.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPayment.FlatAppearance.BorderSize = 0
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.Location = New System.Drawing.Point(129, 0)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(130, 48)
        Me.btnPayment.TabIndex = 1
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BackColor = System.Drawing.SystemColors.Control
        Me.btnAddOrder.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddOrder.FlatAppearance.BorderSize = 0
        Me.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddOrder.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.ForeColor = System.Drawing.Color.Black
        Me.btnAddOrder.Location = New System.Drawing.Point(0, 0)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(129, 48)
        Me.btnAddOrder.TabIndex = 0
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.lblNama)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 111)
        Me.Panel1.TabIndex = 13
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(722, 77)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.TabStop = False
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblNama
        '
        Me.lblNama.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.ForeColor = System.Drawing.Color.White
        Me.lblNama.Location = New System.Drawing.Point(285, 41)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(512, 23)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Welcome,"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(81, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SMK Jaya"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Restaurant"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'panelAddOrder
        '
        Me.panelAddOrder.Controls.Add(Me.lblTable)
        Me.panelAddOrder.Controls.Add(Me.btnOrder)
        Me.panelAddOrder.Controls.Add(Me.checkNotMember)
        Me.panelAddOrder.Controls.Add(Me.Label5)
        Me.panelAddOrder.Controls.Add(Me.cbMemberList)
        Me.panelAddOrder.Controls.Add(Me.dgAddOrderList)
        Me.panelAddOrder.Controls.Add(Me.Label3)
        Me.panelAddOrder.Controls.Add(Me.tbOrderQty)
        Me.panelAddOrder.Controls.Add(Me.Label8)
        Me.panelAddOrder.Controls.Add(Me.pbMenu)
        Me.panelAddOrder.Controls.Add(Me.dgMenu)
        Me.panelAddOrder.Controls.Add(Me.btnOrderPlus)
        Me.panelAddOrder.Controls.Add(Me.btnOrderMin)
        Me.panelAddOrder.Controls.Add(Me.Label4)
        Me.panelAddOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelAddOrder.Location = New System.Drawing.Point(0, 159)
        Me.panelAddOrder.Name = "panelAddOrder"
        Me.panelAddOrder.Size = New System.Drawing.Size(800, 441)
        Me.panelAddOrder.TabIndex = 15
        '
        'lblTable
        '
        Me.lblTable.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTable.AutoSize = True
        Me.lblTable.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTable.ForeColor = System.Drawing.Color.Black
        Me.lblTable.Location = New System.Drawing.Point(86, 32)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(60, 17)
        Me.lblTable.TabIndex = 25
        Me.lblTable.Text = "Table : 1"
        Me.lblTable.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblTable.Visible = False
        '
        'btnOrder
        '
        Me.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOrder.FlatAppearance.BorderSize = 0
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.White
        Me.btnOrder.Location = New System.Drawing.Point(673, 403)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(58, 26)
        Me.btnOrder.TabIndex = 24
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'checkNotMember
        '
        Me.checkNotMember.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.checkNotMember.AutoSize = True
        Me.checkNotMember.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkNotMember.Location = New System.Drawing.Point(633, 378)
        Me.checkNotMember.Name = "checkNotMember"
        Me.checkNotMember.Size = New System.Drawing.Size(98, 17)
        Me.checkNotMember.TabIndex = 23
        Me.checkNotMember.Text = "Not a member"
        Me.checkNotMember.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(601, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Member"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbMemberList
        '
        Me.cbMemberList.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbMemberList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMemberList.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMemberList.FormattingEnabled = True
        Me.cbMemberList.Location = New System.Drawing.Point(604, 347)
        Me.cbMemberList.Name = "cbMemberList"
        Me.cbMemberList.Size = New System.Drawing.Size(127, 25)
        Me.cbMemberList.TabIndex = 21
        '
        'dgAddOrderList
        '
        Me.dgAddOrderList.AllowUserToAddRows = False
        Me.dgAddOrderList.AllowUserToDeleteRows = False
        Me.dgAddOrderList.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.dgAddOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAddOrderList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.DataGridViewTextBoxColumn5, Me.Column1, Me.DataGridViewTextBoxColumn6, Me.Column2})
        Me.dgAddOrderList.Location = New System.Drawing.Point(89, 280)
        Me.dgAddOrderList.Name = "dgAddOrderList"
        Me.dgAddOrderList.ReadOnly = True
        Me.dgAddOrderList.Size = New System.Drawing.Size(504, 149)
        Me.dgAddOrderList.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(599, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Qty"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbOrderQty
        '
        Me.tbOrderQty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbOrderQty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOrderQty.Location = New System.Drawing.Point(635, 208)
        Me.tbOrderQty.Name = "tbOrderQty"
        Me.tbOrderQty.Size = New System.Drawing.Size(32, 25)
        Me.tbOrderQty.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(599, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Photo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pbMenu
        '
        Me.pbMenu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbMenu.Location = New System.Drawing.Point(599, 86)
        Me.pbMenu.Name = "pbMenu"
        Me.pbMenu.Size = New System.Drawing.Size(132, 116)
        Me.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMenu.TabIndex = 16
        Me.pbMenu.TabStop = False
        '
        'dgMenu
        '
        Me.dgMenu.AllowUserToAddRows = False
        Me.dgMenu.AllowUserToDeleteRows = False
        Me.dgMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgMenu.Location = New System.Drawing.Point(89, 58)
        Me.dgMenu.Name = "dgMenu"
        Me.dgMenu.ReadOnly = True
        Me.dgMenu.Size = New System.Drawing.Size(504, 196)
        Me.dgMenu.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MenuId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'btnOrderPlus
        '
        Me.btnOrderPlus.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOrderPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOrderPlus.FlatAppearance.BorderSize = 0
        Me.btnOrderPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderPlus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderPlus.ForeColor = System.Drawing.Color.White
        Me.btnOrderPlus.Location = New System.Drawing.Point(673, 208)
        Me.btnOrderPlus.Name = "btnOrderPlus"
        Me.btnOrderPlus.Size = New System.Drawing.Size(26, 26)
        Me.btnOrderPlus.TabIndex = 10
        Me.btnOrderPlus.Text = "+"
        Me.btnOrderPlus.UseVisualStyleBackColor = False
        '
        'btnOrderMin
        '
        Me.btnOrderMin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnOrderMin.BackColor = System.Drawing.Color.Red
        Me.btnOrderMin.FlatAppearance.BorderSize = 0
        Me.btnOrderMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderMin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderMin.ForeColor = System.Drawing.Color.White
        Me.btnOrderMin.Location = New System.Drawing.Point(705, 208)
        Me.btnOrderMin.Name = "btnOrderMin"
        Me.btnOrderMin.Size = New System.Drawing.Size(26, 26)
        Me.btnOrderMin.TabIndex = 8
        Me.btnOrderMin.Text = "-"
        Me.btnOrderMin.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(321, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 45)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Add Order"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'panelPayment
        '
        Me.panelPayment.Controls.Add(Me.btnPaymentSave)
        Me.panelPayment.Controls.Add(Me.cbPayment)
        Me.panelPayment.Controls.Add(Me.Label7)
        Me.panelPayment.Controls.Add(Me.lblTotal)
        Me.panelPayment.Controls.Add(Me.cbOrderId)
        Me.panelPayment.Controls.Add(Me.Label6)
        Me.panelPayment.Controls.Add(Me.dgPayment)
        Me.panelPayment.Controls.Add(Me.Label11)
        Me.panelPayment.Controls.Add(Me.gbCash)
        Me.panelPayment.Controls.Add(Me.gbPayCredit)
        Me.panelPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPayment.Location = New System.Drawing.Point(0, 0)
        Me.panelPayment.Name = "panelPayment"
        Me.panelPayment.Size = New System.Drawing.Size(800, 600)
        Me.panelPayment.TabIndex = 26
        '
        'btnPaymentSave
        '
        Me.btnPaymentSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPaymentSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPaymentSave.FlatAppearance.BorderSize = 0
        Me.btnPaymentSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaymentSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaymentSave.ForeColor = System.Drawing.Color.White
        Me.btnPaymentSave.Location = New System.Drawing.Point(673, 569)
        Me.btnPaymentSave.Name = "btnPaymentSave"
        Me.btnPaymentSave.Size = New System.Drawing.Size(58, 26)
        Me.btnPaymentSave.TabIndex = 27
        Me.btnPaymentSave.Text = "Save"
        Me.btnPaymentSave.UseVisualStyleBackColor = False
        '
        'gbPayCredit
        '
        Me.gbPayCredit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbPayCredit.Controls.Add(Me.tbCardNumber)
        Me.gbPayCredit.Controls.Add(Me.Label10)
        Me.gbPayCredit.Controls.Add(Me.cbBankName)
        Me.gbPayCredit.Controls.Add(Me.Label9)
        Me.gbPayCredit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPayCredit.Location = New System.Drawing.Point(89, 506)
        Me.gbPayCredit.Name = "gbPayCredit"
        Me.gbPayCredit.Size = New System.Drawing.Size(642, 57)
        Me.gbPayCredit.TabIndex = 26
        Me.gbPayCredit.TabStop = False
        Me.gbPayCredit.Text = "Credit Card"
        '
        'gbCash
        '
        Me.gbCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.gbCash.Controls.Add(Me.tbCashBayar)
        Me.gbCash.Controls.Add(Me.Label12)
        Me.gbCash.Controls.Add(Me.lblKembalian)
        Me.gbCash.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCash.Location = New System.Drawing.Point(89, 506)
        Me.gbCash.Name = "gbCash"
        Me.gbCash.Size = New System.Drawing.Size(642, 57)
        Me.gbCash.TabIndex = 31
        Me.gbCash.TabStop = False
        Me.gbCash.Text = "Cash"
        '
        'tbCashBayar
        '
        Me.tbCashBayar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCashBayar.Location = New System.Drawing.Point(64, 22)
        Me.tbCashBayar.Name = "tbCashBayar"
        Me.tbCashBayar.Size = New System.Drawing.Size(233, 25)
        Me.tbCashBayar.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 17)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Bayar : "
        '
        'lblKembalian
        '
        Me.lblKembalian.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKembalian.Location = New System.Drawing.Point(319, 25)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(112, 17)
        Me.lblKembalian.TabIndex = 27
        Me.lblKembalian.Text = "Kembalian : Rp.0"
        '
        'tbCardNumber
        '
        Me.tbCardNumber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCardNumber.Location = New System.Drawing.Point(114, 22)
        Me.tbCardNumber.Name = "tbCardNumber"
        Me.tbCardNumber.Size = New System.Drawing.Size(198, 25)
        Me.tbCardNumber.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 17)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Card Number : "
        '
        'cbBankName
        '
        Me.cbBankName.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBankName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBankName.FormattingEnabled = True
        Me.cbBankName.Items.AddRange(New Object() {"BCA", "BNI", "BRI", "Mandiri", "BTN", "Danamon"})
        Me.cbBankName.Location = New System.Drawing.Point(415, 22)
        Me.cbBankName.Name = "cbBankName"
        Me.cbBankName.Size = New System.Drawing.Size(221, 25)
        Me.cbBankName.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(319, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Bank Name : "
        '
        'cbPayment
        '
        Me.cbPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPayment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPayment.FormattingEnabled = True
        Me.cbPayment.Items.AddRange(New Object() {"Credit Card", "Cash"})
        Me.cbPayment.Location = New System.Drawing.Point(374, 478)
        Me.cbPayment.Name = "cbPayment"
        Me.cbPayment.Size = New System.Drawing.Size(221, 25)
        Me.cbPayment.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(307, 481)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Payment"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(89, 453)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(642, 17)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "Total : Rp.0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbOrderId
        '
        Me.cbOrderId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrderId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrderId.FormattingEnabled = True
        Me.cbOrderId.Location = New System.Drawing.Point(153, 67)
        Me.cbOrderId.Name = "cbOrderId"
        Me.cbOrderId.Size = New System.Drawing.Size(221, 25)
        Me.cbOrderId.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(86, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Order ID"
        '
        'dgPayment
        '
        Me.dgPayment.AllowUserToAddRows = False
        Me.dgPayment.AllowUserToDeleteRows = False
        Me.dgPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.Column4})
        Me.dgPayment.Location = New System.Drawing.Point(89, 98)
        Me.dgPayment.Name = "dgPayment"
        Me.dgPayment.ReadOnly = True
        Me.dgPayment.Size = New System.Drawing.Size(642, 352)
        Me.dgPayment.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(348, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 45)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Payment"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.DataPropertyName = "MenuId"
        Me.Column3.HeaderText = "MenuId"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 68
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.DataPropertyName = "Qty"
        Me.Column1.HeaderText = "Qty"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 48
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "Total"
        Me.Column2.HeaderText = "Total"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 48
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "OrderId"
        Me.Column4.HeaderText = "OrderId"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'panelPassword
        '
        Me.panelPassword.Controls.Add(Me.btnSavePassword)
        Me.panelPassword.Controls.Add(Me.Label13)
        Me.panelPassword.Controls.Add(Me.tbConfirmPassword)
        Me.panelPassword.Controls.Add(Me.Label14)
        Me.panelPassword.Controls.Add(Me.tbNewPassword)
        Me.panelPassword.Controls.Add(Me.Label15)
        Me.panelPassword.Controls.Add(Me.tbOldPassword)
        Me.panelPassword.Controls.Add(Me.Label16)
        Me.panelPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPassword.Location = New System.Drawing.Point(0, 0)
        Me.panelPassword.Name = "panelPassword"
        Me.panelPassword.Size = New System.Drawing.Size(800, 600)
        Me.panelPassword.TabIndex = 26
        '
        'btnSavePassword
        '
        Me.btnSavePassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSavePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSavePassword.FlatAppearance.BorderSize = 0
        Me.btnSavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePassword.ForeColor = System.Drawing.Color.White
        Me.btnSavePassword.Location = New System.Drawing.Point(502, 259)
        Me.btnSavePassword.Name = "btnSavePassword"
        Me.btnSavePassword.Size = New System.Drawing.Size(58, 26)
        Me.btnSavePassword.TabIndex = 25
        Me.btnSavePassword.Text = "Save"
        Me.btnSavePassword.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(286, 212)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Confirm New Password"
        '
        'tbConfirmPassword
        '
        Me.tbConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmPassword.Location = New System.Drawing.Point(289, 228)
        Me.tbConfirmPassword.Name = "tbConfirmPassword"
        Me.tbConfirmPassword.Size = New System.Drawing.Size(271, 25)
        Me.tbConfirmPassword.TabIndex = 10
        Me.tbConfirmPassword.UseSystemPasswordChar = True
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(286, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "New Password"
        '
        'tbNewPassword
        '
        Me.tbNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbNewPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewPassword.Location = New System.Drawing.Point(289, 164)
        Me.tbNewPassword.Name = "tbNewPassword"
        Me.tbNewPassword.Size = New System.Drawing.Size(271, 25)
        Me.tbNewPassword.TabIndex = 8
        Me.tbNewPassword.UseSystemPasswordChar = True
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(286, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Old Password"
        '
        'tbOldPassword
        '
        Me.tbOldPassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tbOldPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOldPassword.Location = New System.Drawing.Point(289, 112)
        Me.tbOldPassword.Name = "tbOldPassword"
        Me.tbOldPassword.Size = New System.Drawing.Size(271, 25)
        Me.tbOldPassword.TabIndex = 6
        Me.tbOldPassword.UseSystemPasswordChar = True
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(281, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(284, 45)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Change Password"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'panelReport
        '
        Me.panelReport.Controls.Add(Me.dtReportTo)
        Me.panelReport.Controls.Add(Me.Label18)
        Me.panelReport.Controls.Add(Me.dtReportFrom)
        Me.panelReport.Controls.Add(Me.Label17)
        Me.panelReport.Controls.Add(Me.chReport)
        Me.panelReport.Controls.Add(Me.Label21)
        Me.panelReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelReport.Location = New System.Drawing.Point(0, 0)
        Me.panelReport.Name = "panelReport"
        Me.panelReport.Size = New System.Drawing.Size(800, 600)
        Me.panelReport.TabIndex = 26
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(338, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 45)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Report"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chReport
        '
        Me.chReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.chReport.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chReport.Legends.Add(Legend1)
        Me.chReport.Location = New System.Drawing.Point(69, 100)
        Me.chReport.Name = "chReport"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chReport.Series.Add(Series1)
        Me.chReport.Size = New System.Drawing.Size(689, 488)
        Me.chReport.TabIndex = 5
        Me.chReport.Text = "Chart1"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(66, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 17)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "From"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtReportFrom
        '
        Me.dtReportFrom.CustomFormat = "MMMM yyyy"
        Me.dtReportFrom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtReportFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReportFrom.Location = New System.Drawing.Point(113, 73)
        Me.dtReportFrom.Name = "dtReportFrom"
        Me.dtReportFrom.Size = New System.Drawing.Size(200, 22)
        Me.dtReportFrom.TabIndex = 19
        '
        'dtReportTo
        '
        Me.dtReportTo.CustomFormat = "MMMM yyyy"
        Me.dtReportTo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtReportTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtReportTo.Location = New System.Drawing.Point(393, 73)
        Me.dtReportTo.Name = "dtReportTo"
        Me.dtReportTo.Size = New System.Drawing.Size(200, 22)
        Me.dtReportTo.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(363, 77)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(23, 17)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "To"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FormCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.panelAddOrder)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelPayment)
        Me.Controls.Add(Me.panelPassword)
        Me.Controls.Add(Me.panelReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormChef"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelAddOrder.ResumeLayout(False)
        Me.panelAddOrder.PerformLayout()
        CType(Me.dgAddOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPayment.ResumeLayout(False)
        Me.panelPayment.PerformLayout()
        Me.gbPayCredit.ResumeLayout(False)
        Me.gbPayCredit.PerformLayout()
        Me.gbCash.ResumeLayout(False)
        Me.gbCash.PerformLayout()
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPassword.ResumeLayout(False)
        Me.panelPassword.PerformLayout()
        Me.panelReport.ResumeLayout(False)
        Me.panelReport.PerformLayout()
        CType(Me.chReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPassword As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents panelAddOrder As Panel
    Friend WithEvents btnOrderPlus As Button
    Friend WithEvents btnOrderMin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pbMenu As PictureBox
    Friend WithEvents dgMenu As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents tbOrderQty As TextBox
    Friend WithEvents dgAddOrderList As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents cbMemberList As ComboBox
    Friend WithEvents checkNotMember As CheckBox
    Friend WithEvents btnOrder As Button
    Private WithEvents lblTable As Label
    Friend WithEvents panelPayment As Panel
    Friend WithEvents dgPayment As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents cbOrderId As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents cbPayment As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gbPayCredit As GroupBox
    Friend WithEvents tbCardNumber As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbBankName As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnPaymentSave As Button
    Friend WithEvents gbCash As GroupBox
    Friend WithEvents tbCashBayar As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblKembalian As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents panelPassword As Panel
    Friend WithEvents btnSavePassword As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents tbConfirmPassword As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbNewPassword As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbOldPassword As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents panelReport As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents chReport As DataVisualization.Charting.Chart
    Friend WithEvents Label17 As Label
    Friend WithEvents dtReportFrom As DateTimePicker
    Friend WithEvents dtReportTo As DateTimePicker
    Friend WithEvents Label18 As Label
End Class
