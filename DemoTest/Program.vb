Module Program
    Sub Main()
        ' Khai báo biến
        Dim ten As String
        Dim tuoi As Integer
        Dim chieuCao As Double

        ' Nhập dữ liệu từ bàn phím
        Console.Write("Nhập tên của bạn: ")
        ten = Console.ReadLine()

        Console.Write("Nhập tuổi của bạn: ")
        tuoi = Convert.ToInt32(Console.ReadLine())

        Console.Write("Nhập chiều cao của bạn (mét): ")
        chieuCao = Convert.ToDouble(Console.ReadLine())

        ' Xuất thông tin ra màn hình
        Console.WriteLine(vbCrLf & "===== Thông tin cá nhân =====")
        Console.WriteLine("Họ và tên: " & ten)
        Console.WriteLine("Tuổi: " & tuoi)
        Console.WriteLine("Chiều cao: " & chieuCao & " mét")

        ' Dừng màn hình để xem kết quả
        Console.ReadLine()
    End Sub
End Module
