Imports System.IO
Module ReadFile
    Sub Main()
        Dim filePath As String = "D:\testVBNET.txt"
        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                Dim content As String = reader.ReadToEnd()
                Console.WriteLine("Noi dung File :" & content)
            End Using
        Else
            Console.WriteLine("File khong ton tai")
        End If

        Console.ReadLine()
    End Sub
End Module