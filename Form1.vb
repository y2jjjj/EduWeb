Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    <DllImport("C:\Users\hiiam\source\repos\teawrap\Debug\teawrap.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Sub InitializeOpenGL()
    End Sub

    <DllImport("C:\Users\hiiam\source\repos\teawrap\Debug\teawrap.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Sub RenderTeapot()
    End Sub

    <DllImport("C:\Users\hiiam\source\repos\teawrap\Debug\teawrap.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Sub ResizeViewport(ByVal width As Integer, ByVal height As Integer)
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeOpenGL()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        RenderTeapot()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ResizeViewport(Me.ClientSize.Width, Me.ClientSize.Height)
    End Sub
End Class
