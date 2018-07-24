Imports RepasoFinal_Discografica
Module DiscograficaTest
    Sub Main()
        Try
            Dim discografica1 As New Discografica(1, "discoMania", 0.2)
            Console.WriteLine(discografica1.ToString())

        Catch ex As Exception
            Console.WriteLine("Error inesperado!")
        End Try
        Try
            Dim discografica2 As New Discografica(1, "discoTec", -1.2)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
