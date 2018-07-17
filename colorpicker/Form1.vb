Public Class Form1

    Public bs As Busylight.SDK = New Busylight.SDK

    Private Sub MetroTrackBar3_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles MetroTrackBar3.Scroll
        blue.Text = MetroTrackBar3.Value
        onChange()
    End Sub

    Private Sub MetroTrackBar2_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles MetroTrackBar2.Scroll
        green.Text = MetroTrackBar2.Value
        onChange()
    End Sub

    Private Sub MetroTrackBar1_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs) Handles MetroTrackBar1.Scroll
        red.Text = MetroTrackBar1.Value
        onChange()
    End Sub

    Private Sub onChange()
        prev.BackColor = Color.FromArgb(red.Text, green.Text, blue.Text)
        bs.Light(red.Text, blue.Text, green.Text)
    End Sub
End Class
