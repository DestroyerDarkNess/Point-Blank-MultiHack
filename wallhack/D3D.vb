Imports System.Math

Public Class D3D
    Dim Hack1 As Integer = 0 'Hack1
    Dim Hack2 As Integer = 0 'Hack2
    Dim Hack3 As Integer = 0 'Hack3
    Dim Hack4 As Integer = 0 'Hack4


    Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer
    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    Private Const mouserightdown = 8
    Private Const mouserightup = 10
    Private Const mouseclickup = 4
    Private Const mouseclickdown = 2

    Private Const SW_SHOWMAXIMIZED As Integer = 3
    Private Const SW_SHOWMINIMIZED As Integer = 2
    Private Const SW_SHOWNORMAL As Integer = 1


    Private Structure POINTAPI
        Public x As Integer
        Public y As Integer
    End Structure


    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure


    Private Structure WINDOWPLACEMENT
        Public Length As Integer
        Public flags As Integer
        Public showCmd As Integer
        Public ptMinPosition As POINTAPI
        Public ptMaxPosition As POINTAPI
        Public rcNormalPosition As RECT
    End Structure
    Dim PosX, PosY, PosZ, Alvo1X, Alvo1Y, Alvo1Z, DisX, DisY, DisZ, Distancia1, AnguloX, AnguloY As Single

    Private Declare Function GetWindowPlacement Lib "user32" (ByVal hwnd As IntPtr, ByRef lpwndpl As WINDOWPLACEMENT) As Integer
    Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Private Sub GetWindowStats(ByVal handle As IntPtr)
        Dim wp As WINDOWPLACEMENT
        wp.Length = System.Runtime.InteropServices.Marshal.SizeOf(wp)
        GetWindowPlacement(handle, wp)
        If wp.showCmd = SW_SHOWMAXIMIZED Then


            If handle = GetForegroundWindow Then


            Else


            End If
        ElseIf wp.showCmd = SW_SHOWNORMAL Then
            If handle = GetForegroundWindow Then
                Me.Visible = True
            Else
            End If
        ElseIf wp.showCmd = SW_SHOWMINIMIZED Then
            Me.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            GetWindowStats(Process.GetProcessesByName("PointBlank")(0).MainWindowHandle)
        Catch ex As Exception
            Me.Visible = False
            Timer1.Stop()
            MsgBox("GAME NOT FOUND")
            Application.Exit()
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If GetKeyPress(Keys.Insert) Then
            If Me.Visible = True Then
                Me.Visible = False
                Timer1.Stop()
                Exit Sub
            End If
            If Me.Visible = False Then
                Me.Visible = True
                Timer1.Start()
                Exit Sub
            End If
        End If


        If GetKeyPress(Keys.Delete) Then
            Me.Close()
        End If


        '///////////////DOWN NAVIGATE///////////////////


        If GetKeyPress(Keys.Down) Then
            If item1.ForeColor = Color.DeepSkyBlue Then
                item1.ForeColor = Color.White
                If item1_off.Text = "[OFF]" Then item1_off.ForeColor = Color.Red
                If item1_off.Text = "[ON]" Then item1_off.ForeColor = Color.LimeGreen
                item2.ForeColor = Color.DeepSkyBlue
                item2_off.ForeColor = Color.DeepSkyBlue
                Exit Sub
            End If


            If item2.ForeColor = Color.DeepSkyBlue Then
                item2.ForeColor = Color.White
                If item2_off.Text = "[OFF]" Then item2_off.ForeColor = Color.Red
                If item2_off.Text = "[ON]" Then item2_off.ForeColor = Color.LimeGreen
                item3.ForeColor = Color.DeepSkyBlue
                item3_off.ForeColor = Color.DeepSkyBlue
                Exit Sub
            End If


            If item3.ForeColor = Color.DeepSkyBlue Then
                item3.ForeColor = Color.White
                If item3_off.Text = "[OFF]" Then item3_off.ForeColor = Color.Red
                If item3_off.Text = "[ON]" Then item3_off.ForeColor = Color.LimeGreen
                item4.ForeColor = Color.DeepSkyBlue
                item4_off.ForeColor = Color.DeepSkyBlue
                Exit Sub
            End If


            If item4.ForeColor = Color.DeepSkyBlue Then
                item4.ForeColor = Color.White
                If item4_off.Text = "[OFF]" Then item4_off.ForeColor = Color.Red
                If item4_off.Text = "[ON]" Then item4_off.ForeColor = Color.LimeGreen
                item1.ForeColor = Color.DeepSkyBlue
                item1_off.ForeColor = Color.DeepSkyBlue
                Exit Sub
            End If
        End If


        '///////////////UP NAVIGATE///////////////////


        If GetKeyPress(Keys.Up) Then
            If item1.ForeColor = Color.DeepSkyBlue Then
                item1.ForeColor = Color.White
                If item1_off.Text = "[OFF]" Then item1_off.ForeColor = Color.Red
                If item1_off.Text = "[ON]" Then item1_off.ForeColor = Color.LimeGreen
                item4.ForeColor = Color.DeepSkyBlue
                item4_off.ForeColor = Color.DeepSkyBlue
                Exit Sub
            End If


            If item2.ForeColor = Color.DeepSkyBlue Then
                item2.ForeColor = Color.White
                If item2_off.Text = "[OFF]" Then item2_off.ForeColor = Color.Red
                If item2_off.Text = "[ON]" Then item2_off.ForeColor = Color.LimeGreen
                item1.ForeColor = Color.DeepSkyBlue
                item1_off.ForeColor = Color.DeepSkyBlue
                Exit Sub
            End If


            If item3.ForeColor = Color.DeepSkyBlue Then
                item3.ForeColor = Color.White
                If item3_off.Text = "[OFF]" Then item3_off.ForeColor = Color.Red
                If item3_off.Text = "[ON]" Then item3_off.ForeColor = Color.LimeGreen
                item2.ForeColor = Color.DeepSkyBlue
                item2_off.ForeColor = Color.DeepSkyBlue
                Exit Sub
            End If


            If item4.ForeColor = Color.DeepSkyBlue Then
                item4.ForeColor = Color.White
                If item4_off.Text = "[OFF]" Then item4_off.ForeColor = Color.Red
                If item4_off.Text = "[ON]" Then item4_off.ForeColor = Color.LimeGreen
                item3.ForeColor = Color.DeepSkyBlue
                item3_off.ForeColor = Color.DeepSkyBlue
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        '///////////////RIGHT = ACTIVE/////////////
        If GetKeyPress(Keys.Right) Then
            If item1.ForeColor = Color.DeepSkyBlue Then
                If item1_off.Text = "[OFF]" Then
                    item1_off.Text = "[ON]"
                    Hack1 = 1 '
                    Exit Sub
                End If
            End If

            If item2.ForeColor = Color.DeepSkyBlue Then
                If item2_off.Text = "[OFF]" Then
                    item2_off.Text = "[ON]"
                    Hack2 = 1
                    Exit Sub
                End If
            End If

            If item3.ForeColor = Color.DeepSkyBlue Then
                If item3_off.Text = "[OFF]" Then
                    item3_off.Text = "[ON]"
                    Hack3 = 1
                    Exit Sub
                End If
            End If

            If item4.ForeColor = Color.DeepSkyBlue Then
                If item4_off.Text = "[OFF]" Then
                    item4_off.Text = "[ON]"
                    Hack4 = 1
                    Exit Sub
                End If
            End If

        End If


        '///////////////RIGHT = ACTIVE/////////////
        If GetKeyPress(Keys.Left) Then
            If item1.ForeColor = Color.DeepSkyBlue Then
                item1_off.Text = "[OFF]"
                Hack1 = 0
                Exit Sub
            End If

            If item2.ForeColor = Color.DeepSkyBlue Then
                item2_off.Text = "[OFF]"
                Hack2 = 0
                Exit Sub
            End If

            If item3.ForeColor = Color.DeepSkyBlue Then
                item3_off.Text = "[OFF]"
                Hack3 = 0
                Exit Sub
            End If

            If item4.ForeColor = Color.DeepSkyBlue Then
                item4_off.Text = "[OFF]"
                Hack4 = 0
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Dim p As Process()
        p = Process.GetProcessesByName("PointBlank")
        If p.Count = 1 Then

            If Hack1 = 1 Then
                CT()
            Else
                'Aqui el codigo del hack apagado
            End If

            If Hack2 = 1 Then
                TR()
            Else
                'Aqui el codigo del hack apagado
            End If

            If Hack3 = 1 Then
                aimbot()
            Else
                'Aqui el codigo del hack apagado
            End If

            If Hack4 = 1 Then
                If ReadInteger("PointBlank", &H400008CC) = 108485156 Then
                    apimouse_event(mouseclickdown, 0, 0, 0, 0)
                    apimouse_event(mouseclickup, 0, 0, 0, 0)
                End If
            Else
                'Aqui el codigo del hack apagado
            End If

        Else

        End If
    End Sub

    Private Sub D3D_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Aimbotvsr.Interval = 1

        Me.Hide()
        item1.ForeColor = Color.DeepSkyBlue
        item1_off.ForeColor = Color.DeepSkyBlue
        Try
            Interaction.AppActivate("PointBlank")
            Me.TopMost = True
        Catch
            Me.TopMost = True
        End Try
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()
    End Sub

