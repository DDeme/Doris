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


        End
    End Sub


End Class
