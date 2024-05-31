Imports System.Drawing.Drawing2D
Class CirclePicturBox
    Inherits PictureBox

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        Dim graph As GraphicsPath = New GraphicsPath
        graph.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(graph)
        MyBase.OnPaint(pe)
    End Sub

End Class
