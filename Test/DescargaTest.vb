Imports RepasoFinal_Discografica

Module DescargaTest
    Sub Main()
        Dim cancion1 As New Cancion(1, "Chuchua")
        Dim Descarga1 As New Descarga(cancion1, Today, 2000.0)

        Console.WriteLine(Descarga1.ToString())
        Try
            Dim Descarga2 As New Descarga(cancion1, Today, -100.0)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
