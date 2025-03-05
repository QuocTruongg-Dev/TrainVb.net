Interface Imovable
    Sub Move()
End Interface

Class Carr
    Implements Imovable
    Public Sub Move() Implements Imovable.Move
        Console.WriteLine("Xe dang di chuyen")
    End Sub
End Class

Module Interface1
    Sub Main()
        Dim mycar As New Carr()
        mycar.Move()
        Console.ReadLine()
    End Sub
End Module

