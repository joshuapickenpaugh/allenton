Public Class WaterCalculator

    Private _decCurrentReading As Decimal
    Private _decPreviousReading As Decimal
    Private _decGallonsUsed As Decimal
    Private _decTotalCharged As Decimal
    Public Const FLAT_FEE As Decimal = 16.67
    Public Const PRICE_PER_1K_GALLONS As Decimal = 1.75

    Public Property CurrentReading As Decimal
        Get
            Return _decCurrentReading
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _decCurrentReading = value
            Else
                _decCurrentReading = 0
            End If
        End Set
    End Property

    Public Property PreviousReading As Decimal
        Get
            Return _decPreviousReading
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _decPreviousReading = value
            Else
                _decPreviousReading = 0
            End If

        End Set
    End Property

    Public Property GallonsUsed As Decimal
        Get
            Return _decGallonsUsed
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _decGallonsUsed = value
            Else
                _decGallonsUsed = 0
            End If
        End Set
    End Property

    Public Property TotalCharged As Decimal
        Get
            Return _decTotalCharged
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _decTotalCharged = value
            Else
                _decTotalCharged = 0
            End If
        End Set
    End Property

    Public Sub New()

        _decCurrentReading = 0.0
        _decPreviousReading = 0.0
        _decGallonsUsed = 0.0
        _decTotalCharged = 0.0

    End Sub

    Public Function GetGallonsUsed() As Decimal

        Dim ttl As Decimal

        ttl = CurrentReading - PreviousReading

        Return ttl

    End Function

    Public Function GetTotalCharge() As Decimal

        Dim ttl As Decimal

        ttl = GetGallonsUsed()
        ttl = (ttl * PRICE_PER_1K_GALLONS) + FLAT_FEE

        Return ttl

    End Function

End Class
