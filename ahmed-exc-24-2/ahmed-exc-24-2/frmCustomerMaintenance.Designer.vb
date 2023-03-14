<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerMaintenance
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
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Dim StateNameLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim Address1Label As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnGetCustomer = New System.Windows.Forms.Button()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        ZipCodeLabel = New System.Windows.Forms.Label()
        StateNameLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        Address1Label = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(341, 170)
        ZipCodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(67, 17)
        ZipCodeLabel.TabIndex = 28
        ZipCodeLabel.Text = "Zip code:"
        '
        'StateNameLabel
        '
        StateNameLabel.AutoSize = True
        StateNameLabel.Location = New System.Drawing.Point(27, 170)
        StateNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StateNameLabel.Name = "StateNameLabel"
        StateNameLabel.Size = New System.Drawing.Size(45, 17)
        StateNameLabel.TabIndex = 26
        StateNameLabel.Text = "State:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(27, 138)
        CityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(35, 17)
        CityLabel.TabIndex = 24
        CityLabel.Text = "City:"
        '
        'Address1Label
        '
        Address1Label.AutoSize = True
        Address1Label.Location = New System.Drawing.Point(27, 106)
        Address1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Address1Label.Name = "Address1Label"
        Address1Label.Size = New System.Drawing.Size(64, 17)
        Address1Label.TabIndex = 22
        Address1Label.Text = "Address:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(27, 74)
        NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 20
        NameLabel.Text = "Name:"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(249, 218)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 28)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(425, 218)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Enabled = False
        Me.btnModify.Location = New System.Drawing.Point(140, 219)
        Me.btnModify.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(100, 28)
        Me.btnModify.TabIndex = 31
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(31, 219)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 28)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnGetCustomer
        '
        Me.btnGetCustomer.Location = New System.Drawing.Point(200, 21)
        Me.btnGetCustomer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGetCustomer.Name = "btnGetCustomer"
        Me.btnGetCustomer.Size = New System.Drawing.Size(125, 28)
        Me.btnGetCustomer.TabIndex = 19
        Me.btnGetCustomer.Text = "Get Customer"
        Me.btnGetCustomer.UseVisualStyleBackColor = True
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(419, 166)
        Me.txtZipCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.ReadOnly = True
        Me.txtZipCode.Size = New System.Drawing.Size(105, 22)
        Me.txtZipCode.TabIndex = 29
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(125, 166)
        Me.txtState.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(199, 22)
        Me.txtState.TabIndex = 27
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(125, 134)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(399, 22)
        Me.txtCity.TabIndex = 25
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(125, 102)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(399, 22)
        Me.txtAddress.TabIndex = 23
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(125, 70)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(399, 22)
        Me.txtName.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Customer ID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(125, 23)
        Me.txtCustomerID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(65, 22)
        Me.txtCustomerID.TabIndex = 18
        Me.txtCustomerID.Tag = "Customer ID"
        '
        'frmCustomerMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(553, 268)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnGetCustomer)
        Me.Controls.Add(ZipCodeLabel)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(StateNameLabel)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Address1Label)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCustomerID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCustomerMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnGetCustomer As Button
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCustomerID As TextBox
End Class
