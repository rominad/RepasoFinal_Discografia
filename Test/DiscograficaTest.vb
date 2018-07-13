Imports RepasoFinal_Discografica
Module DiscograficaTest
    Sub Main()
        Dim discografica1 As New Discografica(1, "discoMania", 0.2)
        Try
            Dim discografica2 As New Discografica(1, "discoTec", -1.2)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.WriteLine(discografica1.ToString())
        'Console.WriteLine("total Regalia: {0}", discografica1.TotalRegalia())
        Console.ReadKey()
    End Sub
End Module
