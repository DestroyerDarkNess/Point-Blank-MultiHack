<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D3D
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Aimbotvsr = New System.Windows.Forms.Timer(Me.components)
        Me.TwitchTheme1 = New wallhack.TwitchTheme()
        Me.TwitchGroupBox1 = New wallhack.TwitchGroupBox()
        Me.item4_off = New System.Windows.Forms.Label()
        Me.item4 = New System.Windows.Forms.Label()
        Me.item3 = New System.Windows.Forms.Label()
        Me.item3_off = New System.Windows.Forms.Label()
        Me.item1 = New System.Windows.Forms.Label()
        Me.item2_off = New System.Windows.Forms.Label()
        Me.item1_off = New System.Windows.Forms.Label()
        Me.item2 = New System.Windows.Forms.Label()
        Me.TwitchTheme1.SuspendLayout()
        Me.TwitchGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Aimbotvsr
        '
        '
        'TwitchTheme1
        '
        Me.TwitchTheme1.BackColor = System.Drawing.Color.White
        Me.TwitchTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.TwitchTheme1.Controls.Add(Me.TwitchGroupBox1)
        Me.TwitchTheme1.Customization = "AAD//w=="
        Me.TwitchTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TwitchTheme1.Fill = True
        Me.TwitchTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TwitchTheme1.Image = Nothing
        Me.TwitchTheme1.Location = New System.Drawing.Point(0, 0)
        Me.TwitchTheme1.Movable = True
        Me.TwitchTheme1.Name = "TwitchTheme1"
        Me.TwitchTheme1.NoRounding = False
        Me.TwitchTheme1.Sizable = True
        Me.TwitchTheme1.Size = New System.Drawing.Size(207, 213)
        Me.TwitchTheme1.SmartBounds = True
        Me.TwitchTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.TwitchTheme1.TabIndex = 0
        Me.TwitchTheme1.Text = "TwitchTheme1"
        Me.TwitchTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.TwitchTheme1.Transparent = False
        '
        'TwitchGroupBox1
        '
        Me.TwitchGroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.TwitchGroupBox1.Colors = New wallhack.Bloom(-1) {}
        Me.TwitchGroupBox1.Controls.Add(Me.item4_off)
        Me.TwitchGroupBox1.Controls.Add(Me.item4)
        Me.TwitchGroupBox1.Controls.Add(Me.item3)
        Me.TwitchGroupBox1.Controls.Add(Me.item3_off)
        Me.TwitchGroupBox1.Controls.Add(Me.item1)
        Me.TwitchGroupBox1.Controls.Add(Me.item2_off)
        Me.TwitchGroupBox1.Controls.Add(Me.item1_off)
        Me.TwitchGroupBox1.Controls.Add(Me.item2)
        Me.TwitchGroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TwitchGroupBox1.Customization = ""
        Me.TwitchGroupBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TwitchGroupBox1.Image = Nothing
        Me.TwitchGroupBox1.Location = New System.Drawing.Point(3, 27)
        Me.TwitchGroupBox1.Movable = True
        Me.TwitchGroupBox1.Name = "TwitchGroupBox1"
        Me.TwitchGroupBox1.NoRounding = False
        Me.TwitchGroupBox1.Sizable = True
        Me.TwitchGroupBox1.Size = New System.Drawing.Size(201, 183)
        Me.TwitchGroupBox1.SmartBounds = True
        Me.TwitchGroupBox1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TwitchGroupBox1.TabIndex = 10
        Me.TwitchGroupBox1.Text = "MultiHack v1.2"
        Me.TwitchGroupBox1.TransparencyKey = System.Drawing.Color.Empty
        Me.TwitchGroupBox1.Transparent = False
        '
        'item4_off
        '
        Me.item4_off.AutoSize = True
        Me.item4_off.BackColor = System.Drawing.Color.Transparent
        Me.item4_off.ForeColor = System.Drawing.Color.Red
        Me.item4_off.Location = New System.Drawing.Point(149, 148)
        Me.item4_off.Name = "item4_off"
        Me.item4_off.Size = New System.Drawing.Size(38, 13)
        Me.item4_off.TabIndex = 13
        Me.item4_off.Text = "[OFF]"
        '
        'item4
        '
        Me.item4.AutoSize = True
        Me.item4.BackColor = System.Drawing.Color.Transparent
        Me.item4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item4.ForeColor = System.Drawing.Color.White
        Me.item4.Location = New System.Drawing.Point(3, 145)
        Me.item4.Name = "item4"
        Me.item4.Size = New System.Drawing.Size(88, 18)
        Me.item4.TabIndex = 12
        Me.item4.Text = "- AutoShot"
        '
        'item3
        '
        Me.item3.AutoSize = True
        Me.item3.BackColor = System.Drawing.Color.Transparent
        Me.item3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item3.ForeColor = System.Drawing.Color.White
        Me.item3.Location = New System.Drawing.Point(3, 112)
        Me.item3.Name = "item3"
        Me.item3.Size = New System.Drawing.Size(128, 18)
        Me.item3.TabIndex = 10
        Me.item3.Text = "- Aimbot Colors"
        '
        'item3_off
        '
        Me.item3_off.AutoSize = True
        Me.item3_off.BackColor = System.Drawing.Color.Transparent
        Me.item3_off.ForeColor = System.Drawing.Color.Red
        Me.item3_off.Location = New System.Drawing.Point(149, 115)
        Me.item3_off.Name = "item3_off"
        Me.item3_off.Size = New System.Drawing.Size(38, 13)
        Me.item3_off.TabIndex = 11
        Me.item3_off.Text = "[OFF]"
        '
        'item1
        '
        Me.item1.AutoSize = True
        Me.item1.BackColor = System.Drawing.Color.Transparent
        Me.item1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item1.ForeColor = System.Drawing.Color.White
        Me.item1.Location = New System.Drawing.Point(5, 50)
        Me.item1.Name = "item1"
        Me.item1.Size = New System.Drawing.Size(112, 18)
        Me.item1.TabIndex = 6
        Me.item1.Text = "- CT WallHack"
        '
        'item2_off
        '
        Me.item2_off.AutoSize = True
        Me.item2_off.BackColor = System.Drawing.Color.Transparent
        Me.item2_off.ForeColor = System.Drawing.Color.Red
        Me.item2_off.Location = New System.Drawing.Point(149, 83)
        Me.item2_off.Name = "item2_off"
        Me.item2_off.Size = New System.Drawing.Size(38, 13)
        Me.item2_off.TabIndex = 9
        Me.item2_off.Text = "[OFF]"
        '
        'item1_off
        '
        Me.item1_off.AutoSize = True
        Me.item1_off.BackColor = System.Drawing.Color.Transparent
        Me.item1_off.ForeColor = System.Drawing.Color.Red
        Me.item1_off.Location = New System.Drawing.Point(149, 53)
        Me.item1_off.Name = "item1_off"
        Me.item1_off.Size = New System.Drawing.Size(38, 13)
        Me.item1_off.TabIndex = 7
        Me.item1_off.Text = "[OFF]"
        '
        'item2
        '
        Me.item2.AutoSize = True
        Me.item2.BackColor = System.Drawing.Color.Transparent
        Me.item2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item2.ForeColor = System.Drawing.Color.White
        Me.item2.Location = New System.Drawing.Point(5, 80)
        Me.item2.Name = "item2"
        Me.item2.Size = New System.Drawing.Size(112, 18)
        Me.item2.TabIndex = 8
        Me.item2.Text = "- TR WallHack"
        '
        'D3D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 213)
        Me.Controls.Add(Me.TwitchTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D3D"
        Me.Opacity = 0.95R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "MultiHack   By **Aincrad**"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.TwitchTheme1.ResumeLayout(False)
        Me.TwitchGroupBox1.ResumeLayout(False)
        Me.TwitchGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TwitchTheme1 As wallhack.TwitchTheme
    Friend WithEvents TwitchGroupBox1 As wallhack.TwitchGroupBox
    Friend WithEvents item1 As System.Windows.Forms.Label
    Friend WithEvents item2_off As System.Windows.Forms.Label
    Friend WithEvents item1_off As System.Windows.Forms.Label
    Friend WithEvents item2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents item3 As System.Windows.Forms.Label
    Friend WithEvents item3_off As System.Windows.Forms.Label
    Friend WithEvents item4_off As System.Windows.Forms.Label
    Friend WithEvents item4 As System.Windows.Forms.Label
    Friend WithEvents Aimbotvsr As System.Windows.Forms.Timer
End Class
