Module ImplicitConversionIntegerToShort1
    Function Main() As Integer
        Dim result As Boolean
        Dim value1 As Integer
        Dim value2 As Short
        Dim const2 As Short

        value1 = 50I
        value2 = value1
        const2 = 50I

        result = value2 = const2

        If result = False Then
            System.Console.WriteLine("FAIL ImplicitConversionIntegerToShort1")
            Return 1
        End If
    End Function
End Module
