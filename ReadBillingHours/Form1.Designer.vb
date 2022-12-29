<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.RadioButtonOnlyB = New System.Windows.Forms.RadioButton()
        Me.RadioButtonExcludeBorS = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonIncludeAll = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOnlyS = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ReadFile"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(195, 22)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(490, 734)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(701, 22)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(513, 734)
        Me.TextBox2.TabIndex = 2
        '
        'RadioButtonOnlyB
        '
        Me.RadioButtonOnlyB.AutoSize = True
        Me.RadioButtonOnlyB.Location = New System.Drawing.Point(11, 42)
        Me.RadioButtonOnlyB.Name = "RadioButtonOnlyB"
        Me.RadioButtonOnlyB.Size = New System.Drawing.Size(136, 17)
        Me.RadioButtonOnlyB.TabIndex = 3
        Me.RadioButtonOnlyB.Text = "OnlyLinesStartingWithB"
        Me.RadioButtonOnlyB.UseVisualStyleBackColor = True
        '
        'RadioButtonExcludeBorS
        '
        Me.RadioButtonExcludeBorS.AutoSize = True
        Me.RadioButtonExcludeBorS.Location = New System.Drawing.Point(11, 19)
        Me.RadioButtonExcludeBorS.Name = "RadioButtonExcludeBorS"
        Me.RadioButtonExcludeBorS.Size = New System.Drawing.Size(169, 17)
        Me.RadioButtonExcludeBorS.TabIndex = 4
        Me.RadioButtonExcludeBorS.Text = "ExcludeLinesStartingWithBorS"
        Me.RadioButtonExcludeBorS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonOnlyS)
        Me.GroupBox1.Controls.Add(Me.RadioButtonIncludeAll)
        Me.GroupBox1.Controls.Add(Me.RadioButtonOnlyB)
        Me.GroupBox1.Controls.Add(Me.RadioButtonExcludeBorS)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 130)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButtonIncludeAll
        '
        Me.RadioButtonIncludeAll.AutoSize = True
        Me.RadioButtonIncludeAll.Checked = True
        Me.RadioButtonIncludeAll.Location = New System.Drawing.Point(11, 88)
        Me.RadioButtonIncludeAll.Name = "RadioButtonIncludeAll"
        Me.RadioButtonIncludeAll.Size = New System.Drawing.Size(74, 17)
        Me.RadioButtonIncludeAll.TabIndex = 5
        Me.RadioButtonIncludeAll.TabStop = True
        Me.RadioButtonIncludeAll.Text = "Include All"
        Me.RadioButtonIncludeAll.UseVisualStyleBackColor = True
        '
        'RadioButtonOnlyS
        '
        Me.RadioButtonOnlyS.AutoSize = True
        Me.RadioButtonOnlyS.Location = New System.Drawing.Point(11, 65)
        Me.RadioButtonOnlyS.Name = "RadioButtonOnlyS"
        Me.RadioButtonOnlyS.Size = New System.Drawing.Size(136, 17)
        Me.RadioButtonOnlyS.TabIndex = 6
        Me.RadioButtonOnlyS.Text = "OnlyLinesStartingWithS"
        Me.RadioButtonOnlyS.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 768)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButtonOnlyB As RadioButton
    Friend WithEvents RadioButtonExcludeBorS As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonIncludeAll As RadioButton
    Friend WithEvents RadioButtonOnlyS As RadioButton
End Class
