
Public NotInheritable Class Interprete
    'herencia
    Inherits Entidad
    'interface
    Implements Regalias
    'campo
    Private _porcentajeRegalia As Single
    'propiedad
    Private Property PorcentajeRegalia As Single
        Get
            Return _porcentajeRegalia
        End Get
        Set(value As Single)
            _porcentajeRegalia = value
        End Set
    End Property

    Private Property Regalias_PorcentajeRegalia As Single Implements Regalias.PorcentajeRegalia
        Get
            Return _porcentajeRegalia
        End Get
        Set(value As Single)
            _porcentajeRegalia = value
        End Set
    End Property
    'metodos
    Public Function TotalRegalia() As Single Implements Regalias.TotalRegalia
        Throw New NotImplementedException()
    End Function
    Sub New(id As Integer, nombre As String, porcentajeRegalia As Single)
        MyBase.New(id, nombre)
        Me.PorcentajeRegalia = _porcentajeRegalia
    End Sub
    Public Overrides Function ToString() As String
        Return "Nombre: " + Nombre
    End Function
End Class
