Public Class Form1
    Private Declare Sub mouse_event Lib "user32" (ByVal dwflags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cbuttons As Integer, ByVal dwextrainfo As Integer)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LeftClick()
    End Sub

    Public Sub LeftClick()
        mouse_event(2, 0, 0, 0, 0)
        mouse_event(4, 0, 0, 0, 0)
        If My.Computer.Keyboard.CtrlKeyDown Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo _Default
        Timer1.Interval = TextBox1.Text
        Timer1.Start()

_Default:
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub
End Class
