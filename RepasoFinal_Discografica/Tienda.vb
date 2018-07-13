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
    'Public Sub removeDescargas(_descarga As Descarga)
    '    _descargas.Remove(_descarga)
    'End Sub
    Public Function getAllDescargas() As List(Of Descarga)
        Return _descargas
    End Function
    'Public Function getDescargasByDiscografica3(value As Interprete) As List(Of Descarga)
    '    Dim lista As New List(Of Descarga)
    '    For Each discofrafica In _discograficas
    '        For Each descarga In _descargas
    '            For Each interprete In descarga.Cancion.getAllInterpretes()
    '                If interprete.Id = value.Id Then
    '                    lista.Add(descarga)
    '                End If
    '            Next
    '        Next
    '    Next
    '    Return lista
    'End Function
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
        _descargas = nEW List(Of Descarga)
    End Sub
End Class
