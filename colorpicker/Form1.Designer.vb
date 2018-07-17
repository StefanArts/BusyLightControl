<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.red = New System.Windows.Forms.Label()
        Me.green = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MetroTrackBar2 = New MetroFramework.Controls.MetroTrackBar()
        Me.blue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MetroTrackBar1 = New MetroFramework.Controls.MetroTrackBar()
        Me.MetroTrackBar3 = New MetroFramework.Controls.MetroTrackBar()
        Me.prev = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Red"
        '
        'red
        '
        Me.red.AutoSize = True
        Me.red.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.red.Location = New System.Drawing.Point(270, 15)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(30, 32)
        Me.red.TabIndex = 2
        Me.red.Text = "0"
        '
        'green
        '
        Me.green.AutoSize = True
        Me.green.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.green.Location = New System.Drawing.Point(270, 57)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(30, 32)
        Me.green.TabIndex = 5
        Me.green.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Green"
        '
        'MetroTrackBar2
        '
        Me.MetroTrackBar2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MetroTrackBar2.Location = New System.Drawing.Point(97, 57)
        Me.MetroTrackBar2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MetroTrackBar2.Maximum = 255
        Me.MetroTrackBar2.Name = "MetroTrackBar2"
        Me.MetroTrackBar2.Size = New System.Drawing.Size(147, 32)
        Me.MetroTrackBar2.TabIndex = 3
        Me.MetroTrackBar2.Text = "MetroTrackBar2"
        Me.MetroTrackBar2.Value = 0
        '
        'blue
        '
        Me.blue.AutoSize = True
        Me.blue.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blue.Location = New System.Drawing.Point(270, 99)
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(30, 32)
        Me.blue.TabIndex = 8
        Me.blue.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 99)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 32)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Blue"
        '
        'MetroTrackBar1
        '
        Me.MetroTrackBar1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MetroTrackBar1.Location = New System.Drawing.Point(97, 14)
        Me.MetroTrackBar1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MetroTrackBar1.Maximum = 255
        Me.MetroTrackBar1.Name = "MetroTrackBar1"
        Me.MetroTrackBar1.Size = New System.Drawing.Size(147, 32)
        Me.MetroTrackBar1.TabIndex = 9
        Me.MetroTrackBar1.Text = "MetroTrackBar1"
        Me.MetroTrackBar1.Value = 0
        '
        'MetroTrackBar3
        '
        Me.MetroTrackBar3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MetroTrackBar3.Location = New System.Drawing.Point(97, 99)
        Me.MetroTrackBar3.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MetroTrackBar3.Maximum = 255
        Me.MetroTrackBar3.Name = "MetroTrackBar3"
        Me.MetroTrackBar3.Size = New System.Drawing.Size(147, 32)
        Me.MetroTrackBar3.TabIndex = 10
        Me.MetroTrackBar3.Text = "MetroTrackBar3"
        Me.MetroTrackBar3.Value = 0
        '
        'prev
        '
        Me.prev.Location = New System.Drawing.Point(12, 139)
        Me.prev.Name = "prev"
        Me.prev.Size = New System.Drawing.Size(302, 128)
        Me.prev.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(326, 279)
        Me.Controls.Add(Me.prev)
        Me.Controls.Add(Me.MetroTrackBar3)
        Me.Controls.Add(Me.MetroTrackBar1)
        Me.Controls.Add(Me.blue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.green)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MetroTrackBar2)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Picker Plugin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents red As System.Windows.Forms.Label
    Friend WithEvents green As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MetroTrackBar2 As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents blue As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MetroTrackBar1 As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroTrackBar3 As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents prev As System.Windows.Forms.Panel

End Class
