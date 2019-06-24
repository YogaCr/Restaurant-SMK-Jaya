<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnMember = New System.Windows.Forms.Button()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.panelEmployee = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgEmployee = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbEmployeeCari = New System.Windows.Forms.TextBox()
        Me.btnEmployeeDelete = New System.Windows.Forms.Button()
        Me.btnEmployeeEdit = New System.Windows.Forms.Button()
        Me.btnEmployeeAdd = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnMenuAdd = New System.Windows.Forms.Button()
        Me.btnMenuEdit = New System.Windows.Forms.Button()
        Me.btnMenuDelete = New System.Windows.Forms.Button()
        Me.tbMenuCari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgMenu = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbMenu = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.panelMember = New System.Windows.Forms.Panel()
        Me.btnMemberAdd = New System.Windows.Forms.Button()
        Me.btnMemberEdit = New System.Windows.Forms.Button()
        Me.btnMemberDelete = New System.Windows.Forms.Button()
        Me.tbMemberCari = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgMember = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelEmployee.SuspendLayout()
        CType(Me.dgEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        CType(Me.dgMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMember.SuspendLayout()
        CType(Me.dgMember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 0
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.btnPassword)
        Me.Panel2.Controls.Add(Me.btnMember)
        Me.Panel2.Controls.Add(Me.btnMenu)
        Me.Panel2.Controls.Add(Me.btnEmployee)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 48)
        Me.Panel2.TabIndex = 1
        '
        'btnEmployee
        '
        Me.btnEmployee.BackColor = System.Drawing.SystemColors.Control
        Me.btnEmployee.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEmployee.FlatAppearance.BorderSize = 0
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployee.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.ForeColor = System.Drawing.Color.Black
        Me.btnEmployee.Location = New System.Drawing.Point(0, 0)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(129, 48)
        Me.btnEmployee.TabIndex = 0
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(129, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(130, 48)
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnMember
        '
        Me.btnMember.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMember.FlatAppearance.BorderSize = 0
        Me.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMember.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMember.ForeColor = System.Drawing.Color.White
        Me.btnMember.Location = New System.Drawing.Point(259, 0)
        Me.btnMember.Name = "btnMember"
        Me.btnMember.Size = New System.Drawing.Size(125, 48)
        Me.btnMember.TabIndex = 2
        Me.btnMember.Text = "Member"
        Me.btnMember.UseVisualStyleBackColor = True
        '
        'btnPassword
        '
        Me.btnPassword.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPassword.FlatAppearance.BorderSize = 0
        Me.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.White
        Me.btnPassword.Location = New System.Drawing.Point(384, 0)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(115, 48)
        Me.btnPassword.TabIndex = 3
        Me.btnPassword.Text = "Password"
        Me.btnPassword.UseVisualStyleBackColor = True
        '
        'panelEmployee
        '
        Me.panelEmployee.Controls.Add(Me.btnEmployeeAdd)
        Me.panelEmployee.Controls.Add(Me.btnEmployeeEdit)
        Me.panelEmployee.Controls.Add(Me.btnEmployeeDelete)
        Me.panelEmployee.Controls.Add(Me.tbEmployeeCari)
        Me.panelEmployee.Controls.Add(Me.Label5)
        Me.panelEmployee.Controls.Add(Me.dgEmployee)
        Me.panelEmployee.Controls.Add(Me.Label4)
        Me.panelEmployee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEmployee.Location = New System.Drawing.Point(0, 159)
        Me.panelEmployee.Name = "panelEmployee"
        Me.panelEmployee.Size = New System.Drawing.Size(800, 441)
        Me.panelEmployee.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(320, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 45)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Employee"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dgEmployee
        '
        Me.dgEmployee.AllowUserToAddRows = False
        Me.dgEmployee.AllowUserToDeleteRows = False
        Me.dgEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgEmployee.Location = New System.Drawing.Point(89, 97)
        Me.dgEmployee.Name = "dgEmployee"
        Me.dgEmployee.ReadOnly = True
        Me.dgEmployee.Size = New System.Drawing.Size(640, 293)
        Me.dgEmployee.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.DataPropertyName = "EmployeeID"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 43
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DataPropertyName = "Name"
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DataPropertyName = "Email"
        Me.Column3.HeaderText = "Email"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.DataPropertyName = "Handphone"
        Me.Column4.HeaderText = "Handphone"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 88
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.DataPropertyName = "Position"
        Me.Column5.HeaderText = "Position"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(84, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cari"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbEmployeeCari
        '
        Me.tbEmployeeCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbEmployeeCari.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmployeeCari.Location = New System.Drawing.Point(150, 65)
        Me.tbEmployeeCari.Name = "tbEmployeeCari"
        Me.tbEmployeeCari.Size = New System.Drawing.Size(579, 29)
        Me.tbEmployeeCari.TabIndex = 7
        '
        'btnEmployeeDelete
        '
        Me.btnEmployeeDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEmployeeDelete.BackColor = System.Drawing.Color.Red
        Me.btnEmployeeDelete.FlatAppearance.BorderSize = 0
        Me.btnEmployeeDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployeeDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeDelete.ForeColor = System.Drawing.Color.White
        Me.btnEmployeeDelete.Location = New System.Drawing.Point(667, 396)
        Me.btnEmployeeDelete.Name = "btnEmployeeDelete"
        Me.btnEmployeeDelete.Size = New System.Drawing.Size(62, 33)
        Me.btnEmployeeDelete.TabIndex = 8
        Me.btnEmployeeDelete.Text = "Delete"
        Me.btnEmployeeDelete.UseVisualStyleBackColor = False
        '
        'btnEmployeeEdit
        '
        Me.btnEmployeeEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEmployeeEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEmployeeEdit.FlatAppearance.BorderSize = 0
        Me.btnEmployeeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployeeEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeEdit.ForeColor = System.Drawing.Color.White
        Me.btnEmployeeEdit.Location = New System.Drawing.Point(599, 396)
        Me.btnEmployeeEdit.Name = "btnEmployeeEdit"
        Me.btnEmployeeEdit.Size = New System.Drawing.Size(62, 33)
        Me.btnEmployeeEdit.TabIndex = 9
        Me.btnEmployeeEdit.Text = "Edit"
        Me.btnEmployeeEdit.UseVisualStyleBackColor = False
        '
        'btnEmployeeAdd
        '
        Me.btnEmployeeAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEmployeeAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEmployeeAdd.FlatAppearance.BorderSize = 0
        Me.btnEmployeeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployeeAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeAdd.ForeColor = System.Drawing.Color.White
        Me.btnEmployeeAdd.Location = New System.Drawing.Point(531, 396)
        Me.btnEmployeeAdd.Name = "btnEmployeeAdd"
        Me.btnEmployeeAdd.Size = New System.Drawing.Size(62, 33)
        Me.btnEmployeeAdd.TabIndex = 10
        Me.btnEmployeeAdd.Text = "Add"
        Me.btnEmployeeAdd.UseVisualStyleBackColor = False
        '
        'panelMenu
        '
        Me.panelMenu.Controls.Add(Me.Label8)
        Me.panelMenu.Controls.Add(Me.pbMenu)
        Me.panelMenu.Controls.Add(Me.btnMenuAdd)
        Me.panelMenu.Controls.Add(Me.btnMenuEdit)
        Me.panelMenu.Controls.Add(Me.btnMenuDelete)
        Me.panelMenu.Controls.Add(Me.tbMenuCari)
        Me.panelMenu.Controls.Add(Me.Label6)
        Me.panelMenu.Controls.Add(Me.dgMenu)
        Me.panelMenu.Controls.Add(Me.Label7)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(800, 600)
        Me.panelMenu.TabIndex = 11
        '
        'btnMenuAdd
        '
        Me.btnMenuAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMenuAdd.FlatAppearance.BorderSize = 0
        Me.btnMenuAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuAdd.ForeColor = System.Drawing.Color.White
        Me.btnMenuAdd.Location = New System.Drawing.Point(531, 555)
        Me.btnMenuAdd.Name = "btnMenuAdd"
        Me.btnMenuAdd.Size = New System.Drawing.Size(62, 33)
        Me.btnMenuAdd.TabIndex = 10
        Me.btnMenuAdd.Text = "Add"
        Me.btnMenuAdd.UseVisualStyleBackColor = False
        '
        'btnMenuEdit
        '
        Me.btnMenuEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMenuEdit.FlatAppearance.BorderSize = 0
        Me.btnMenuEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuEdit.ForeColor = System.Drawing.Color.White
        Me.btnMenuEdit.Location = New System.Drawing.Point(599, 555)
        Me.btnMenuEdit.Name = "btnMenuEdit"
        Me.btnMenuEdit.Size = New System.Drawing.Size(62, 33)
        Me.btnMenuEdit.TabIndex = 9
        Me.btnMenuEdit.Text = "Edit"
        Me.btnMenuEdit.UseVisualStyleBackColor = False
        '
        'btnMenuDelete
        '
        Me.btnMenuDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenuDelete.BackColor = System.Drawing.Color.Red
        Me.btnMenuDelete.FlatAppearance.BorderSize = 0
        Me.btnMenuDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuDelete.ForeColor = System.Drawing.Color.White
        Me.btnMenuDelete.Location = New System.Drawing.Point(667, 555)
        Me.btnMenuDelete.Name = "btnMenuDelete"
        Me.btnMenuDelete.Size = New System.Drawing.Size(62, 33)
        Me.btnMenuDelete.TabIndex = 8
        Me.btnMenuDelete.Text = "Delete"
        Me.btnMenuDelete.UseVisualStyleBackColor = False
        '
        'tbMenuCari
        '
        Me.tbMenuCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMenuCari.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMenuCari.Location = New System.Drawing.Point(150, 65)
        Me.tbMenuCari.Name = "tbMenuCari"
        Me.tbMenuCari.Size = New System.Drawing.Size(579, 29)
        Me.tbMenuCari.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(84, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Cari"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dgMenu
        '
        Me.dgMenu.AllowUserToAddRows = False
        Me.dgMenu.AllowUserToDeleteRows = False
        Me.dgMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgMenu.Location = New System.Drawing.Point(89, 97)
        Me.dgMenu.Name = "dgMenu"
        Me.dgMenu.ReadOnly = True
        Me.dgMenu.Size = New System.Drawing.Size(504, 452)
        Me.dgMenu.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(363, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 45)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Menu"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'pbMenu
        '
        Me.pbMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMenu.Location = New System.Drawing.Point(599, 125)
        Me.pbMenu.Name = "pbMenu"
        Me.pbMenu.Size = New System.Drawing.Size(130, 142)
        Me.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMenu.TabIndex = 11
        Me.pbMenu.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(599, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Photo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'panelMember
        '
        Me.panelMember.Controls.Add(Me.btnMemberAdd)
        Me.panelMember.Controls.Add(Me.btnMemberEdit)
        Me.panelMember.Controls.Add(Me.btnMemberDelete)
        Me.panelMember.Controls.Add(Me.tbMemberCari)
        Me.panelMember.Controls.Add(Me.Label3)
        Me.panelMember.Controls.Add(Me.dgMember)
        Me.panelMember.Controls.Add(Me.Label9)
        Me.panelMember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMember.Location = New System.Drawing.Point(0, 0)
        Me.panelMember.Name = "panelMember"
        Me.panelMember.Size = New System.Drawing.Size(800, 600)
        Me.panelMember.TabIndex = 12
        '
        'btnMemberAdd
        '
        Me.btnMemberAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMemberAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMemberAdd.FlatAppearance.BorderSize = 0
        Me.btnMemberAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMemberAdd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberAdd.ForeColor = System.Drawing.Color.White
        Me.btnMemberAdd.Location = New System.Drawing.Point(531, 555)
        Me.btnMemberAdd.Name = "btnMemberAdd"
        Me.btnMemberAdd.Size = New System.Drawing.Size(62, 33)
        Me.btnMemberAdd.TabIndex = 10
        Me.btnMemberAdd.Text = "Add"
        Me.btnMemberAdd.UseVisualStyleBackColor = False
        '
        'btnMemberEdit
        '
        Me.btnMemberEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMemberEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMemberEdit.FlatAppearance.BorderSize = 0
        Me.btnMemberEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMemberEdit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberEdit.ForeColor = System.Drawing.Color.White
        Me.btnMemberEdit.Location = New System.Drawing.Point(599, 555)
        Me.btnMemberEdit.Name = "btnMemberEdit"
        Me.btnMemberEdit.Size = New System.Drawing.Size(62, 33)
        Me.btnMemberEdit.TabIndex = 9
        Me.btnMemberEdit.Text = "Edit"
        Me.btnMemberEdit.UseVisualStyleBackColor = False
        '
        'btnMemberDelete
        '
        Me.btnMemberDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMemberDelete.BackColor = System.Drawing.Color.Red
        Me.btnMemberDelete.FlatAppearance.BorderSize = 0
        Me.btnMemberDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMemberDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemberDelete.ForeColor = System.Drawing.Color.White
        Me.btnMemberDelete.Location = New System.Drawing.Point(667, 555)
        Me.btnMemberDelete.Name = "btnMemberDelete"
        Me.btnMemberDelete.Size = New System.Drawing.Size(62, 33)
        Me.btnMemberDelete.TabIndex = 8
        Me.btnMemberDelete.Text = "Delete"
        Me.btnMemberDelete.UseVisualStyleBackColor = False
        '
        'tbMemberCari
        '
        Me.tbMemberCari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMemberCari.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMemberCari.Location = New System.Drawing.Point(150, 65)
        Me.tbMemberCari.Name = "tbMemberCari"
        Me.tbMemberCari.Size = New System.Drawing.Size(579, 29)
        Me.tbMemberCari.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(84, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cari"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dgMember
        '
        Me.dgMember.AllowUserToAddRows = False
        Me.dgMember.AllowUserToDeleteRows = False
        Me.dgMember.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMember.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgMember.Location = New System.Drawing.Point(89, 97)
        Me.dgMember.Name = "dgMember"
        Me.dgMember.ReadOnly = True
        Me.dgMember.Size = New System.Drawing.Size(640, 452)
        Me.dgMember.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(339, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 45)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Member"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MemberId"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 43
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "JoinDate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Join Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 77
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.panelEmployee)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelMember)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.panelEmployee.ResumeLayout(False)
        Me.panelEmployee.PerformLayout()
        CType(Me.dgEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.dgMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMember.ResumeLayout(False)
        Me.panelMember.PerformLayout()
        CType(Me.dgMember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPassword As Button
    Friend WithEvents btnMember As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents panelEmployee As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents dgEmployee As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents tbEmployeeCari As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEmployeeEdit As Button
    Friend WithEvents btnEmployeeDelete As Button
    Friend WithEvents btnEmployeeAdd As Button
    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnMenuAdd As Button
    Friend WithEvents btnMenuEdit As Button
    Friend WithEvents btnMenuDelete As Button
    Friend WithEvents tbMenuCari As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgMenu As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents pbMenu As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents panelMember As Panel
    Friend WithEvents btnMemberAdd As Button
    Friend WithEvents btnMemberEdit As Button
    Friend WithEvents btnMemberDelete As Button
    Friend WithEvents tbMemberCari As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgMember As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
End Class
