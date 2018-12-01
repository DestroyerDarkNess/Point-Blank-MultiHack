<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bypass = New System.Windows.Forms.Timer(Me.components)
        Me.TwitchLabel6 = New wallhack.TwitchLabel()
        Me.TwitchLabel5 = New wallhack.TwitchLabel()
        Me.TwitchLabel4 = New wallhack.TwitchLabel()
        Me.TwitchLabel3 = New wallhack.TwitchLabel()
        Me.TwitchLabel2 = New wallhack.TwitchLabel()
        Me.TwitchLabel1 = New wallhack.TwitchLabel()
        Me.WinEightMinimizeButton1 = New wallhack.WinEightMinimizeButton()
        Me.WinEightCloseButton1 = New wallhack.WinEightCloseButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 999
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(416, 199)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(288, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 69)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Status : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "They wait for the game"
        '
        'bypass
        '
        '
        'TwitchLabel6
        '
        Me.TwitchLabel6.AutoSize = True
        Me.TwitchLabel6.BackColor = System.Drawing.Color.Transparent
        Me.TwitchLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TwitchLabel6.Location = New System.Drawing.Point(245, 7)
        Me.TwitchLabel6.Name = "TwitchLabel6"
        Me.TwitchLabel6.Size = New System.Drawing.Size(121, 13)
        Me.TwitchLabel6.TabIndex = 37
        Me.TwitchLabel6.Text = "Contains X-Trap ByPass"
        '
        'TwitchLabel5
        '
        Me.TwitchLabel5.AutoSize = True
        Me.TwitchLabel5.BackColor = System.Drawing.Color.Transparent
        Me.TwitchLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TwitchLabel5.Location = New System.Drawing.Point(-3, 210)
        Me.TwitchLabel5.Name = "TwitchLabel5"
        Me.TwitchLabel5.Size = New System.Drawing.Size(80, 13)
        Me.TwitchLabel5.TabIndex = 7
        Me.TwitchLabel5.Text = "Tidas (THEME)"
        '
        'TwitchLabel4
        '
        Me.TwitchLabel4.AutoSize = True
        Me.TwitchLabel4.BackColor = System.Drawing.Color.Transparent
        Me.TwitchLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TwitchLabel4.Location = New System.Drawing.Point(-3, 233)
        Me.TwitchLabel4.Name = "TwitchLabel4"
        Me.TwitchLabel4.Size = New System.Drawing.Size(76, 13)
        Me.TwitchLabel4.TabIndex = 6
        Me.TwitchLabel4.Text = "Cless (Modulo)"
        '
        'TwitchLabel3
        '
        Me.TwitchLabel3.AutoSize = True
        Me.TwitchLabel3.BackColor = System.Drawing.Color.Transparent
        Me.TwitchLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TwitchLabel3.Location = New System.Drawing.Point(-3, 188)
        Me.TwitchLabel3.Name = "TwitchLabel3"
        Me.TwitchLabel3.Size = New System.Drawing.Size(89, 13)
        Me.TwitchLabel3.TabIndex = 5
        Me.TwitchLabel3.Text = "**Aincrad** (APP)"
        '
        'TwitchLabel2
        '
        Me.TwitchLabel2.AutoSize = True
        Me.TwitchLabel2.BackColor = System.Drawing.Color.Transparent
        Me.TwitchLabel2.ForeColor = System.Drawing.Color.Cyan
        Me.TwitchLabel2.Location = New System.Drawing.Point(-3, 165)
        Me.TwitchLabel2.Name = "TwitchLabel2"
        Me.TwitchLabel2.Size = New System.Drawing.Size(45, 13)
        Me.TwitchLabel2.TabIndex = 4
        Me.TwitchLabel2.Text = "Credits :"
        '
        'TwitchLabel1
        '
        Me.TwitchLabel1.AutoSize = True
        Me.TwitchLabel1.BackColor = System.Drawing.Color.Transparent
        Me.TwitchLabel1.ForeColor = System.Drawing.Color.Cyan
        Me.TwitchLabel1.Location = New System.Drawing.Point(12, 10)
        Me.TwitchLabel1.Name = "TwitchLabel1"
        Me.TwitchLabel1.Size = New System.Drawing.Size(100, 13)
        Me.TwitchLabel1.TabIndex = 3
        Me.TwitchLabel1.Text = "Point Blank Loader "
        '
        'WinEightMinimizeButton1
        '
        Me.WinEightMinimizeButton1.Customization = "AAAA/w=="
        Me.WinEightMinimizeButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.WinEightMinimizeButton1.Image = Nothing
        Me.WinEightMinimizeButton1.Location = New System.Drawing.Point(396, 0)
        Me.WinEightMinimizeButton1.Name = "WinEightMinimizeButton1"
        Me.WinEightMinimizeButton1.NoRounding = False
        Me.WinEightMinimizeButton1.Size = New System.Drawing.Size(25, 20)
        Me.WinEightMinimizeButton1.TabIndex = 2
        Me.WinEightMinimizeButton1.Text = "_"
        Me.WinEightMinimizeButton1.Transparent = False
        '
        'WinEightCloseButton1
        '
        Me.WinEightCloseButton1.Customization = "AAAA/w=="
        Me.WinEightCloseButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.WinEightCloseButton1.Image = Nothing
        Me.WinEightCloseButton1.Location = New System.Drawing.Point(427, 0)
        Me.WinEightCloseButton1.Name = "WinEightCloseButton1"
        Me.WinEightCloseButton1.NoRounding = False
        Me.WinEightCloseButton1.Size = New System.Drawing.Size(42, 23)
        Me.WinEightCloseButton1.TabIndex = 1
        Me.WinEightCloseButton1.Text = "close"
        Me.WinEightCloseButton1.Transparent = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(474, 246)
        Me.Controls.Add(Me.TwitchLabel6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TwitchLabel5)
        Me.Controls.Add(Me.TwitchLabel4)
        Me.Controls.Add(Me.TwitchLabel3)
        Me.Controls.Add(Me.TwitchLabel2)
        Me.Controls.Add(Me.TwitchLabel1)
        Me.Controls.Add(Me.WinEightMinimizeButton1)
        Me.Controls.Add(Me.WinEightCloseButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Point Blank MultiHack"
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WinEightCloseButton1 As wallhack.WinEightCloseButton
    Friend WithEvents WinEightMinimizeButton1 As wallhack.WinEightMinimizeButton
    Friend WithEvents TwitchLabel1 As wallhack.TwitchLabel
    Friend WithEvents TwitchLabel2 As wallhack.TwitchLabel
    Friend WithEvents TwitchLabel3 As wallhack.TwitchLabel
    Friend WithEvents TwitchLabel4 As wallhack.TwitchLabel
    Friend WithEvents TwitchLabel5 As wallhack.TwitchLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TwitchLabel6 As wallhack.TwitchLabel
    Friend WithEvents bypass As System.Windows.Forms.Timer

End Class
