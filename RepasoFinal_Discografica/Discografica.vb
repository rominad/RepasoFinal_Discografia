Imports RepasoFinal_Discografica

Public Class Discografica
    'herencia
    Inherits Entidad
    'interface
    Implements Regalias
    'campo
    Private _porcentajeRegalia As Single
    Private _tienda As Tienda
    Private _interprete As Interprete
    'propiedad
    Public Property PorcentajeRegalia As Single Implements Regalias.PorcentajeRegalia
        Get
            Return _porcentajeRegalia
        End Get
        Set(value As Single)
            If value <= 0 Then
                Throw New ArgumentException("El valor de porcentaje regalias no debe ser negativo!")
            End If
            _porcentajeRegalia = value
        End Set
    End Property
    'metodo
    Public Function TotalRegalia() As Single Implements Regalias.TotalRegalia
        'ESTO ESTA BIEN PENSADO?? :
        'Regalias.TotalRegalias() = en la tienda traemos las descargas de un determinado interprete.
        '1)llamamos la funcion getDescargaByInterprete(interprete),donde 
        'cada Descarga tiene tiene una cancion, fecha y monto.
        '2)traemos el monto(descarga.monto) y le multiplicamos el valor de la descarga(tienda.valorDescarga)
        '3)a esa sumatoria le multiplicamos el porcentajeDeRegalia.
        Dim total As New Single
        Console.WriteLine("_getDescargasByInterprete = {0}", _tienda.getDescargasByInterprete(_interprete).Count)
        For Each descarga In _tienda.getDescargasByInterprete(_interprete)
            total += (descarga.Monto * _tienda.ValorDescarga) * PorcentajeRegalia
            Console.WriteLine("descarga = {0}", descarga)
            Console.WriteLine("descarga.Monto = {0}", descarga.Monto)
            Console.WriteLine("_tienda.ValorDescarg = {0}", _tienda.ValorDescarga)
            Console.WriteLine("PorcentajeRegalia = {0}", PorcentajeRegalia)
            Console.WriteLine("total = {0}", total)
        Next
        Return total
    End Function
    Sub New(id As Integer, nombre As String, porcentajeRegalias As Single)
        MyBase.New(id, nombre)
        Me.PorcentajeRegalia = porcentajeRegalias
        _tienda = New Tienda
        _interprete = New Interprete(id, nombre, PorcentajeRegalia)
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre
    End Function

End Class
