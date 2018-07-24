Public Class Cancion
    Inherits Entidad
    'campos
    Private _interpretes As List(Of Interprete)
    Private _interprete As Interprete
    Private _discografica As Discografica
    'propiedad
    Public Property Discografica As Discografica
        Get
            Return _discografica
        End Get
        Set(value As Discografica)
            _discografica = value
        End Set
    End Property
    'metodos
    Public Sub addInterpretes(_interprete As Interprete)
        _interpretes.Add(_interprete)
    End Sub
    Public Sub removeInterpretes(interprete As Interprete)
        _interpretes.Remove(interprete)
    End Sub
    Public Function getAllInterpretes() As List(Of Interprete)
        Return _interpretes
    End Function
    'constructor
    Sub New(id As Integer, nombre As String)
        MyBase.New(id, nombre)
        _interpretes = New List(Of Interprete)
    End Sub
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class