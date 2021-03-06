﻿Public MustInherit Class Entidad
    'campos
    Private _id As Integer
    Private _nombre As String

    'propiedad
    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value = Nothing Then
                Throw New ArgumentException("El nombre no debe estar vacio!")
            End If
            If value.Length < 3 Then
                Throw New ArgumentException("El nombre es muy corto!")
            End If
            _nombre = value
        End Set
    End Property
    'metodos
    Sub New(id As Integer, nombre As String)
        Me.ID = id
        Me.Nombre = nombre
    End Sub
End Class
