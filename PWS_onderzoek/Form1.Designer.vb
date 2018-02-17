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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "01.jpg")
        Me.ImageList1.Images.SetKeyName(1, "01.jpg")
        Me.ImageList1.Images.SetKeyName(2, "14.jpg")
        Me.ImageList1.Images.SetKeyName(3, "01.jpg")
        Me.ImageList1.Images.SetKeyName(4, "01.jpg")
        Me.ImageList1.Images.SetKeyName(5, "12.jpg")
        Me.ImageList1.Images.SetKeyName(6, "07.jpg")
        Me.ImageList1.Images.SetKeyName(7, "07.jpg")
        Me.ImageList1.Images.SetKeyName(8, "11.jpg")
        Me.ImageList1.Images.SetKeyName(9, "11.jpg")
        Me.ImageList1.Images.SetKeyName(10, "01.jpg")
        Me.ImageList1.Images.SetKeyName(11, "02.jpg")
        Me.ImageList1.Images.SetKeyName(12, "02.jpg")
        Me.ImageList1.Images.SetKeyName(13, "15.jpg")
        Me.ImageList1.Images.SetKeyName(14, "03.jpg")
        Me.ImageList1.Images.SetKeyName(15, "12.jpg")
        Me.ImageList1.Images.SetKeyName(16, "02.jpg")
        Me.ImageList1.Images.SetKeyName(17, "11.jpg")
        Me.ImageList1.Images.SetKeyName(18, "02.jpg")
        Me.ImageList1.Images.SetKeyName(19, "15.jpg")
        Me.ImageList1.Images.SetKeyName(20, "05.jpg")
        Me.ImageList1.Images.SetKeyName(21, "15.jpg")
        Me.ImageList1.Images.SetKeyName(22, "03.jpg")
        Me.ImageList1.Images.SetKeyName(23, "12.jpg")
        Me.ImageList1.Images.SetKeyName(24, "06.jpg")
        Me.ImageList1.Images.SetKeyName(25, "15.jpg")
        Me.ImageList1.Images.SetKeyName(26, "15.jpg")
        Me.ImageList1.Images.SetKeyName(27, "07.jpg")
        Me.ImageList1.Images.SetKeyName(28, "07.jpg")
        Me.ImageList1.Images.SetKeyName(29, "08.jpg")
        Me.ImageList1.Images.SetKeyName(30, "12.jpg")
        Me.ImageList1.Images.SetKeyName(31, "15.jpg")
        Me.ImageList1.Images.SetKeyName(32, "01.jpg")
        Me.ImageList1.Images.SetKeyName(33, "12.jpg")
        Me.ImageList1.Images.SetKeyName(34, "15.jpg")
        Me.ImageList1.Images.SetKeyName(35, "02.jpg")
        Me.ImageList1.Images.SetKeyName(36, "07.jpg")
        Me.ImageList1.Images.SetKeyName(37, "02.jpg")
        Me.ImageList1.Images.SetKeyName(38, "06.jpg")
        Me.ImageList1.Images.SetKeyName(39, "05.jpg")
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(28, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(255, 192)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(401, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(255, 192)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button1.Location = New System.Drawing.Point(28, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(628, 75)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Hetzelfde"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Button2.Location = New System.Drawing.Point(28, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(628, 69)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Verschillend"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 400)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
