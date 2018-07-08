Imports RepasoFinal_Discografica

Module DescargaTest
    Sub Main()
        Dim cancion1 As New Cancion(1, "Chuchua")
        Dim Descarga1 As New Descarga(cancion1, Today, 100.0)
        Console.WriteLine(Descarga1.ToString())
        Console.ReadKey()
    End Sub
End Module
