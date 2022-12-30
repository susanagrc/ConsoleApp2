Imports System.Text.RegularExpressions

Module Module1

    Sub Main()

        Dim listaEnderecos As New List(Of String)
        listaEnderecos.Add("Miritiba 339")
        listaEnderecos.Add("Babaçu 500")
        listaEnderecos.Add("Cambuí 804B")
        listaEnderecos.Add("Rio Branco 23")
        listaEnderecos.Add("Quirino dos Santos 23 b")
        listaEnderecos.Add("4, Rue de la République")
        listaEnderecos.Add("100 Broadway Av")
        listaEnderecos.Add("Calle Sagasta, 26")
        listaEnderecos.Add("Calle 44 No 1991")

        Dim enderecosEstruturados As New List(Of String())

        For Each endereco As String In listaEnderecos
            Dim rua As String = ""
            Dim numero As String = ""

            For Each palavra As String In Regex.Split(endereco, "\W+")
                If Regex.Match(palavra, "\d+").Success OrElse palavra.Contains("No") OrElse palavra.Count = 1 Then
                    numero &= palavra
                Else
                    rua &= palavra & " "
                End If
            Next

            enderecosEstruturados.Add({rua.Substring(0, rua.Count - 1), numero})
        Next

        For Each endereco As Array In enderecosEstruturados
            Console.WriteLine("Rua: """ & endereco(0) & """ Número: """ & endereco(1) & """")
        Next

        Dim Pause As String = ""

    End Sub

End Module