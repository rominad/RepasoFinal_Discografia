
Public NotInheritable Class Interprete
    'herencia
    Inherits Entidad
    'interface
    Implements Regalias
    'campo
    Private _porcentajeRegalia As Single
    'propiedad
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
        'ESTO ESTA BIEN PENSADO?? :
        'Regalias.TotalRegalias() = en la tienda traemos las descargas de un determinado interprete.
        '1)llamamos la funcion getDescargaByInterprete(interprete)
        'cada Descarga tiene tiene una cancion, fecha y monto. traemos el monto = descarga.monto
        '2)a ese monto le sumamos el valor de la descarga. monto += monto * valorDescarga
        '3)a esa sumatoria le multiplicamos el porcentajeDeRegalia.
        Throw New NotImplementedException()
    End Function
    Sub New(id As Integer, nombre As String, porcentajeRegalia As Single)
        MyBase.New(id, nombre)
        Me.Regalias_PorcentajeRegalia = _porcentajeRegalia
    End Sub
    Public Overrides Function ToString() As String
        Return "Nombre: " + Nombre
    End Function
End Class
