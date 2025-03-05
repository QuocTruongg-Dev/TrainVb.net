Class Animal
    Public Overridable Sub Speak() 'phai co tu khoa Overridable ở class cha mới ghì đè được
        Console.WriteLine("Animal phat ra am thanh")
    End Sub
End Class

Class Dog
    Inherits Animal
    Public Overrides Sub Speak()
        Console.WriteLine("Gau gau")
    End Sub
End Class

'Module kethua
'    Sub Main()
'        Dim animal As New Animal()
'        animal.Speak()
'        Dim dog As New Dog()
'        dog.Speak()
'        Console.ReadLine()
'    End Sub
'End Module