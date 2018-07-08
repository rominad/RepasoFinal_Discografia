﻿Public Class Descarga
    Private _fecha As Date
    Private _monto As Single
    Private _cancion As Cancion
    Private Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Private Property Monto As Single
        Get
            Return _monto
        End Get
        Set(value As Single)
            _monto = value
        End Set
    End Property
    Private Property Cancion As Cancion
        Get
            Return _cancion
        End Get
        Set(value As Cancion)
            _cancion = value
        End Set
    End Property
    Sub New(cancion As Cancion, fecha As Date, monto As Single)
        Me.Cancion = cancion
        Me.Fecha = fecha
        Me.Monto = monto
    End Sub
    Public Overrides Function ToString() As String
        Return "Descarga: " + Cancion.Nombre + " - " + Fecha
    End Function
End Class
