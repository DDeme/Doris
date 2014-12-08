


Namespace main

    Public Class doris





        Public Sub align(element As Object)
            Dim scrwidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim scrheight As Integer = Screen.PrimaryScreen.Bounds.Height
            element.location = New Point(CInt((scrwidth - element.Width) / 2), CInt((scrheight - element.Height) / 2))
        End Sub


    End Class
End Namespace
