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
        'ESTO ESTA BIEN PENSADO?? :
        'Regalias.TotalRegalias() = en la tienda traemos las descargas de un determinado interprete.
        '1)llamamos la funcion getDescargaByDiscografica(interprete)
        'cada Descarga tiene tiene una cancion, fecha y monto. traemos el monto = descarga.monto
        '2)a ese monto le sumamos el valor de la descarga. monto += monto * valorDescarga
        '3)a esa sumatoria le multiplicamos el porcentajeDeRegalia.
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
