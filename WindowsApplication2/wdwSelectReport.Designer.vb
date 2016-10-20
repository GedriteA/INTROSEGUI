<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wdwSelectReport
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
        Me.rbttnUnder = New System.Windows.Forms.RadioButton()
        Me.rbttnGrad = New System.Windows.Forms.RadioButton()
        Me.rbttnBoth = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chckAllColl2 = New System.Windows.Forms.CheckBox()
        Me.chckAllColeg1 = New System.Windows.Forms.CheckBox()
        Me.cmbChair = New System.Windows.Forms.ComboBox()
        Me.rbttnDeptChair = New System.Windows.Forms.RadioButton()
        Me.cmbDean = New System.Windows.Forms.ComboBox()
        Me.rbttnCollDean = New System.Windows.Forms.RadioButton()
        Me.rbttnVPA = New System.Windows.Forms.RadioButton()
        Me.rbttnEVP = New System.Windows.Forms.RadioButton()
        Me.rbttnRegistrar = New System.Windows.Forms.RadioButton()
        Me.rbttnTermEnd = New System.Windows.Forms.RadioButton()
        Me.rbttnMonthly = New System.Windows.Forms.RadioButton()
        Me.rbttnDaily = New System.Windows.Forms.RadioButton()
        Me.bttnGen = New System.Windows.Forms.Button()
        Me.bttnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbttnUnder
        '
        Me.rbttnUnder.AutoSize = True
        Me.rbttnUnder.Checked = True
        Me.rbttnUnder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnUnder.Location = New System.Drawing.Point(6, 19)
        Me.rbttnUnder.Name = "rbttnUnder"
        Me.rbttnUnder.Size = New System.Drawing.Size(96, 17)
        Me.rbttnUnder.TabIndex = 0
        Me.rbttnUnder.TabStop = True
        Me.rbttnUnder.Text = "Undergraduate"
        Me.rbttnUnder.UseVisualStyleBackColor = True
        '
        'rbttnGrad
        '
        Me.rbttnGrad.AutoSize = True
        Me.rbttnGrad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnGrad.Location = New System.Drawing.Point(6, 42)
        Me.rbttnGrad.Name = "rbttnGrad"
        Me.rbttnGrad.Size = New System.Drawing.Size(69, 17)
        Me.rbttnGrad.TabIndex = 1
        Me.rbttnGrad.TabStop = True
        Me.rbttnGrad.Text = "Graduate"
        Me.rbttnGrad.UseVisualStyleBackColor = True
        '
        'rbttnBoth
        '
        Me.rbttnBoth.AutoSize = True
        Me.rbttnBoth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnBoth.Location = New System.Drawing.Point(6, 65)
        Me.rbttnBoth.Name = "rbttnBoth"
        Me.rbttnBoth.Size = New System.Drawing.Size(47, 17)
        Me.rbttnBoth.TabIndex = 2
        Me.rbttnBoth.TabStop = True
        Me.rbttnBoth.Text = "Both"
        Me.rbttnBoth.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbttnUnder)
        Me.GroupBox1.Controls.Add(Me.rbttnBoth)
        Me.GroupBox1.Controls.Add(Me.rbttnGrad)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(103, 90)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report for"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.rbttnTermEnd)
        Me.GroupBox2.Controls.Add(Me.rbttnMonthly)
        Me.GroupBox2.Controls.Add(Me.rbttnDaily)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(482, 270)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Type of Report"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chckAllColl2)
        Me.GroupBox3.Controls.Add(Me.chckAllColeg1)
        Me.GroupBox3.Controls.Add(Me.cmbChair)
        Me.GroupBox3.Controls.Add(Me.rbttnDeptChair)
        Me.GroupBox3.Controls.Add(Me.cmbDean)
        Me.GroupBox3.Controls.Add(Me.rbttnCollDean)
        Me.GroupBox3.Controls.Add(Me.rbttnVPA)
        Me.GroupBox3.Controls.Add(Me.rbttnEVP)
        Me.GroupBox3.Controls.Add(Me.rbttnRegistrar)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 49)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 212)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'chckAllColl2
        '
        Me.chckAllColl2.AutoSize = True
        Me.chckAllColl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckAllColl2.Location = New System.Drawing.Point(122, 108)
        Me.chckAllColl2.Name = "chckAllColl2"
        Me.chckAllColl2.Size = New System.Drawing.Size(80, 17)
        Me.chckAllColl2.TabIndex = 15
        Me.chckAllColl2.Text = "All Colleges"
        Me.chckAllColl2.UseVisualStyleBackColor = True
        '
        'chckAllColeg1
        '
        Me.chckAllColeg1.AutoSize = True
        Me.chckAllColeg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckAllColeg1.Location = New System.Drawing.Point(122, 154)
        Me.chckAllColeg1.Name = "chckAllColeg1"
        Me.chckAllColeg1.Size = New System.Drawing.Size(80, 17)
        Me.chckAllColeg1.TabIndex = 14
        Me.chckAllColeg1.Text = "All Colleges"
        Me.chckAllColeg1.UseVisualStyleBackColor = True
        '
        'cmbChair
        '
        Me.cmbChair.FormattingEnabled = True
        Me.cmbChair.Location = New System.Drawing.Point(122, 127)
        Me.cmbChair.Name = "cmbChair"
        Me.cmbChair.Size = New System.Drawing.Size(307, 21)
        Me.cmbChair.TabIndex = 13
        '
        'rbttnDeptChair
        '
        Me.rbttnDeptChair.AutoSize = True
        Me.rbttnDeptChair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnDeptChair.Location = New System.Drawing.Point(12, 131)
        Me.rbttnDeptChair.Name = "rbttnDeptChair"
        Me.rbttnDeptChair.Size = New System.Drawing.Size(107, 17)
        Me.rbttnDeptChair.TabIndex = 12
        Me.rbttnDeptChair.TabStop = True
        Me.rbttnDeptChair.Text = "Department Chair"
        Me.rbttnDeptChair.UseVisualStyleBackColor = True
        '
        'cmbDean
        '
        Me.cmbDean.FormattingEnabled = True
        Me.cmbDean.Location = New System.Drawing.Point(122, 81)
        Me.cmbDean.Name = "cmbDean"
        Me.cmbDean.Size = New System.Drawing.Size(307, 21)
        Me.cmbDean.TabIndex = 11
        '
        'rbttnCollDean
        '
        Me.rbttnCollDean.AutoSize = True
        Me.rbttnCollDean.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnCollDean.Location = New System.Drawing.Point(12, 81)
        Me.rbttnCollDean.Name = "rbttnCollDean"
        Me.rbttnCollDean.Size = New System.Drawing.Size(89, 17)
        Me.rbttnCollDean.TabIndex = 10
        Me.rbttnCollDean.TabStop = True
        Me.rbttnCollDean.Text = "College Dean"
        Me.rbttnCollDean.UseVisualStyleBackColor = True
        '
        'rbttnVPA
        '
        Me.rbttnVPA.AutoSize = True
        Me.rbttnVPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnVPA.Location = New System.Drawing.Point(12, 56)
        Me.rbttnVPA.Name = "rbttnVPA"
        Me.rbttnVPA.Size = New System.Drawing.Size(46, 17)
        Me.rbttnVPA.TabIndex = 9
        Me.rbttnVPA.TabStop = True
        Me.rbttnVPA.Text = "VPA"
        Me.rbttnVPA.UseVisualStyleBackColor = True
        '
        'rbttnEVP
        '
        Me.rbttnEVP.AutoSize = True
        Me.rbttnEVP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnEVP.Location = New System.Drawing.Point(12, 33)
        Me.rbttnEVP.Name = "rbttnEVP"
        Me.rbttnEVP.Size = New System.Drawing.Size(46, 17)
        Me.rbttnEVP.TabIndex = 8
        Me.rbttnEVP.TabStop = True
        Me.rbttnEVP.Text = "EVP"
        Me.rbttnEVP.UseVisualStyleBackColor = True
        '
        'rbttnRegistrar
        '
        Me.rbttnRegistrar.AutoSize = True
        Me.rbttnRegistrar.Checked = True
        Me.rbttnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnRegistrar.Location = New System.Drawing.Point(12, 10)
        Me.rbttnRegistrar.Name = "rbttnRegistrar"
        Me.rbttnRegistrar.Size = New System.Drawing.Size(67, 17)
        Me.rbttnRegistrar.TabIndex = 7
        Me.rbttnRegistrar.TabStop = True
        Me.rbttnRegistrar.Text = "Registrar"
        Me.rbttnRegistrar.UseVisualStyleBackColor = True
        '
        'rbttnTermEnd
        '
        Me.rbttnTermEnd.AutoSize = True
        Me.rbttnTermEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnTermEnd.Location = New System.Drawing.Point(128, 19)
        Me.rbttnTermEnd.Name = "rbttnTermEnd"
        Me.rbttnTermEnd.Size = New System.Drawing.Size(71, 17)
        Me.rbttnTermEnd.TabIndex = 5
        Me.rbttnTermEnd.TabStop = True
        Me.rbttnTermEnd.Text = "Term-End"
        Me.rbttnTermEnd.UseVisualStyleBackColor = True
        '
        'rbttnMonthly
        '
        Me.rbttnMonthly.AutoSize = True
        Me.rbttnMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnMonthly.Location = New System.Drawing.Point(60, 19)
        Me.rbttnMonthly.Name = "rbttnMonthly"
        Me.rbttnMonthly.Size = New System.Drawing.Size(62, 17)
        Me.rbttnMonthly.TabIndex = 4
        Me.rbttnMonthly.TabStop = True
        Me.rbttnMonthly.Text = "Monthly"
        Me.rbttnMonthly.UseVisualStyleBackColor = True
        '
        'rbttnDaily
        '
        Me.rbttnDaily.AutoSize = True
        Me.rbttnDaily.Checked = True
        Me.rbttnDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbttnDaily.Location = New System.Drawing.Point(6, 19)
        Me.rbttnDaily.Name = "rbttnDaily"
        Me.rbttnDaily.Size = New System.Drawing.Size(48, 17)
        Me.rbttnDaily.TabIndex = 3
        Me.rbttnDaily.TabStop = True
        Me.rbttnDaily.Text = "Daily"
        Me.rbttnDaily.UseVisualStyleBackColor = True
        '
        'bttnGen
        '
        Me.bttnGen.Location = New System.Drawing.Point(115, 384)
        Me.bttnGen.Name = "bttnGen"
        Me.bttnGen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bttnGen.Size = New System.Drawing.Size(90, 75)
        Me.bttnGen.TabIndex = 5
        Me.bttnGen.Text = "Generate"
        Me.bttnGen.UseVisualStyleBackColor = True
        '
        'bttnBack
        '
        Me.bttnBack.Location = New System.Drawing.Point(267, 384)
        Me.bttnBack.Name = "bttnBack"
        Me.bttnBack.Size = New System.Drawing.Size(90, 75)
        Me.bttnBack.TabIndex = 6
        Me.bttnBack.Text = "Back to Menu"
        Me.bttnBack.UseVisualStyleBackColor = True
        '
        'wdwSelectReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 488)
        Me.Controls.Add(Me.bttnBack)
        Me.Controls.Add(Me.bttnGen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "wdwSelectReport"
        Me.Text = "Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rbttnUnder As RadioButton
    Friend WithEvents rbttnGrad As RadioButton
    Friend WithEvents rbttnBoth As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbDean As ComboBox
    Friend WithEvents rbttnCollDean As RadioButton
    Friend WithEvents rbttnVPA As RadioButton
    Friend WithEvents rbttnEVP As RadioButton
    Friend WithEvents rbttnRegistrar As RadioButton
    Friend WithEvents rbttnTermEnd As RadioButton
    Friend WithEvents rbttnMonthly As RadioButton
    Friend WithEvents rbttnDaily As RadioButton
    Friend WithEvents cmbChair As ComboBox
    Friend WithEvents rbttnDeptChair As RadioButton
    Friend WithEvents chckAllColl2 As CheckBox
    Friend WithEvents chckAllColeg1 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bttnGen As Button
    Friend WithEvents bttnBack As Button
End Class
