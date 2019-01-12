Imports System
Module Module1

    Sub Main()
        Dim base64Encoded As String = "YmFzZTY0IGVuY29kZWQgc3RyaW5n"
        Dim base64Decoded As String
        Dim data() As Byte = System.Convert.FromBase64String(base64Encoded)
        base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data)

        Console.Read()
    End Sub

End Module
