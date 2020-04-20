Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim comando As New MySqlCommand("select Senha_Funcionario, Nome_Funcionario, Login_Bloqueado_Funcionario from Funcionarios where Login_Funcionario = @Login_Funcionario", Conexao)
        AbrirBD()
        comando.Parameters.Add("@Login_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Login_Funcionario").Value = Txt_Login.Text
        Dim dr As MySqlDataReader
        dr = comando.ExecuteReader
        If dr.Read Then
            If (dr("Login_Bloqueado_Funcionario") = "Bloqueado") Then
                TxT_senha.ReadOnly = True
                TxT_senha.Enabled = False
                LBL_UsuarioBloqueado.Visible = True
            Else
                If dr("Senha_Funcionario") = TxT_senha.Text Then
                    NomeLogin = dr("Nome_Funcionario")
                    Txt_Login.Clear()
                    TxT_senha.Clear()
                    TxT_senha.BackColor = Txt_Login.BackColor
                    Menu2.Show()
                    Me.Hide()
                    dr.Close()
                    FecharBD()

                Else
                    dr.Close()
                    FecharBD()
                    LBL_SenhaIncorreta.Visible = True
                    SenhaBloqueada = SenhaBloqueada + 1
                    TxT_senha.Clear()
                    TxT_senha.Focus()
                    TxT_senha.BackColor = Color.Red
                    If (SenhaBloqueada = 3) Then
                        LBL_SenhaIncorreta.Visible = False
                        Dim comando2 As New MySqlCommand("Update Funcionarios set Login_Bloqueado_Funcionario=@Login_Bloqueado_Funcionario where Login_Funcionario=@Login_Funcionario", Conexao)
                        AbrirBD()
                        comando2.Parameters.Add("@Login_Bloqueado_Funcionario", MySqlDbType.VarChar)
                        comando2.Parameters("@Login_Bloqueado_Funcionario").Value = "Bloqueado"

                        comando2.Parameters.Add("@Login_Funcionario", MySqlDbType.VarChar)
                        comando2.Parameters("@Login_Funcionario").Value = Txt_Login.Text

                        Try
                            comando2.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        Finally
                            FecharBD()
                        End Try
                        MessageBox.Show("Você excedeu o número de tentativas de senha, e seu usuário foi bloqueado! Para desbloqueá-lo, informe o seu gerente.", "Usuário Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                End If
            End If
        Else
            LBL_UsuarioIncorreto.Visible = True

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Cadastro_Funcionario.Show()
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Informe seu Gerente para que ele possa restaurar seu Usuário.", "Esqueceu o Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Localizar_Clientes.Show()
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs)
        Localizar_Clientes.Show()
    End Sub

    Private Sub Txt_Login_LostFocus(sender As Object, e As EventArgs) Handles Txt_Login.LostFocus
        Dim comando As New MySqlCommand("select Login_Bloqueado_Funcionario from Funcionarios where Login_Funcionario = @Login_Funcionario", Conexao)
        AbrirBD()
        comando.Parameters.Add("@Login_Funcionario", MySqlDbType.VarChar)
        comando.Parameters("@Login_Funcionario").Value = Txt_Login.Text
        Dim dr As MySqlDataReader
        dr = comando.ExecuteReader
        If dr.Read Then
            If dr("Login_Bloqueado_Funcionario") = "Bloqueado" Then
                TxT_senha.ReadOnly = True
                TxT_senha.Enabled = False
                LBL_UsuarioBloqueado.Visible = True
            Else
                TxT_senha.ReadOnly = False
                TxT_senha.Enabled = True
                LBL_UsuarioBloqueado.Visible = False
            End If
        End If
        dr.Close()
        FecharBD()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MessageBox.Show("Informe seu Gerente para que ele possa restaurar sua Senha.", "Esqueceu a Senha", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Cadastro_Cliente.Close()
        Cadastro_Funcionario.Close()
        Cadastro_Produto.Close()
        Comprar.Close()
        Confirmar_Cliente.Close()
        Localizar_Cliente.Close()
        Localizar_Clientes.Close()
        Localizar_Compra2.Close()
        Localizar_Compras.Close()
        Localizar_Funcionario.Close()
        Localizar_Funcionarios.Close()
        Localizar_Produto.Close()
        Localizar_Produtos.Close()
        Menu2.Close()
        Orcamento.Close()
        Orcamento_VB.Close()
    End Sub

End Class