#Region "Hacks"

    Private Sub CT()
        Dim almacenador As Integer
        almacenador = ReadPointerInteger("PointBlank", &HA72C74, &H310)
        ReadPointerInteger("PointBlank", &HA72C74, &H348)
        ReadPointerInteger("PointBlank", &HA72C74, &H380)
        ReadPointerInteger("PointBlank", &HA72C74, &H3B8)
        ReadPointerInteger("PointBlank", &HA72C74, &H428)
        ReadPointerInteger("PointBlank", &HA72C74, &H460)
        ReadPointerInteger("PointBlank", &HA72C74, &H4D0)
        WritePointerInteger("PointBlank", &HA72C74, almacenador, &H32C)
        WritePointerInteger("PointBlank", &HA72C74, almacenador, &H364)
        WritePointerInteger("PointBlank", &HA72C74, almacenador, &H39C)
        WritePointerInteger("PointBlank", &HA72C74, almacenador, &H3D4)
        WritePointerInteger("PointBlank", &HA72C74, almacenador, &H40C)
        WritePointerInteger("PointBlank", &HA72C74, almacenador, &H444)
        WritePointerInteger("PointBlank", &HA72C74, almacenador, &H47C)
        WritePointerInteger("PointBlank", &HA72C74, almacenador, &H4B4)
    End Sub

    Private Sub TR()
        Dim almacenadortr As Integer
        almacenadortr = ReadPointerInteger("PointBlank", &HA72C74, &H32C)
        ReadPointerInteger("PointBlank", &HA72C74, &H364)
        ReadPointerInteger("PointBlank", &HA72C74, &H39C)
        ReadPointerInteger("PointBlank", &HA72C74, &H3D4)
        ReadPointerInteger("PointBlank", &HA72C74, &H40C)
        ReadPointerInteger("PointBlank", &HA72C74, &H444)
        ReadPointerInteger("PointBlank", &HA72C74, &H47C)
        ReadPointerInteger("PointBlank", &HA72C74, &H4B4)
        WritePointerInteger("PointBlank", &HA72C74, almacenadortr, &H310)
        WritePointerInteger("PointBlank", &HA72C74, almacenadortr, &H348)
        WritePointerInteger("PointBlank", &HA72C74, almacenadortr, &H380)
        WritePointerInteger("PointBlank", &HA72C74, almacenadortr, &H3B8)
        WritePointerInteger("PointBlank", &HA72C74, almacenadortr, &H428)
        WritePointerInteger("PointBlank", &HA72C74, almacenadortr, &H460)
        WritePointerInteger("PointBlank", &HA72C74, almacenadortr, &H4D0)
    End Sub

    Private Sub aimbot()
        DisX = Alvo1X - PosX
        DisY = Alvo1Y - PosY
        DisZ = Alvo1Z - PosZ

        WritePointerFloat("PointBlank", &HA72C74, AnguloX, &H310)
        WritePointerFloat("PointBlank", &HA72C74, AnguloY, &H32C)
    End Sub

    Private Sub Aimbotvsr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aimbotvsr.Tick
        PosX = ReadPointerFloat("PointBlank", &HA72C74, &H310)
        PosY = ReadPointerFloat("PointBlank", &HA72C74, &H348)
        PosZ = ReadPointerFloat("PointBlank", &HA72C74, &H4D0)

        Alvo1X = ReadPointerFloat("PointBlank", &HA72C74, &H32C)
        Alvo1Y = ReadPointerFloat("PointBlank", &HA72C74, &H364)
        Alvo1Z = ReadPointerFloat("PointBlank", &HA72C74, &H47C)
    End Sub

    Private Sub INIMIGO1()

        Distancia1 = Sqrt(PosX ^ 2 + PosY ^ 2)

        AnguloX = ((Atan(DisY / DisX)) * PI) / 180
        AnguloY = ((Atan(DisZ / Distancia1)) * PI) / 180

    End Sub

#End Region


End Class