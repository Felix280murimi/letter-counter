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
        Me.btnCountStringLetters = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnNumberOf = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblInTheString = New System.Windows.Forms.Label()
        Me.btnCounNumbersInString = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCountStringLetters
        '
        Me.btnCountStringLetters.Location = New System.Drawing.Point(84, 74)
        Me.btnCountStringLetters.Name = "btnCountStringLetters"
        Me.btnCountStringLetters.Size = New System.Drawing.Size(283, 35)
        Me.btnCountStringLetters.TabIndex = 0
        Me.btnCountStringLetters.Text = "Count String Letters"
        Me.btnCountStringLetters.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(283, 22)
        Me.TextBox1.TabIndex = 1
        '
        'btnNumberOf
        '
        Me.btnNumberOf.Location = New System.Drawing.Point(84, 115)
        Me.btnNumberOf.Name = "btnNumberOf"
        Me.btnNumberOf.Size = New System.Drawing.Size(102, 23)
        Me.btnNumberOf.TabIndex = 2
        Me.btnNumberOf.Text = "Number Of"
        Me.btnNumberOf.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(203, 118)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(64, 22)
        Me.TextBox2.TabIndex = 3
        '
        'lblInTheString
        '
        Me.lblInTheString.AutoSize = True
        Me.lblInTheString.Location = New System.Drawing.Point(285, 121)
        Me.lblInTheString.Name = "lblInTheString"
        Me.lblInTheString.Size = New System.Drawing.Size(82, 17)
        Me.lblInTheString.TabIndex = 4
        Me.lblInTheString.Text = "in the string"
        '
        'btnCounNumbersInString
        '
        Me.btnCounNumbersInString.Location = New System.Drawing.Point(84, 160)
        Me.btnCounNumbersInString.Name = "btnCounNumbersInString"
        Me.btnCounNumbersInString.Size = New System.Drawing.Size(283, 31)
        Me.btnCounNumbersInString.TabIndex = 2
        Me.btnCounNumbersInString.Text = "Count Numbers IN String"
        Me.btnCounNumbersInString.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 450)
        Me.Controls.Add(Me.lblInTheString)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnCounNumbersInString)
        Me.Controls.Add(Me.btnNumberOf)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCountStringLetters)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCountStringLetters As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnNumberOf As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblInTheString As Label
    Friend WithEvents btnCounNumbersInString As Button
End Class
