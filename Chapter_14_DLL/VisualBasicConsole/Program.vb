Imports CarLibrary

Module Program
    Sub Main(args As String())
        Console.WriteLine("���������� ���������� ���������� �� ����� C#")
        Dim miniVan As New MiniVan()
        miniVan.TurboBoost()

        Dim sportCar As New SportCar()
        sportCar.TurboBoost()
    End Sub
End Module
