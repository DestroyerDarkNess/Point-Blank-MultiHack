Imports System.Runtime.InteropServices

Public Class Form1
    Private x As Integer
    Private y As Integer
    Private mover As Boolean

#Region "Puteria XD"

    Private Sub Form1_MouseDown( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' habilitar el flag  
            mover = True
            ' guardar las coordenadas  
            x = e.X
            y = e.Y
            ' cambiar el cursor del mouse  
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub

    Private Sub Form1_MouseMove( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If

    End Sub

    Private Sub Form1_MouseUp( _
        ByVal sender As Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gif()
        Timer1.Start()
    End Sub

    Private Sub WinEightCloseButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinEightCloseButton1.Click
        End
    End Sub

    Private Sub WinEightMinimizeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WinEightMinimizeButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub gif()
        PictureBox2.Image = My.Resources.p1
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim p As Process()
        p = Process.GetProcessesByName("PointBlank")
        If p.Count = 1 Then
            bypass.Start()
            bypass2()
            Label1.Text = "Status : " & vbNewLine & vbNewLine & "PointBlank Detected starting hack . . ."
            Timer1.Stop()
            D3D.Show()
            Me.Hide()
            D3D.Hide()
        End If
    End Sub

#End Region

#Region "X-trap Bypass"
    <DllImport("kernel32.dll")> _
    Public Shared Function OpenProcess(ByVal dwDesiredAccess As UInt32, ByVal bInheritHandle As Int32, ByVal dwProcessId As UInt32) As IntPtr
    End Function
    <DllImport("kernel32.dll")> _
    Public Shared Function CloseHandle(ByVal hObject As IntPtr) As Int32
    End Function
    <DllImport("kernel32.dll")> _
    Public Shared Function ReadProcessMemory(ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, <[In](), Out()> ByVal buffer As Byte(), ByVal size As UInt32, ByRef lpNumberOfBytesRead As IntPtr) As Int32
    End Function
    <DllImport("kernel32.dll")> _
    Public Shared Function WriteProcessMemory(ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, <[In](), Out()> ByVal buffer As Byte(), ByVal size As UInt32, ByRef lpNumberOfBytesWritten As IntPtr) As Int32
    End Function
    Private Declare Function WriteProcessMemory Lib "kernel32" Alias "WriteProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Single, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Single
    Public Shared Sub Writememory(ByVal ProcessName As String, ByVal Address As Integer, ByVal Value As Single, ByVal nsize As Integer)
        If ProcessName.EndsWith(".exe") Then
            ProcessName = ProcessName.Replace(".exe", "")
        End If
        Dim processesByName() As Process = Process.GetProcessesByName(ProcessName)
        Dim ptr As IntPtr = CType(OpenProcess(127231, 0, processesByName(0).Id), IntPtr)
        If Not (ptr = IntPtr.Zero) Then
            Dim lpBaseAddress As Integer = Address
            Dim lpBuffer As Single = Value
            Dim lpNumberOfBytesWritten As Integer = 0
            WriteProcessMemory(CType(ptr, Integer), lpBaseAddress, lpBuffer, nsize, lpNumberOfBytesWritten)
        End If
    End Sub

    Private Sub starbypass1()
        Writememory("GP.exe", &H410858, "X6va20", 7)
        If Not (Process.GetProcessesByName("Xtrap.xt").Length = 0) Then
            Writememory("GP.exe", &H410858, "X6va20", 7)
        End If
    End Sub

    Private Sub bypass2()
        If Not (Process.GetProcessesByName("Xtrap.xt").Length = 0) Then
            Writememory("PointBlank.exe", &H410858, "X6va20", 7)
        End If
    End Sub

#End Region

    Private Sub bypass_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bypass.Tick
        Dim p As Process()
        p = Process.GetProcessesByName("GP")
        If p.Count = 1 Then
            starbypass1()
        End If
    End Sub

End Class
