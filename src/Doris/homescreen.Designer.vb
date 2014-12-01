<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homescreen
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 72)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SINGLE PLAYER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(26, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 72)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "MULTI PLAYER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button3.Location = New System.Drawing.Point(26, 360)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(209, 72)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "EXIT GAME"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.PictureBox1.InitialImage = Global.WindowsApplication1.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(26, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(503, 89)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(948, 501)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
