﻿Public Class Form1
    Private m_Previous As System.Nullable(Of Point) = Nothing
    Dim m_shapes As New Collection
    Dim c As Color
    Dim w As Integer
<<<<<<< HEAD
    Dim type As String
=======


>>>>>>> main
    Private Sub pictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        m_Previous = e.Location
        pictureBox1_MouseMove(sender, e)
    End Sub
<<<<<<< HEAD
    Private Sub pictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If m_Previous IsNot Nothing Then
            Dim d As Object

            If Type = "Line" Then
                d = New Line(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, w)
            End If
            If type = "square1" Then
                d = New square1(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, w)
                d.w = TrackBar2.Value
                d.h = TrackBar3.Value
            End If
            If type = "poligon" Then
                d = New POLIGON(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, w)
                d.w = TrackBar2.Value
                d.h = TrackBar3.Value
            End If
            If type = "n-gon" Then
                d = New n_gon(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, w)
                d.side = TrackBar4.Value
                d.radius = TrackBar5.Value
            End If
            If type = "picture" Then
                d = New PBox(PictureBox1.Image, m_Previous, e.Location)
                d.picture = PictureBox2.Image
            End If

            m_shapes.Add(d)
=======

    Private Sub pictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If m_Previous IsNot Nothing Then
            Dim l As New Line(PictureBox1.Image, m_Previous, e.Location)
            l.Pen = New Pen(c, w)
            m_shapes.Add(l)
>>>>>>> main
            PictureBox1.Invalidate()
            m_Previous = e.Location
        End If
    End Sub

    Private Sub pictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        m_Previous = Nothing
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PictureBox1.Image Is Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            PictureBox1.Image = bmp
        End If

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
<<<<<<< HEAD
        For Each s As Object In m_shapes
=======
        For Each s As Line In m_shapes
>>>>>>> main
            s.Draw()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        Button1.BackColor = c

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = sender.backcolor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c = sender.backcolor
    End Sub

<<<<<<< HEAD
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)
        w = TrackBar2.Value
=======
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        w = TrackBar1.Value
>>>>>>> main
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c = sender.backcolor
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        c = sender.backcolor
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        c = sender.backcolor
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        c = sender.backcolor
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        c = sender.backcolor
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        c = sender.backcolor
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        c = sender.backcolor
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        c = sender.backcolor
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        c = sender.backcolor
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        c = sender.backcolor
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        c = sender.backcolor
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        c = sender.backcolor
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        c = sender.backcolor
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        c = sender.backcolor
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        c = sender.backcolor
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        c = sender.backcolor
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        c = sender.backcolor
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        c = sender.backcolor
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        c = sender.backcolor
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        c = sender.backcolor
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        c = sender.backcolor
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        c = sender.backcolor
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        SaveFileDialog1.ShowDialog()
        PictureBox1.Image.Save(SaveFileDialog1.FileName)
    End Sub
<<<<<<< HEAD

    Private Sub Button28_Click(sender As Object, e As MouseEventArgs) Handles Button28.Click
        If m_Previous IsNot Nothing Then
            Dim l As New Line(PictureBox1.Image, m_Previous, e.Location)
            l.Pen = New Pen(c, w)
            m_shapes.Add(l)
            PictureBox1.Invalidate()
            m_Previous = e.Location
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As MouseEventArgs) Handles Button29.Click
        If m_Previous IsNot Nothing Then
            Dim l As New Circle1(PictureBox1.Image, m_Previous, e.Location)
            l.Pen = New Pen(c, w)
            l.w = TrackBar2.Value
            l.h = TrackBar3.Value
            m_shapes.Add(l)
            PictureBox1.Invalidate()
            m_Previous = e.Location
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As MouseEventArgs) Handles Button30.Click
        If m_Previous IsNot Nothing Then
            Dim l As New square1(PictureBox1.Image, m_Previous, e.Location)
            l.Pen = New Pen(c, w)
            l.w = TrackBar2.Value
            l.h = TrackBar3.Value
            m_shapes.Add(l)
            PictureBox1.Invalidate()
            m_Previous = e.Location
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        type = "square1"
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        type = "poligon"
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        type = "n-gon"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        type = "picture"
    End Sub
=======
>>>>>>> main
End Class
