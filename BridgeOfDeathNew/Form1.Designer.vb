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
        Me.btbCross = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQuest = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblQuest2 = New System.Windows.Forms.Label()
        Me.lblColor2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btbCross
        '
        Me.btbCross.Location = New System.Drawing.Point(171, 191)
        Me.btbCross.Name = "btbCross"
        Me.btbCross.Size = New System.Drawing.Size(101, 23)
        Me.btbCross.TabIndex = 0
        Me.btbCross.Text = "Cross the Bridge!"
        Me.btbCross.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(171, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(172, 81)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(172, 152)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(71, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(101, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "What is your name?"
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.Location = New System.Drawing.Point(71, 81)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(103, 13)
        Me.lblQuest.TabIndex = 5
        Me.lblQuest.Text = "What is your Quest?"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(38, 152)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(136, 13)
        Me.lblColor.TabIndex = 6
        Me.lblColor.Text = "What is your favorite color?"
        '
        'lblName2
        '
        Me.lblName2.AutoSize = True
        Me.lblName2.Location = New System.Drawing.Point(24, 240)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(0, 13)
        Me.lblName2.TabIndex = 7
        '
        'lblQuest2
        '
        Me.lblQuest2.AutoSize = True
        Me.lblQuest2.Location = New System.Drawing.Point(109, 240)
        Me.lblQuest2.Name = "lblQuest2"
        Me.lblQuest2.Size = New System.Drawing.Size(0, 13)
        Me.lblQuest2.TabIndex = 8
        '
        'lblColor2
        '
        Me.lblColor2.AutoSize = True
        Me.lblColor2.Location = New System.Drawing.Point(208, 240)
        Me.lblColor2.Name = "lblColor2"
        Me.lblColor2.Size = New System.Drawing.Size(0, 13)
        Me.lblColor2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblColor2)
        Me.Controls.Add(Me.lblQuest2)
        Me.Controls.Add(Me.lblName2)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblQuest)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btbCross)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btbCross As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblQuest As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblName2 As System.Windows.Forms.Label
    Friend WithEvents lblQuest2 As System.Windows.Forms.Label
    Friend WithEvents lblColor2 As System.Windows.Forms.Label

End Class
