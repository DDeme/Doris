




Public Class main





    'zarovnáva elemnt do stredu obrazovky 
    Public Sub align(element As Object)
        Dim scrwidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim scrheight As Integer = Screen.PrimaryScreen.Bounds.Height


        element.location = New Point((scrwidth - element.Width) / 2, (scrheight - element.Height) / 2)

    End Sub


End Class
