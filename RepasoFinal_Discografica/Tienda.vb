﻿Public Class Tienda
    'campo
    Private _valorDescarga As Single
    Private _descargas As List(Of Descarga)
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
    Public Function getDescargasByDiscografica(value As Interprete) As List(Of Descarga)
        Return _descargas
    End Function
    Public Function getDescargasByFecha(value As Date) As List(Of Descarga)
        Return _descargas
    End Function
    Public Function getDescargasByInterprete(value As Interprete) As List(Of Descarga)
        Return _descargas
    End Function
    'constructor
    Sub New()
        _descargas = nEW List(Of Descarga)
    End Sub
End Class
