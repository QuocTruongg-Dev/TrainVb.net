Public Class test1
    Sub Main()
        Dim songuyen As Integer
        Console.Write("Nhập số nguyên: ")
        songuyen = Convert.ToInt32(Console.ReadLine())

        If songuyen = 0 Then
            Console.WriteLine("Số nguyên " & songuyen & " là số bang 0")
        ElseIf songuyen > 0 Then
            Console.WriteLine("Số nguyên " & songuyen & " là số duong ")
        Else
            Console.WriteLine("Số nguyên " & songuyen & " là số âm")
        End If

        Console.ReadLine()
    End Sub

End Class
