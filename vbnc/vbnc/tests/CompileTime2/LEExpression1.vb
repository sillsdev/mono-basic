Imports System
Imports System.Collections
Imports System.Reflection

Namespace LEExpression1
    Class Test
        Shared Function Main() As Integer
            Dim i, j As Integer
            Dim k As Integer
            i = 3
            j = 2
            If i <= j Then
                k = 10
            Else
                k = 20
            End If
            Return k - 20
        End Function
    End Class
End Namespace