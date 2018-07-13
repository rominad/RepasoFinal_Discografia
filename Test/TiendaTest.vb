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
            cancion1.addInterpretes(interprete1)
            cancion1.addInterpretes(interprete2)
        Catch ex As Exception
            Console.WriteLine("Error inesperado!no se pudo agregar interpretes a la lista de Canciones!")
        End Try
        Try
            tienda1.addDescargas(descarga1)
            tienda1.addDescargas(descarga2)
        Catch ex As Exception
            Console.WriteLine("Error inesperado!no se pudo agregar descargas a la tienda!")
        End Try
        Try
            Console.WriteLine(vbNewLine & "todas las descargas: ")
            For Each desc In tienda1.getAllDescargas()
                Console.WriteLine("- ", desc)
            Next
        Catch ex As Exception
            Console.WriteLine("Error inesperado!No se pudo mostrar todas las descargas!")
        End Try
        'Try
        '    tienda1.getDescargasByDiscografica(interprete1))
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try
        'Try
        '    Console.WriteLine(vbNewLine & "Traigo descargas por interprete en discografica: ")
        '    For Each descDI In tienda1.getDescargasByDiscografica(interprete1)
        '        Console.WriteLine("- {0}", descDI)
        '    Next
        'Catch ex As Exception
        '    Console.WriteLine("Error inesperado!no se pudo ver descargas por fechas")
        'End Try
        Try
            tienda1.getDescargasByFecha(Today)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Console.WriteLine(vbNewLine & "Traigo descargas por fecha: ")
            For Each desc In tienda1.getDescargasByFecha(Today)
                Console.WriteLine("- {0}", desc)
            Next
        Catch ex As Exception
            Console.WriteLine("Error inesperado!no se pudo ver descargas por fechas")
        End Try
        Try
            tienda1.getDescargasByInterprete(interprete1)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Console.WriteLine(vbNewLine & "Traigo descargas por interprete: ")
            For Each Interprete In tienda1.getDescargasByInterprete(interprete1)
                Console.WriteLine("- {0}", Interprete)
            Next
        Catch ex As Exception
            Console.WriteLine("Error inesperado!no se pudo ver descargas por interpretes")
        End Try
        Console.ReadKey()
    End Sub
End Module
