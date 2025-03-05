Class Car
    Public Brand As String
    Public Model As String
    Public Year As Integer
    Public Speed As Integer = 0

    Public Sub New(brand As String, model As String, year As Integer)
        Me.Brand = brand
        Me.Model = model
        Me.Year = year
    End Sub

    Public Sub Accelerate(speedIncrease As Integer)
        Speed += speedIncrease
        Console.WriteLine("Tốc độ hiện tại: " & Speed & " km/h")
    End Sub

    Public Sub Brake(speedDecrease As Integer)
        Speed -= speedDecrease
        If Speed < 0 Then Speed = 0
        Console.WriteLine("Tốc độ sau khi phanh: " & Speed & " km/h")
    End Sub
End Class

Module Module1
    Sub Main()
        Dim myCar As New Car("Toyota", "Camry", 2022)
        myCar.Accelerate(30)
        myCar.Brake(10)
        Console.ReadLine()
    End Sub
End Module
