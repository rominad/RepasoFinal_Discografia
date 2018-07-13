Imports RepasoFinal_Discografica
Module CancionTest
    Sub Main()
        Dim interprete1 As New Interprete(1, "Pinion", 0.5)
        Dim interprete2 As New Interprete(2, "Xuxa", 0.01)
        Dim interprete3 As New Interprete(2, "Bisbal", 0.1)

        Dim cancion1 As New Cancion(1, "Chuchua")

        Try
            cancion1.addInterpretes(interprete1)
            cancion1.addInterpretes(interprete2)
            cancion1.addInterpretes(interprete3)
        Catch ex As Exception
            Console.WriteLine("Error inesperado!")
        End Try
        Try
            Console.WriteLine("Listado de Interpretes:")
            For Each interpretes In cancion1.getAllInterpretes()
                Console.WriteLine("- {0}", interpretes.Nombre)
            Next
        Catch ex As Exception
            Console.WriteLine("Error inesperado!")
        End Try
        Try
            cancion1.removeInterpretes(interprete3)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Console.WriteLine("Listado de Interpretes con remove:")
            For Each cantante In cancion1.getAllInterpretes()
                Console.WriteLine("- {0}", cantante)
            Next
        Catch ex As Exception
            Console.WriteLine("Error inesperado!")
        End Try
        Try
            Console.WriteLine(cancion1.ToString())
        Catch ex As Exception
            Console.WriteLine("Error inesperado!")
        End Try
        Console.ReadKey()
    End Sub
End Module
