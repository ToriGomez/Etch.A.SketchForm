'Tori Gomez
'RCET0265
'Spring 2021
'Etch A Sketch
' 
Option Explicit On
Option Strict On

Imports System.Math
Imports System.Threading.Thread
Public Class EtchASketchForm
    'Global fields for graphics
    Dim g As Graphics
    Dim mainPen As New Pen(Color.Black)
    Dim lastPoint As Point
    'Initial start up state
    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.g = Me.DisplayPictureBox.CreateGraphics
        PenSizeToolStripTextBox.Visible = False
    End Sub
    'Draws line segments 
    Sub DrawLineSegment(startPoint As Point, endPoint As Point)
        g.DrawLine(Me.mainPen, startPoint, endPoint)
    End Sub
    'Action selection based on mouse button
    Private Sub DisplayPictureBox_Mousemove(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseDown, DisplayPictureBox.MouseMove
        Select Case e.Button.ToString
            Case "Left"
                DrawLineSegment(lastPoint, e.Location)
            Case "Middle"
                ColorDialog.ShowDialog()
                Me.mainPen.Color = ColorDialog.Color
            Case "Right"
                ColorDialog.ShowDialog()
                Me.mainPen.Color = ColorDialog.Color
        End Select
        'Update info
        Me.Text = $"({e.X},{e.Y}) Button: {e.Button.ToString} Color: {Me.mainPen.Color.ToString}"
        'Update last known point
        Me.lastPoint.X = e.X
        Me.lastPoint.Y = e.Y
    End Sub
    'Displays trigonometric functions; Sin, Cos, and Tan.
    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click, DrawWaveformsToolStripMenuItem.Click
        Dim wave As Graphics = DisplayPictureBox.CreateGraphics
        Dim _start As Point
        Dim _end As Point
        Dim yOffset As Single = CSng(DisplayPictureBox.Height / 2)
        wave.TranslateTransform(0, yOffset)
        Dim xMax As Single = 360
        Dim xScale As Single = CSng(DisplayPictureBox.Width / xMax)
        Dim yMax As Single = 150
        Dim yScale As Single = CSng(((DisplayPictureBox.Height) / 3) / yMax)
        wave.ScaleTransform(xScale, yScale)
        'Startup setup
        mainPen.Color = Color.Black
        DisplayPictureBox.Refresh()
        PenSizeToolStripTextBox.Text = "1"
        Me.mainPen.Width() = CSng(PenSizeToolStripTextBox.Text)
        'Creates graticule lines
        For i = 0 To 10
            g.DrawLine(mainPen, CSng(DisplayPictureBox.Width * (i / 10)), 0, CSng(DisplayPictureBox.Width * (i / 10)), CSng(DisplayPictureBox.Height))
            g.DrawLine(mainPen, 0, CSng(DisplayPictureBox.Height * (i / 10)), CSng(DisplayPictureBox.Width), CSng(DisplayPictureBox.Height * (i / 10)))
        Next
        'plot Sine
        mainPen.Color = Color.Red
        _start.X = 0
        _start.Y = 0
        'Vi = Vp * sin(360 * f * t + theta) + DC
        For i = 0 To CInt(xMax)
            _end.X = i
            _end.Y = CInt(yMax * Sin((PI / 180) * _end.X)) * -1
            wave.DrawLine(mainPen, _start, _end)
            _start.X = _end.X
            _start.Y = _end.Y
        Next
        'plot Cosine
        mainPen.Color = Color.Green
        _start.X = 0
        _start.Y = 0
        For i = 0 To CInt(xMax)
            _end.X = i
            _end.Y = CInt(yMax * Cos((PI / 180) * _end.X)) * -1
            wave.DrawLine(mainPen, _start, _end)
            _start.X = _end.X
            _start.Y = _end.Y
        Next
        'plot Tangent
        mainPen.Color = Color.Blue
        _start.X = 0
        _start.Y = 0
        For i = 0 To CInt(xMax)
            _end.X = i
            Try
                _end.Y = CInt(yMax * Tan((PI / 180) * _end.X)) * -1
            Catch
            End Try
            wave.DrawLine(mainPen, _start, _end)
            _start.X = _end.X
            _start.Y = _end.Y
        Next
        wave.Dispose()
    End Sub
    'Allows visibility of text box when pen size button is clicked.
    Private Sub PenSizeToolStripButton_Click(sender As Object, e As EventArgs) Handles PenSizeToolStripButton.Click
        PenSizeToolStripTextBox.Visible = True
        PenSizeToolStripTextBox.Select()
    End Sub
    'Changes pen size from userinput. If not numberical it highlights the error.
    Private Sub WidthToolStripTextBox() Handles PenSizeToolStripTextBox.LostFocus
        Try
            Me.mainPen.Width() = CSng(PenSizeToolStripTextBox.Text)
            PenSizeToolStripTextBox.BackColor = Color.White
            PenSizeToolStripTextBox.ToolTipText = "Pen Size"
        Catch ex As Exception
            PenSizeToolStripTextBox.BackColor = Color.Yellow
            Me.mainPen.Width() = 1
            PenSizeToolStripTextBox.ToolTipText = "Numerical Number Required" & vbNewLine & "Default: 1"
        End Try
    End Sub
    'Displays a Custom Color Dialog to change pen color.
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click, SelectColorToolStripMenuItem.Click
        ColorDialog.ShowDialog()
        Me.mainPen.Color = ColorDialog.Color
    End Sub
    'Shakes and clears the window display
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        ShakeSound()
        Shake()
        DisplayPictureBox.Refresh()
    End Sub
    'Closes the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitButton.Click
        Me.Close()
    End Sub
    'Shake sound effect resource
    Sub ShakeSound()
        'https://freesound.org/
        '    'play shake sound from project resources
        My.Computer.Audio.Play(My.Resources.shaker, AudioPlayMode.Background)
    End Sub
    'Moves/shakes the display window
    Sub Shake()
        Dim moveAmount = 50
        For i = 0 To 3
            Me.Top += moveAmount
            Me.Left += moveAmount
            Sleep(100)
            moveAmount *= -1
        Next
    End Sub
    'Displays message about the program.
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Use Mouse to Draw on Etch-a-Sketch" & vbNewLine & "Select Pen Size/Select Color to customize drawing" _
               & vbNewLine & "Select Draw waveforms to sketch Cosine, Sine, and Tangent Functions" _
               & vbNewLine & "Select Clear to Skake and Clear Etch-a-Sketch" & vbNewLine & "Select Exit to Close")
    End Sub
End Class
