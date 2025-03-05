Class HinhTron
    Public BanKinh As Double

    ' Phương thức tính chu vi
    Public Function TinhChuVi() As Double
        Return 2 * Math.PI * BanKinh
    End Function

    ' Phương thức tính diện tích
    Public Function TinhDienTich() As Double
        Return Math.PI * BanKinh * BanKinh
    End Function
End Class

Module HinhTronn
    Sub Main()
        ' Nhập bán kính
        Dim hinh As New HinhTron()
        Console.Write("Nhập bán kính hình tròn: ")
        hinh.BanKinh = Convert.ToDouble(Console.ReadLine())

        ' Hiển thị kết quả
        Console.WriteLine("Chu vi: " & hinh.TinhChuVi())
        Console.WriteLine("Diện tích: " & hinh.TinhDienTich())

        Console.ReadLine()
    End Sub
End Module
