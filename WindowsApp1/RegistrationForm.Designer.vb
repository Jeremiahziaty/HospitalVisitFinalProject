<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Date_VisiedLabel As System.Windows.Forms.Label
        Dim LblSex As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim lblAdresse As System.Windows.Forms.Label
        Dim LblState As System.Windows.Forms.Label
        Dim LblZIp As System.Windows.Forms.Label
        Dim lblcity As System.Windows.Forms.Label
        Dim lblHistory As System.Windows.Forms.Label
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.dtpVisited = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.RadMale = New System.Windows.Forms.RadioButton()
        Me.RadFemale = New System.Windows.Forms.RadioButton()
        Me.dtpBirth = New System.Windows.Forms.DateTimePicker()
        Me.TxtAdress = New System.Windows.Forms.TextBox()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.TxtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtHistory = New System.Windows.Forms.TextBox()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Date_VisiedLabel = New System.Windows.Forms.Label()
        LblSex = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        lblAdresse = New System.Windows.Forms.Label()
        LblState = New System.Windows.Forms.Label()
        LblZIp = New System.Windows.Forms.Label()
        lblcity = New System.Windows.Forms.Label()
        lblHistory = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(19, 20)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 26
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(374, 20)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 28
        First_NameLabel.Text = "First Name:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(393, 104)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 30
        PhoneLabel.Text = "Phone:"
        '
        'Date_VisiedLabel
        '
        Date_VisiedLabel.AutoSize = True
        Date_VisiedLabel.Location = New System.Drawing.Point(374, 64)
        Date_VisiedLabel.Name = "Date_VisiedLabel"
        Date_VisiedLabel.Size = New System.Drawing.Size(67, 13)
        Date_VisiedLabel.TabIndex = 32
        Date_VisiedLabel.Text = "Date Visited:"
        '
        'LblSex
        '
        LblSex.AutoSize = True
        LblSex.Location = New System.Drawing.Point(48, 66)
        LblSex.Name = "LblSex"
        LblSex.Size = New System.Drawing.Size(28, 13)
        LblSex.TabIndex = 34
        LblSex.Text = "Sex:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(48, 105)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 13)
        Label1.TabIndex = 37
        Label1.Text = "Date Of Birth:"
        '
        'lblAdresse
        '
        lblAdresse.AutoSize = True
        lblAdresse.Location = New System.Drawing.Point(19, 154)
        lblAdresse.Name = "lblAdresse"
        lblAdresse.Size = New System.Drawing.Size(48, 13)
        lblAdresse.TabIndex = 39
        lblAdresse.Text = "Address:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.Location = New System.Drawing.Point(92, 16)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(143, 20)
        Me.Last_NameTextBox.TabIndex = 27
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.Location = New System.Drawing.Point(447, 16)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(143, 20)
        Me.First_NameTextBox.TabIndex = 29
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(496, 98)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(94, 20)
        Me.PhoneTextBox.TabIndex = 31
        '
        'dtpVisited
        '
        Me.dtpVisited.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVisited.Location = New System.Drawing.Point(511, 59)
        Me.dtpVisited.Name = "dtpVisited"
        Me.dtpVisited.Size = New System.Drawing.Size(79, 20)
        Me.dtpVisited.TabIndex = 33
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(249, 346)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(161, 23)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save and Continue"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'RadMale
        '
        Me.RadMale.AutoSize = True
        Me.RadMale.Location = New System.Drawing.Point(109, 64)
        Me.RadMale.Name = "RadMale"
        Me.RadMale.Size = New System.Drawing.Size(48, 17)
        Me.RadMale.TabIndex = 35
        Me.RadMale.TabStop = True
        Me.RadMale.Text = "Male"
        Me.RadMale.UseVisualStyleBackColor = True
        '
        'RadFemale
        '
        Me.RadFemale.AutoSize = True
        Me.RadFemale.Location = New System.Drawing.Point(176, 64)
        Me.RadFemale.Name = "RadFemale"
        Me.RadFemale.Size = New System.Drawing.Size(59, 17)
        Me.RadFemale.TabIndex = 36
        Me.RadFemale.TabStop = True
        Me.RadFemale.Text = "Female"
        Me.RadFemale.UseVisualStyleBackColor = True
        '
        'dtpBirth
        '
        Me.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirth.Location = New System.Drawing.Point(156, 98)
        Me.dtpBirth.Name = "dtpBirth"
        Me.dtpBirth.Size = New System.Drawing.Size(79, 20)
        Me.dtpBirth.TabIndex = 38
        '
        'TxtAdress
        '
        Me.TxtAdress.Location = New System.Drawing.Point(92, 150)
        Me.TxtAdress.Name = "TxtAdress"
        Me.TxtAdress.Size = New System.Drawing.Size(94, 20)
        Me.TxtAdress.TabIndex = 40
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(224, 150)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(94, 20)
        Me.TxtCity.TabIndex = 41
        '
        'LblState
        '
        LblState.AutoSize = True
        LblState.Location = New System.Drawing.Point(324, 154)
        LblState.Name = "LblState"
        LblState.Size = New System.Drawing.Size(35, 13)
        LblState.TabIndex = 43
        LblState.Text = "State:"
        '
        'TxtState
        '
        Me.TxtState.Location = New System.Drawing.Point(365, 150)
        Me.TxtState.Name = "TxtState"
        Me.TxtState.Size = New System.Drawing.Size(94, 20)
        Me.TxtState.TabIndex = 44
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(496, 150)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(94, 20)
        Me.txtZip.TabIndex = 45
        '
        'LblZIp
        '
        LblZIp.AutoSize = True
        LblZIp.Location = New System.Drawing.Point(465, 154)
        LblZIp.Name = "LblZIp"
        LblZIp.Size = New System.Drawing.Size(25, 13)
        LblZIp.TabIndex = 46
        LblZIp.Text = "Zip:"
        '
        'lblcity
        '
        lblcity.AutoSize = True
        lblcity.Location = New System.Drawing.Point(191, 154)
        lblcity.Name = "lblcity"
        lblcity.Size = New System.Drawing.Size(27, 13)
        lblcity.TabIndex = 42
        lblcity.Text = "City:"
        '
        'txtHistory
        '
        Me.txtHistory.Location = New System.Drawing.Point(121, 223)
        Me.txtHistory.Multiline = True
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.Size = New System.Drawing.Size(386, 104)
        Me.txtHistory.TabIndex = 47
        '
        'lblHistory
        '
        lblHistory.AutoSize = True
        lblHistory.Location = New System.Drawing.Point(48, 197)
        lblHistory.Name = "lblHistory"
        lblHistory.Size = New System.Drawing.Size(74, 13)
        lblHistory.TabIndex = 48
        lblHistory.Text = "Family History:"
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 396)
        Me.Controls.Add(lblHistory)
        Me.Controls.Add(Me.txtHistory)
        Me.Controls.Add(LblZIp)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.TxtState)
        Me.Controls.Add(LblState)
        Me.Controls.Add(lblcity)
        Me.Controls.Add(Me.TxtCity)
        Me.Controls.Add(lblAdresse)
        Me.Controls.Add(Me.TxtAdress)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.dtpBirth)
        Me.Controls.Add(Me.RadFemale)
        Me.Controls.Add(Me.RadMale)
        Me.Controls.Add(LblSex)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Date_VisiedLabel)
        Me.Controls.Add(Me.dtpVisited)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "RegistrationForm"
        Me.Text = "RegistrationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents dtpVisited As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents RadMale As RadioButton
    Friend WithEvents RadFemale As RadioButton
    Friend WithEvents dtpBirth As DateTimePicker
    Friend WithEvents TxtAdress As TextBox
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents TxtState As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtHistory As TextBox
End Class
