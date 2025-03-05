Module Module1

    Class SinhVien
        Public MaSV As String
        Public TenSV As String
        Public Tuoi As Integer
        Public DiemTB As Double

        Public Sub New(ma As String, ten As String, tuoi As Integer, diem As Double)
            MaSV = ma
            TenSV = ten
            tuoi = tuoi
            DiemTB = diem
        End Sub

        Public Overrides Function ToString() As String
            Return $"Mã: {MaSV}, Tên: {TenSV}, Tuổi: {Tuoi}, Điểm TB: {DiemTB}"
        End Function
    End Class

    Sub Main()
        Dim danhSachSinhVien As New List(Of SinhVien)()

        Do
            Console.WriteLine("1. Thêm sinh viên")
            Console.WriteLine("2. Hiển thị danh sách sinh viên")
            Console.WriteLine("3. Tìm kiếm sinh viên theo mã")
            Console.WriteLine("4. Tính điểm trung bình")
            Console.WriteLine("5. Sinh viên điểm cao nhất")
            Console.WriteLine("0. Thoát")

            Dim luaChon As String = Console.ReadLine()

            Select Case luaChon
                Case "1"
                    ThemSinhVien(danhSachSinhVien)
                Case "2"
                    HienThiDanhSach(danhSachSinhVien)
                Case "3"
                    TimKiemTheoMa(danhSachSinhVien)
                Case "4"
                    TinhDiemTrungBinh(danhSachSinhVien)
                Case "5"
                    SinhVienDiemCaoNhat(danhSachSinhVien)
                Case "0"
                    Exit Do
                Case Else
                    Console.WriteLine("Lựa chọn không hợp lệ.")
            End Select

            Console.WriteLine()
        Loop
    End Sub

    Sub ThemSinhVien(ByRef danhSach As List(Of SinhVien))
        Console.Write("Mã SV: ")
        Dim ma As String = Console.ReadLine()
        Console.Write("Tên SV: ")
        Dim ten As String = Console.ReadLine()
        Console.Write("Tuổi: ")
        Dim tuoi As Integer = Integer.Parse(Console.ReadLine())
        Console.Write("Điểm TB: ")
        Dim diem As Double = Double.Parse(Console.ReadLine())

        Dim sv As New SinhVien(ma, ten, tuoi, diem)
        danhSach.Add(sv)
        Console.WriteLine("Đã thêm sinh viên.")
    End Sub

    Sub HienThiDanhSach(ByVal danhSach As List(Of SinhVien))
        If danhSach.Count = 0 Then
            Console.WriteLine("Danh sách trống.")
            Return
        End If

        For Each sv As SinhVien In danhSach
            Console.WriteLine(sv.ToString())
        Next
    End Sub

    Sub TimKiemTheoMa(ByVal danhSach As List(Of SinhVien))
        Console.Write("Nhập mã SV cần tìm: ")
        Dim maTimKiem As String = Console.ReadLine()

        Dim sinhVienTimThay As SinhVien = danhSach.Find(Function(sv) sv.MaSV = maTimKiem)

        If sinhVienTimThay Is Nothing Then
            Console.WriteLine("Không tìm thấy sinh viên.")
        Else
            Console.WriteLine(sinhVienTimThay.ToString())
        End If
    End Sub

    Sub TinhDiemTrungBinh(ByVal danhSach As List(Of SinhVien))
        If danhSach.Count = 0 Then
            Console.WriteLine("Danh sách trống.")
            Return
        End If

        Dim tongDiem As Double = 0
        For Each sv As SinhVien In danhSach
            tongDiem += sv.DiemTB
        Next

        Dim diemTB As Double = tongDiem / danhSach.Count
        Console.WriteLine($"Điểm trung bình: {diemTB}")
    End Sub

    Sub SinhVienDiemCaoNhat(ByVal danhSach As List(Of SinhVien))
        If danhSach.Count = 0 Then
            Console.WriteLine("Danh sách trống.")
            Return
        End If

        Dim sinhVienMax As SinhVien = danhSach.OrderByDescending(Function(sv) sv.DiemTB).FirstOrDefault()

        Console.WriteLine($"Sinh viên điểm cao nhất: {sinhVienMax.ToString()}")
    End Sub

End Module