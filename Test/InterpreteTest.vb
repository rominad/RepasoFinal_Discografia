Imports RepasoFinal_Discografica

Module InterpreteTest
    Sub Main()
        Dim Interprete1 As New Interprete(1, "Romina", 0.21)
        Try
            Dim Interprete2 As New Interprete(1, "Teo", 0.21)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.WriteLine(Interprete1.ToString())
        ' Console.WriteLine(Interprete1.TotalRegalia())
        Console.ReadKey()
    End Sub
End Module
