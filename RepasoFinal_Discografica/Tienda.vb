Public Class Tienda
    'campo
    Private _valorDescarga As Single
    Private _descargas As List(Of Descarga)
    Private _discograficas As List(Of Discografica)
    Private _interpretes As List(Of Interprete)
    'propiedad
    Public Property ValorDescarga As Single
        Get
            Return _valorDescarga
        End Get
        Set(value As Single)
            _valorDescarga = value
        End Set
    End Property
    'metodos
    Public Sub addDescargas(value As Descarga)
        _descargas.Add(value)
    End Sub
    Public Function getAllDescargas() As List(Of Descarga)
        Return _descargas
    End Function
    Public Function getDescargasByDiscografica(value As Discografica) As List(Of Descarga)
        Dim lista As New List(Of Descarga)
        'le tiro la discografica y tiene que devolverme las descargas que tenga esa discografica

        For Each descarga In _descargas
            If descarga.Cancion.Discografica.PorcentajeRegalia = value.PorcentajeRegalia Then
                lista.Add(descarga)
            End If
        Next
        Return lista
    End Function
    Public Function getDescargasByFecha(value As Date) As List(Of Descarga)
        Dim lista As New List(Of Descarga)
        For Each elemento In _descargas
            If elemento.Fecha = value Then
                lista.Add(elemento)
            End If
        Next
        Return lista
    End Function
    Public Function getDescargasByInterprete(value As Interprete) As List(Of Descarga)
        Dim lista As New List(Of Descarga)
        For Each descarga In _descargas
            For Each interprete In descarga.Cancion.getAllInterpretes()
                If interprete.Id = value.Id Then
                    lista.Add(descarga)
                End If
            Next
        Next
        Return lista
    End Function
    'constructor
    Sub New()
        _valorDescarga = New Single
        _descargas = New List(Of Descarga)
        _discograficas = New List(Of Discografica)
        _interpretes = New List(Of Interprete)
    End Sub
End Class
