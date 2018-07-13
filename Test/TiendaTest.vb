Imports RepasoFinal_Discografica
Module TiendaTest
    Sub main()
        Dim interprete1 As New Interprete(1, "GNR", 0.5)
        Dim interprete2 As New Interprete(1, "Floyd", 0.2)
        Dim cancion1 As New Cancion(1, "Patience")
        Dim cancion2 As New Cancion(2, "Hey U")
        Dim descarga1 As New Descarga(cancion1, Today, 52150300.0)
        Dim descarga2 As New Descarga(cancion2, Today, 16100200.0)
        Dim tienda1 As New Tienda
        Try
            tienda1.addDescargas(descarga1)
            tienda1.addDescargas(descarga2)
        Catch ex As Exception
            Console.WriteLine("Error inesperado!")
        End Try
        Try
            Console.WriteLine("todas las descargas: ")
            For Each desc In tienda1.getAllDescargas()
                Console.WriteLine("- ", desc)
            Next
        Catch ex As Exception
            Console.WriteLine("Error inesperado!")
        End Try
        Try
            Console.WriteLine("Traigo descarga de interprete1: ", tienda1.getDescargasByDiscografica(interprete1))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            tienda1.getDescargasByFecha(Today)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            tienda1.getDescargasByInterprete(interprete1)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
