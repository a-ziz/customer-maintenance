<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModifyCustomer
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.cboStates = New System.Windows.Forms.ComboBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        ZipCodeLabel = New System.Windows.Forms.Label()
        StateNameLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        Address1Label = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(317, 149)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(22, 150)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 22
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'cboStates
        '
        Me.cboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStates.FormattingEnabled = True
        Me.cboStates.Location = New System.Drawing.Point(93, 96)
        Me.cboStates.Name = "cboStates"
        Me.cboStates.Size = New System.Drawing.Size(150, 21)
        Me.cboStates.TabIndex = 19
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(255, 98)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(52, 13)
        ZipCodeLabel.TabIndex = 20
        ZipCodeLabel.Text = "Zip code:"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(313, 95)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(80, 20)
        Me.txtZipCode.TabIndex = 21
        '
        'StateNameLabel
        '
        StateNameLabel.AutoSize = True
        StateNameLabel.Location = New System.Drawing.Point(19, 98)
        StateNameLabel.Name = "StateNameLabel"
        StateNameLabel.Size = New System.Drawing.Size(35, 13)
        StateNameLabel.TabIndex = 18
        StateNameLabel.Text = "State:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(19, 72)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 16
        CityLabel.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(93, 69)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(300, 20)
        Me.txtCity.TabIndex = 17
        '
        'Address1Label
        '
        Address1Label.AutoSize = True
        Address1Label.Location = New System.Drawing.Point(19, 46)
        Address1Label.Name = "Address1Label"
        Address1Label.Size = New System.Drawing.Size(48, 13)
        Address1Label.TabIndex = 14
        Address1Label.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(93, 43)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(300, 20)
        Me.txtAddress.TabIndex = 15
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(19, 20)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 12
        NameLabel.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(93, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(300, 20)
        Me.txtName.TabIndex = 13
        '
        'frmAddModifyCustomer
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(412, 190)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.cboStates)
        Me.Controls.Add(ZipCodeLabel)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(StateNameLabel)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Address1Label)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAddModifyCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnCancel As Button
    Private WithEvents btnAccept As Button
    Private WithEvents cboStates As ComboBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
End Class
