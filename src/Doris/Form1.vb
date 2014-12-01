Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Me.Visible = False


        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized


        ' Dim s = New SplashScreen1()
        's.Show()
        'Do processing here or thread.sleep to illustrate the concept
        'System.Threading.Thread.Sleep(5000)
        's.Close()

        Me.Visible = True






        
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub



    ' exit tlacidlo 
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


End Class
