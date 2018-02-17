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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGemTijd = New System.Windows.Forms.Label()
        Me.lblGemTijdGoed = New System.Windows.Forms.Label()
        Me.lblGemTijdFout = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 287)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Analyse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Gemiddelde tijd"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gemiddelde tijd, goede antwoorden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gemiddelde tijd, foute antwoorden"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Percentage goed"
        '
        'lblGemTijd
        '
        Me.lblGemTijd.AutoSize = True
        Me.lblGemTijd.Location = New System.Drawing.Point(233, 42)
        Me.lblGemTijd.Name = "lblGemTijd"
        Me.lblGemTijd.Size = New System.Drawing.Size(0, 13)
        Me.lblGemTijd.TabIndex = 6
        '
        'lblGemTijdGoed
        '
        Me.lblGemTijdGoed.AutoSize = True
        Me.lblGemTijdGoed.Location = New System.Drawing.Point(235, 93)
        Me.lblGemTijdGoed.Name = "lblGemTijdGoed"
        Me.lblGemTijdGoed.Size = New System.Drawing.Size(0, 13)
        Me.lblGemTijdGoed.TabIndex = 7
        '
        'lblGemTijdFout
        '
        Me.lblGemTijdFout.AutoSize = True
        Me.lblGemTijdFout.Location = New System.Drawing.Point(239, 145)
        Me.lblGemTijdFout.Name = "lblGemTijdFout"
        Me.lblGemTijdFout.Size = New System.Drawing.Size(0, 13)
        Me.lblGemTijdFout.TabIndex = 8
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Location = New System.Drawing.Point(271, 209)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(0, 13)
        Me.lblPercentage.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 340)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblGemTijdFout)
        Me.Controls.Add(Me.lblGemTijdGoed)
        Me.Controls.Add(Me.lblGemTijd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblGemTijd As Label
    Friend WithEvents lblGemTijdGoed As Label
    Friend WithEvents lblGemTijdFout As Label
    Friend WithEvents lblPercentage As Label
End Class
