Imports System
Imports System.IO
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = "C:\Temp\rockyou.txt"

        For Each Zeile As String In System.IO.File.ReadAllLines(path)

            Dim unused = Zeile.Length
            If unused = 96 Then
                TextBox1.AppendText(Zeile & vbCrLf & vbCrLf)
            Else

            End If

        Next

        MsgBox("Fertig")
    End Sub
End Class