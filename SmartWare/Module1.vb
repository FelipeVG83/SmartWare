Imports MySql.Data.MySqlClient

Module Module1
    Public Conexao As New MySqlConnection("Server=us-cdbr-azure-east-b.cloudapp.net;Database=SmartWareBD;Uid=bb042d91cc8e2a;Pwd=7215f361;")

    Public Sub AbrirBD()
        If (Conexao.State = ConnectionState.Closed) Then
            Conexao.Open()
        End If
    End Sub

    Public Sub FecharBD()
        If (Conexao.State = ConnectionState.Open) Then
            Conexao.Close()
        End If
    End Sub

    Function Horario(ByVal Hora As String)
        If (Hora < 10) Then
            Hora = "0" & Hora
        End If
        Return Hora
    End Function

    Function Min(ByVal Minuto As String)
        If (Minuto < 10) Then
            Minuto = "0" & Minuto
        End If
        Return Minuto

    End Function


    Public NomeLogin As String
    Public MenuLogado As String
    Public SenhaBloqueada As Integer
    Public NomeC As String
    Public NomeF As String
    Public NomeP As String
    Public NomeCC As String
    Public NomeSelectCompra As String
    Public Confirma As Boolean
    Public Confirmado As Boolean
    Public Idioma As String
    Public Alterar As Boolean
End Module
