
Imports WindowsApplication1.main
Imports WindowsApplication1.main.doris


Public Class homescreen


    'Inherits Windows.Forms.Form

    'Private Sub DrawformGradient(ByVal TopColor As Color, ByVal BottomColor As Color)

    '    Dim objBrush As New Drawing2D.LinearGradientBrush(Me.DisplayRectangle, TopColor, BottomColor, Drawing2D.LinearGradientMode.Vertical)

    '    Dim objGraphics As Graphics = Me.CreateGraphics()

    '    objGraphics.FillRectangle(objBrush, Me.DisplayRectangle)
    '    objBrush.Dispose()

    '    objGraphics.Dispose()

    'End Sub

    'Private Sub homescreen_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    '    DrawformGradient(Color.FromArgb(221, 94, 137), Color.FromArgb(247, 187, 151))

    'End Sub





    'načítanie formulára s úvodnou obrazovkou 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Me.Visible = False



        Me.WindowState = FormWindowState.Maximized
        align(Panel1)





        Me.Visible = True


    End Sub



    ' otvára single player htu 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        'Dim newWindow As New singleplayer()
        Dim newWindow As New TetrisGame()
        newWindow.ShowDialog()
    End Sub



    ' otvára multiplayer hru 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Dim newWindow As New multiplayer()
        newWindow.ShowDialog()

    End Sub



    ' tlacidlo ukoncenia hry 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' are you sure to quit 


        ' Now define a style for the message box. In this example, the 
        ' message box will have Yes and No buttons, the default will be 
        ' the No button, and a Critical Message icon will be present. 
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or _
                    MsgBoxStyle.MsgBoxSetForeground

        ' Display the message box and save the response, Yes or No. 
        Dim response = MsgBox("Are you sure to quit ?", style, "")

        ' Take some action based on the response. 
        If response = MsgBoxResult.Yes Then
            End
        End If

    End Sub




    'Fade in
    Public Sub fade_in()
        For FadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = FadeIn
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    'zarovnáva elemnt do stredu obrazovky 
    Public Sub align(element As Object)
        Dim scrwidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim scrheight As Integer = Screen.PrimaryScreen.Bounds.Height


        element.location = New Point((scrwidth - element.Width) / 2, (scrheight - element.Height) / 2)

    End Sub




End Class
