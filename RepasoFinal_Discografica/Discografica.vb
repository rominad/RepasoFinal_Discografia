Imports RepasoFinal_Discografica

Public Class Discografica
    'herencia
    Inherits Entidad
    'interface
    Implements Regalias
    'campo
    Private _porcentajeRegalia As Single
    'propiedad
    Public Property PorcentajeRegalia As Single Implements Regalias.PorcentajeRegalia
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Single)
            Throw New NotImplementedException()
        End Set
    End Property
    'metodo
    Public Function TotalRegalia() As Single Implements Regalias.TotalRegalia
        Throw New NotImplementedException()
    End Function
    Sub New(id As Integer, nombre As String, porcentajeRegalias As Single)
        MyBase.New(id, nombre)
        Me.PorcentajeRegalia = PorcentajeRegalia
    End Sub
    Public Overrides Function ToString() As String
        Return "Nombre: " + Nombre
    End Function

End Class
