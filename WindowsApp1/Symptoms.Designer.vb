<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtPatientId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.gbSymptoms = New System.Windows.Forms.GroupBox()
        Me.chcksportphysical = New System.Windows.Forms.CheckBox()
        Me.chkcheckup = New System.Windows.Forms.CheckBox()
        Me.chkjointpain = New System.Windows.Forms.CheckBox()
        Me.chkMuscularPain = New System.Windows.Forms.CheckBox()
        Me.chkHeadach = New System.Windows.Forms.CheckBox()
        Me.chkRespiratory = New System.Windows.Forms.CheckBox()
        Me.chkSkin = New System.Windows.Forms.CheckBox()
        Me.chkUnary = New System.Windows.Forms.CheckBox()
        Me.chkSneezing = New System.Windows.Forms.CheckBox()
        Me.chkPregnancy = New System.Windows.Forms.CheckBox()
        Me.chkOther = New System.Windows.Forms.CheckBox()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.gbSymptoms.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPatientId
        '
        Me.txtPatientId.Enabled = False
        Me.txtPatientId.Location = New System.Drawing.Point(153, 38)
        Me.txtPatientId.Name = "txtPatientId"
        Me.txtPatientId.Size = New System.Drawing.Size(100, 20)
        Me.txtPatientId.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(113, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 20)
        Me.txtName.TabIndex = 1
        '
        'gbSymptoms
        '
        Me.gbSymptoms.Controls.Add(Me.txtOther)
        Me.gbSymptoms.Controls.Add(Me.chkOther)
        Me.gbSymptoms.Controls.Add(Me.chkPregnancy)
        Me.gbSymptoms.Controls.Add(Me.chkSneezing)
        Me.gbSymptoms.Controls.Add(Me.chkUnary)
        Me.gbSymptoms.Controls.Add(Me.chkSkin)
        Me.gbSymptoms.Controls.Add(Me.chkRespiratory)
        Me.gbSymptoms.Controls.Add(Me.chkHeadach)
        Me.gbSymptoms.Controls.Add(Me.chkMuscularPain)
        Me.gbSymptoms.Controls.Add(Me.chkjointpain)
        Me.gbSymptoms.Controls.Add(Me.chkcheckup)
        Me.gbSymptoms.Controls.Add(Me.chcksportphysical)
        Me.gbSymptoms.Location = New System.Drawing.Point(29, 92)
        Me.gbSymptoms.Name = "gbSymptoms"
        Me.gbSymptoms.Size = New System.Drawing.Size(358, 283)
        Me.gbSymptoms.TabIndex = 2
        Me.gbSymptoms.TabStop = False
        Me.gbSymptoms.Text = "Symptoms"
        '
        'chcksportphysical
        '
        Me.chcksportphysical.AutoSize = True
        Me.chcksportphysical.Location = New System.Drawing.Point(15, 28)
        Me.chcksportphysical.Name = "chcksportphysical"
        Me.chcksportphysical.Size = New System.Drawing.Size(93, 17)
        Me.chcksportphysical.TabIndex = 0
        Me.chcksportphysical.Text = "Sport Physical"
        Me.chcksportphysical.UseVisualStyleBackColor = True
        '
        'chkcheckup
        '
        Me.chkcheckup.AutoSize = True
        Me.chkcheckup.Location = New System.Drawing.Point(15, 59)
        Me.chkcheckup.Name = "chkcheckup"
        Me.chkcheckup.Size = New System.Drawing.Size(71, 17)
        Me.chkcheckup.TabIndex = 1
        Me.chkcheckup.Text = "check-up"
        Me.chkcheckup.UseVisualStyleBackColor = True
        '
        'chkjointpain
        '
        Me.chkjointpain.AutoSize = True
        Me.chkjointpain.Location = New System.Drawing.Point(15, 90)
        Me.chkjointpain.Name = "chkjointpain"
        Me.chkjointpain.Size = New System.Drawing.Size(72, 17)
        Me.chkjointpain.TabIndex = 2
        Me.chkjointpain.Text = "Joint Pain"
        Me.chkjointpain.UseVisualStyleBackColor = True
        '
        'chkMuscularPain
        '
        Me.chkMuscularPain.AutoSize = True
        Me.chkMuscularPain.Location = New System.Drawing.Point(15, 121)
        Me.chkMuscularPain.Name = "chkMuscularPain"
        Me.chkMuscularPain.Size = New System.Drawing.Size(93, 17)
        Me.chkMuscularPain.TabIndex = 3
        Me.chkMuscularPain.Text = "Muscular Pain"
        Me.chkMuscularPain.UseVisualStyleBackColor = True
        '
        'chkHeadach
        '
        Me.chkHeadach.AutoSize = True
        Me.chkHeadach.Location = New System.Drawing.Point(15, 152)
        Me.chkHeadach.Name = "chkHeadach"
        Me.chkHeadach.Size = New System.Drawing.Size(176, 17)
        Me.chkHeadach.TabIndex = 4
        Me.chkHeadach.Text = "Frequent Headaches/Migraines"
        Me.chkHeadach.UseVisualStyleBackColor = True
        '
        'chkRespiratory
        '
        Me.chkRespiratory.AutoSize = True
        Me.chkRespiratory.Location = New System.Drawing.Point(198, 28)
        Me.chkRespiratory.Name = "chkRespiratory"
        Me.chkRespiratory.Size = New System.Drawing.Size(112, 17)
        Me.chkRespiratory.TabIndex = 5
        Me.chkRespiratory.Text = "Respiratory Issues"
        Me.chkRespiratory.UseVisualStyleBackColor = True
        '
        'chkSkin
        '
        Me.chkSkin.AutoSize = True
        Me.chkSkin.Location = New System.Drawing.Point(198, 59)
        Me.chkSkin.Name = "chkSkin"
        Me.chkSkin.Size = New System.Drawing.Size(94, 17)
        Me.chkSkin.TabIndex = 6
        Me.chkSkin.Text = "Skin Condition"
        Me.chkSkin.UseVisualStyleBackColor = True
        '
        'chkUnary
        '
        Me.chkUnary.AutoSize = True
        Me.chkUnary.Location = New System.Drawing.Point(197, 90)
        Me.chkUnary.Name = "chkUnary"
        Me.chkUnary.Size = New System.Drawing.Size(155, 17)
        Me.chkUnary.TabIndex = 7
        Me.chkUnary.Text = "Bowl/Urinary Complications"
        Me.chkUnary.UseVisualStyleBackColor = True
        '
        'chkSneezing
        '
        Me.chkSneezing.AutoSize = True
        Me.chkSneezing.Location = New System.Drawing.Point(15, 184)
        Me.chkSneezing.Name = "chkSneezing"
        Me.chkSneezing.Size = New System.Drawing.Size(120, 17)
        Me.chkSneezing.TabIndex = 8
        Me.chkSneezing.Text = "Sneezing/Coughing"
        Me.chkSneezing.UseVisualStyleBackColor = True
        '
        'chkPregnancy
        '
        Me.chkPregnancy.AutoSize = True
        Me.chkPregnancy.Location = New System.Drawing.Point(197, 121)
        Me.chkPregnancy.Name = "chkPregnancy"
        Me.chkPregnancy.Size = New System.Drawing.Size(80, 17)
        Me.chkPregnancy.TabIndex = 9
        Me.chkPregnancy.Text = "Pregnancy "
        Me.chkPregnancy.UseVisualStyleBackColor = True
        '
        'chkOther
        '
        Me.chkOther.AutoSize = True
        Me.chkOther.Location = New System.Drawing.Point(197, 144)
        Me.chkOther.Name = "chkOther"
        Me.chkOther.Size = New System.Drawing.Size(52, 17)
        Me.chkOther.TabIndex = 10
        Me.chkOther.Text = "Other"
        Me.chkOther.UseVisualStyleBackColor = True
        '
        'txtOther
        '
        Me.txtOther.Enabled = False
        Me.txtOther.Location = New System.Drawing.Point(197, 167)
        Me.txtOther.Multiline = True
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(135, 92)
        Me.txtOther.TabIndex = 48
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 387)
        Me.Controls.Add(Me.gbSymptoms)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPatientId)
        Me.Name = "Form1"
        Me.Text = "..Continue"
        Me.gbSymptoms.ResumeLayout(False)
        Me.gbSymptoms.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPatientId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents gbSymptoms As GroupBox
    Friend WithEvents chkOther As CheckBox
    Friend WithEvents chkPregnancy As CheckBox
    Friend WithEvents chkSneezing As CheckBox
    Friend WithEvents chkUnary As CheckBox
    Friend WithEvents chkSkin As CheckBox
    Friend WithEvents chkRespiratory As CheckBox
    Friend WithEvents chkHeadach As CheckBox
    Friend WithEvents chkMuscularPain As CheckBox
    Friend WithEvents chkjointpain As CheckBox
    Friend WithEvents chkcheckup As CheckBox
    Friend WithEvents chcksportphysical As CheckBox
    Friend WithEvents txtOther As TextBox
End Class
