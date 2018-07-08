Public Class Tienda
    'campo
    Private _valorDescarga As Single

    'propiedad
    Private Property ValorDescarga As Single
        Get
            Return _valorDescarga
        End Get
        Set(value As Single)
            _valorDescarga = value
        End Set
    End Property
    'metodos

End Class
