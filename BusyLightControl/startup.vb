Imports System.Management

Public Class startup
    Public bs As Busylight.SDK = New Busylight.SDK
    Public bsOn As Boolean = False
    Public bsMode As String = "normal"

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mode.Text = "Normal"
        version.Text = bs.Version
        If My.Computer.FileSystem.FileExists("multicolor.exe") Then
            pl_multicolor.Visible = True
        Else
            pl_multicolor.Visible = False
        End If

        If My.Computer.FileSystem.FileExists("colorpicker.exe") Then
            pl_colorpicker.Visible = True
        Else
            pl_colorpicker.Visible = False
        End If

        If bs.IsLightSupported = False Then
            MsgBox("kuando BusyLight is not connected.")
            bsOn = False
            status.Text = "No Device found!"
        Else
            colorCheck()
            bsOn = True
            status.Text = "Connected"

        End If

        Timer1.Interval = 500
        Timer1.Enabled = True

        Dim startcolor() As String = Environment.GetCommandLineArgs()

        Try

            If startcolor(1) = "red" Then
                bs.Light(Busylight.BusylightColor.Red)
            ElseIf startcolor(1) = "green" Then
                bs.Light(Busylight.BusylightColor.Green)
            ElseIf startcolor(1) = "blue" Then
                bs.Light(Busylight.BusylightColor.Blue)
            ElseIf startcolor(1) = "yellow" Then
                bs.Light(Busylight.BusylightColor.Yellow)
            End If

        Catch ex As IndexOutOfRangeException

        End Try

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If bs.IsLightSupported = False Then
            bsOn = False
            status.Text = "No Device found!"
        Else
            If bsOn = False Then
                colorCheck()
            End If
            bsOn = True
            status.Text = "Connected"

        End If
    End Sub

    Public Sub colorCheck()
        status.Text = "Colour Check..."
        bs.Light(Busylight.BusylightColor.Red)
        System.Threading.Thread.Sleep(500)
        bs.Light(Busylight.BusylightColor.Green)
        System.Threading.Thread.Sleep(500)
        bs.Light(Busylight.BusylightColor.Blue)
        System.Threading.Thread.Sleep(500)
        bs.Light(Busylight.BusylightColor.Yellow)
        System.Threading.Thread.Sleep(500)
        bs.Light(Busylight.BusylightColor.Off)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If bsMode = "normal" Then
            bs.Light(Busylight.BusylightColor.Green)
        End If

        If bsMode = "pulse" Then
            bs.Pulse(Busylight.BusylightColor.Green)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If bsMode = "normal" Then
            bs.Light(Busylight.BusylightColor.Yellow)
        End If

        If bsMode = "pulse" Then
            bs.Pulse(Busylight.BusylightColor.Yellow)
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If bsMode = "normal" Then
            bs.Light(Busylight.BusylightColor.Red)
        End If

        If bsMode = "pulse" Then
            bs.Pulse(Busylight.BusylightColor.Red)
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If bsMode = "normal" Then
            bs.Light(Busylight.BusylightColor.Blue)
        End If

        If bsMode = "pulse" Then
            bs.Pulse(Busylight.BusylightColor.Blue)
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        bs.Light(Busylight.BusylightColor.Off)

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        bsMode = "normal"
        mode.Text = "Normal"
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        bsMode = "pulse"
        mode.Text = "Pulse"
    End Sub

    Private Sub pl_multicolor_Click(sender As System.Object, e As System.EventArgs) Handles pl_multicolor.Click
        Process.Start("multicolor.exe")
    End Sub

    Private Sub pl_colorpicker_Click(sender As System.Object, e As System.EventArgs) Handles pl_colorpicker.Click
        Process.Start("colorpicker.exe")
    End Sub
End Class
