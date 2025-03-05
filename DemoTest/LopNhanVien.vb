Class NhanVien
    Public MaNV As String
    Public HoTen As String
    Public LuongCoBan As Double
    Public HeSoLuong As Double

    ' Phương thức tính lương
    Public Function TinhLuong() As Double
        Return LuongCoBan * HeSoLuong
    End Function
End Class

Module LopNhanVien
    Sub Main()
        ' Nhập thông tin nhân viên
        Dim nv As New NhanVien()
        Console.Write("Nhập mã nhân viên: ")
        nv.MaNV = Console.ReadLine()
        Console.Write("Nhập họ tên nhân viên: ")
        nv.HoTen = Console.ReadLine()
        Console.Write("Nhập lương cơ bản: ")
        nv.LuongCoBan = Convert.ToDouble(Console.ReadLine())
        Console.Write("Nhập hệ số lương: ")
        nv.HeSoLuong = Convert.ToDouble(Console.ReadLine())

        ' Xuất thông tin và lương
        Console.WriteLine(vbCrLf & "===== Thông tin nhân viên =====")
        Console.WriteLine("Mã NV: " & nv.MaNV)
        Console.WriteLine("Họ tên: " & nv.HoTen)
        Console.WriteLine("Lương: " & nv.TinhLuong())

        Console.ReadLine()
    End Sub
End Module
