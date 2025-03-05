Class SinhVien
    ' Thuộc tính
    Public HoTen As String
    Public Tuoi As Integer
    Public DiemTB As Double

    ' Phương thức hiển thị thông tin
    Public Sub XuatThongTin()
        Console.WriteLine("Họ tên: " & HoTen)
        Console.WriteLine("Tuổi: " & Tuoi)
        Console.WriteLine("Điểm trung bình: " & DiemTB)
    End Sub
End Class

'Module oop
'    Sub Main()
'        ' Tạo đối tượng sinh viên
'        Dim sv As New SinhVien()
'        sv.HoTen = "Nguyễn Văn A"
'        sv.Tuoi = 20
'        sv.DiemTB = 8.5

'        ' Gọi phương thức xuất thông tin
'        sv.XuatThongTin()

'        Console.ReadLine()
'    End Sub
'End Module
