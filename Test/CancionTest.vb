Imports RepasoFinal_Discografica
Module CancionTest
    Sub Main()
        Dim interprete1 As New Interprete(1, "Pinion", 0.5)
        Dim interprete2 As New Interprete(2, "Xuxa", 0.01)
        Dim interprete3 As New Interprete(2, "Bisbal", 0.1)

        Dim cancion1 As New Cancion(1, "Chuchua")

        cancion1.addInterpretes(interprete1)
        cancion1.addInterpretes(interprete2)
        Cancion1.addInterpretes(interprete3)

        Console.WriteLine("Listado de Interpretes:")
        For Each interpretes In cancion1.getAllInterpretes()
            Console.WriteLine("- {0}", interpretes.Nombre)
        Next
        cancion1.removeInterpretes(interprete3)
        Console.WriteLine("Listado de Interpretes con remove:")
        For Each cantante In Cancion1.getAllInterpretes()
            Console.WriteLine("- {0}", cantante)
        Next

        Console.WriteLine(cancion1.ToString())
        Console.WriteLine()
        Console.ReadKey()
    End Sub
End Module
