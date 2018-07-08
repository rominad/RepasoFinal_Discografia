Imports RepasoFinal_Discografica
Module TiendaTest
    Sub main()
        Dim interprete1 As New Interprete(1, "xyxa", 0.5)
        Dim interprete2 As New Interprete(1, "Mana", 0.2)
        Dim cancion1 As New Cancion(1, "xyxa")
        Dim cancion2 As New Cancion(2, "MAna")
        Dim descarga1 As New Descarga(cancion1, Today, 100.0)
        Dim descarga2 As New Descarga(cancion2, Today, 200.0)
        Dim tienda1 As New Tienda

        tienda1.getAllDescargas()
        tienda1.getDescargasByDiscografica(interprete1)
        tienda1.getDescargasByFecha(Today)
        tienda1.getDescargasByInterprete(interprete1)
    End Sub
End Module
