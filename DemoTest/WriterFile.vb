Imports System.IO

Module GhiFile
    Sub Main()
        Dim filePath As String = "D:\testVBNET.txt"

        'Ghi du lieu vao file
        Using Writer As New StreamWriter(filePath)
            Writer.WriteLine("Hello World!")
            Writer.WriteLine("Xin chao the gioi!")
        End Using

        Console.WriteLine("Ghi du lieu thanh cong!")
        Console.ReadLine()
    End Sub
End Module

'Ghi thêm dữ liệu vào cuối file
'Dim filePath As String = "D:\testVBNET.txt"

'Using writer As New StreamWriter(filePath, True)
'writer.WriteLine("Dòng này sẽ được thêm vào cuối file.")
'End Using
