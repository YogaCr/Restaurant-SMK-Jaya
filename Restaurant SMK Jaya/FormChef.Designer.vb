<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChef
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPassword = New System.Windows.Forms.Button()
        Me.btnViewOrder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelAddOrder = New System.Windows.Forms.Panel()
        Me.dgAddOrderList = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbMenu = New System.Windows.Forms.PictureBox()
        Me.cbOrderId = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelAddOrder.SuspendLayout()
        CType(Me.dgAddOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(321, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 45)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "View Order"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.btnPassword)
        Me.Panel2.Controls.Add(Me.btnViewOrder)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 48)
        Me.Panel2.TabIndex = 28
        '
        'btnPassword
        '
        Me.btnPassword.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPassword.FlatAppearance.BorderSize = 0
        Me.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.White
        Me.btnPassword.Location = New System.Drawing.Point(129, 0)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(115, 48)
        Me.btnPassword.TabIndex = 3
        Me.btnPassword.Text = "Password"
        Me.btnPassword.UseVisualStyleBackColor = True
        '
        'btnViewOrder
        '
        Me.btnViewOrder.BackColor = System.Drawing.SystemColors.Control
        Me.btnViewOrder.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnViewOrder.FlatAppearance.BorderSize = 0
        Me.btnViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewOrder.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewOrder.ForeColor = System.Drawing.Color.Black
        Me.btnViewOrder.Location = New System.Drawing.Point(0, 0)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.Size = New System.Drawing.Size(129, 48)
        Me.btnViewOrder.TabIndex = 0
        Me.btnViewOrder.Text = "View Order"
        Me.btnViewOrder.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 27
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
        Me.panelAddOrder.Controls.Add(Me.cbOrderId)
        Me.panelAddOrder.Controls.Add(Me.Label6)
        Me.panelAddOrder.Controls.Add(Me.dgAddOrderList)
        Me.panelAddOrder.Controls.Add(Me.Label8)
        Me.panelAddOrder.Controls.Add(Me.pbMenu)
        Me.panelAddOrder.Controls.Add(Me.Label4)
        Me.panelAddOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelAddOrder.Location = New System.Drawing.Point(0, 159)
        Me.panelAddOrder.Name = "panelAddOrder"
        Me.panelAddOrder.Size = New System.Drawing.Size(800, 441)
        Me.panelAddOrder.TabIndex = 29
        '
        'dgAddOrderList
        '
        Me.dgAddOrderList.AllowUserToAddRows = False
        Me.dgAddOrderList.AllowUserToDeleteRows = False
        Me.dgAddOrderList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAddOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAddOrderList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.Column1, Me.Column2})
        Me.dgAddOrderList.Location = New System.Drawing.Point(89, 86)
        Me.dgAddOrderList.Name = "dgAddOrderList"
        Me.dgAddOrderList.ReadOnly = True
        Me.dgAddOrderList.Size = New System.Drawing.Size(504, 332)
        Me.dgAddOrderList.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(599, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Photo"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pbMenu
        '
        Me.pbMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMenu.Location = New System.Drawing.Point(599, 119)
        Me.pbMenu.Name = "pbMenu"
        Me.pbMenu.Size = New System.Drawing.Size(132, 159)
        Me.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMenu.TabIndex = 16
        Me.pbMenu.TabStop = False
        '
        'cbOrderId
        '
        Me.cbOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrderId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrderId.FormattingEnabled = True
        Me.cbOrderId.Location = New System.Drawing.Point(155, 58)
        Me.cbOrderId.Name = "cbOrderId"
        Me.cbOrderId.Size = New System.Drawing.Size(221, 25)
        Me.cbOrderId.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Order ID"
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
        'Column2
        '
        Me.Column2.DataPropertyName = "Status"
        Me.Column2.HeaderText = "Status"
        Me.Column2.Items.AddRange(New Object() {"Pending", "Cooking", "Deliver", "Delivered"})
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'FormChef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.panelAddOrder)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormChef"
        Me.Text = "FormChef"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelAddOrder.ResumeLayout(False)
        Me.panelAddOrder.PerformLayout()
        CType(Me.dgAddOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPassword As Button
    Friend WithEvents btnViewOrder As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents panelAddOrder As Panel
    Friend WithEvents dgAddOrderList As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents pbMenu As PictureBox
    Friend WithEvents cbOrderId As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewComboBoxColumn
End Class
