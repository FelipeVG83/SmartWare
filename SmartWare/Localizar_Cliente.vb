Imports MySql.Data.MySqlClient

Public Class Localizar_Cliente
    Dim Nome, CPF, Email, Nascimento, Telefone, TelefoneCom, Celular, CEP, Endereco, NEndereco, Bairro, Cidade, UF, Banco, Agencia, Conta, Infos As String

    Private Sub Localizar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)

        'Dim comando As New MySqlCommand("select * from Clientes where Nome_Cliente = @Nome_Cliente", Conexao)
        'AbrirBD()
        'If (Confirma = True) Then
        '    comando.Parameters.Add("@Nome_Cliente", MySqlDbType.VarChar)
        '    comando.Parameters("@Nome_Cliente").Value = NomeCC
        'Else
        '    comando.Parameters.Add("@Nome_Cliente", MySqlDbType.VarChar)
        '    comando.Parameters("@Nome_Cliente").Value = NomeC
        'End If
        'Dim dr As MySqlDataReader
        'dr = comando.ExecuteReader
        'While dr.Read
        '    TXT_Nome.Text = dr("Nome_Cliente")
        '    TXT_CPF.Text = dr("CPF_Cliente")
        '    TXT_Email.Text = dr("Email_Cliente")
        '    TXT_Nascimento.Text = dr("Data_Nasc_Cliente")
        '    TXT_Telefone.Text = dr("Telefone_Cliente")
        '    TXT_TelefoneComercial.Text = dr("Telefone_Com_Cliente")
        '    TXT_Celular.Text = dr("Celular_Cliente")
        '    TXT_CEP.Text = dr("CEP_Cliente")
        '    TXT_Endereco.Text = dr("Endereco_Cliente")
        '    TXT_N_Endereco.Text = dr("N_Endereco_Cliente")
        '    TXT_Bairro.Text = dr("Bairro_Cliente")
        '    TXT_Cidade.Text = dr("Cidade_Cliente")
        '    TXT_UF.Text = dr("UF_Cliente")
        '    CMB_Banco.SelectedItem = dr("Banco_Cliente")
        '    TXT_Agencia.Text = dr("Agencia_Cliente")
        '    TXT_Conta.Text = dr("Conta_Cliente")
        '    LBL_Status.Text = dr("Status_Cliente")
        '    TXT_InfoAdicionais.Text = dr("Infos_Adic_Cliente")

        '    Nome = dr("Nome_Cliente")
        '    CPF = dr("CPF_Cliente")
        '    Email = dr("Email_Cliente")
        '    Nascimento = dr("Data_Nasc_Cliente")
        '    Telefone = dr("Telefone_Cliente")
        '    TelefoneCom = dr("Telefone_Com_Cliente")
        '    Celular = dr("Celular_Cliente")
        '    CEP = dr("CEP_Cliente")
        '    Endereco = dr("Endereco_Cliente")
        '    NEndereco = dr("N_Endereco_Cliente")
        '    Bairro = dr("Bairro_Cliente")
        '    Cidade = dr("Cidade_Cliente")
        '    UF = dr("UF_Cliente")
        '    Banco = dr("Banco_Cliente")
        '    Agencia = dr("Agencia_Cliente")
        '    Conta = dr("Conta_Cliente")
        '    Infos = dr("Infos_Adic_Cliente")
        'End While
        'FecharBD()
        'dr.Close()
        'If (LBL_Status.Text = "Inativo") Then
        '    BTN_Excluir.Text = "Ativar Cliente"
        'Else
        '    BTN_Excluir.Text = "Excluir Cliente"
        'End If
        'If (Alterar = True) Then
        '    TXT_Nome.ReadOnly = False
        '    TXT_CPF.ReadOnly = False
        '    TXT_Email.ReadOnly = False
        '    TXT_Nascimento.ReadOnly = False
        '    TXT_Telefone.ReadOnly = False
        '    TXT_Celular.ReadOnly = False
        '    TXT_TelefoneComercial.ReadOnly = False
        '    TXT_Agencia.ReadOnly = False
        '    TXT_Conta.ReadOnly = False
        '    TXT_CEP.ReadOnly = False
        '    TXT_Endereco.ReadOnly = False
        '    TXT_N_Endereco.ReadOnly = False
        '    TXT_Bairro.ReadOnly = False
        '    TXT_Cidade.ReadOnly = False
        '    TXT_UF.ReadOnly = False
        '    TXT_Agencia.ReadOnly = False
        '    TXT_Conta.ReadOnly = False
        '    TXT_InfoAdicionais.ReadOnly = False
        '    BTN_Alterar.Visible = True
        '    BTN_AlterarCadastro.Visible = False

        '    If (LBL_Status.Text = "Inativo") Then
        '        BTN_Excluir.Text = "Ativar Cliente"
        '    Else
        '        BTN_Excluir.Text = "Excluir Cliente"
        '    End If
        '    Alterar = False
        'End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTN_AlterarCadastro.Click
        Alterar = True
        TXT_Nome.ReadOnly = False
        TXT_CPF.ReadOnly = False
        TXT_Email.ReadOnly = False
        TXT_Nascimento.ReadOnly = False
        TXT_Telefone.ReadOnly = False
        TXT_Celular.ReadOnly = False
        TXT_TelefoneComercial.ReadOnly = False
        TXT_Agencia.ReadOnly = False
        TXT_Conta.ReadOnly = False
        TXT_CEP.ReadOnly = False
        TXT_Endereco.ReadOnly = False
        TXT_N_Endereco.ReadOnly = False
        TXT_Bairro.ReadOnly = False
        TXT_Cidade.ReadOnly = False
        TXT_UF.ReadOnly = False
        TXT_Agencia.ReadOnly = False
        TXT_Conta.ReadOnly = False
        TXT_InfoAdicionais.ReadOnly = False
        BTN_Alterar.Visible = True
        BTN_AlterarCadastro.Visible = False
        
        If (LBL_Status.Text = "Inativo") Then
            BTN_Excluir.Text = "Ativar Cliente"
        Else
            BTN_Excluir.Text = "Excluir Cliente"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BTN_Excluir.Click
        If (LBL_Status.Text = "Ativo") Then
            If (MessageBox.Show("Deseja mesmo desligar o cliente da nossa empresa", "Exluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                Dim comando As New MySqlCommand("Update Clientes set Status_Cliente=@Status_Cliente where Nome_Cliente=@Nome_Cliente", Conexao)
                AbrirBD()

                comando.Parameters.Add("@Nome_Cliente", MySqlDbType.VarChar)
                comando.Parameters("@nome_cliente").Value = TXT_Nome.Text

                comando.Parameters.Add("@Status_Cliente", MySqlDbType.VarChar)
                comando.Parameters("@Status_Cliente").Value = "Inativo"

                Try
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Desligamento do Cliente elaborado com sucesso!", "Exluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LBL_Status.Text = "Inativo"
                    BTN_Excluir.Text = "Incluir Cliente"
                Catch ex As Exception
                    MessageBox.Show("Erro ao desligar o Cliente da empresa! Tente novamente!", "Excluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    FecharBD()
                End Try
            End If
        Else
            If (MessageBox.Show("Deseja mesmo incluir esse cliente na nossa empresa?", "Incluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                Dim comando As New MySqlCommand("Update Clientes set Status_Cliente=@Status_Cliente where Nome_Cliente=@Nome_Cliente", Conexao)
                AbrirBD()

                comando.Parameters.Add("@Nome_Cliente", MySqlDbType.VarChar)
                comando.Parameters("@nome_cliente").Value = TXT_Nome.Text

                comando.Parameters.Add("@Status_Cliente", MySqlDbType.VarChar)
                comando.Parameters("@Status_Cliente").Value = "Ativo"

                Try
                    comando.ExecuteNonQuery()
                    MessageBox.Show("Inclusão do Cliente na empresa elaborada com sucesso!", "Incluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LBL_Status.Text = "Ativo"
                    BTN_Excluir.Text = "Excluir Cliente"
                Catch ex As Exception
                    MessageBox.Show("Erro ao incluir o Cliente na empresa! Tente novamente!", "Incluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    FecharBD()
                End Try
            End If
        End If
    End Sub

    'Ao clicar duas vezes no campo, este apagar a informação
    Private Sub TXT_Nome_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Nome.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Nome.Text = ""
        End If
    End Sub

    Private Sub TXT_Email_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Email.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Email.Text = ""
        End If
    End Sub

    Private Sub TXT_CPF_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If (Alterar = True) Then
            TXT_CPF.Clear()
        End If
    End Sub

    Private Sub TXT_N_Endereco_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_N_Endereco.MouseDoubleClick
        If (Alterar = True) Then
            TXT_N_Endereco.Text = ""
        End If
    End Sub

    Private Sub TXT_Cidade_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Cidade.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Cidade.Text = ""
        End If
    End Sub

    Private Sub TXT_UF_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_UF.MouseDoubleClick
        If (Alterar = True) Then
            TXT_UF.Text = ""
        End If
    End Sub

    Private Sub TXT_Bairro_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Bairro.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Bairro.Text = ""
        End If

    End Sub

    Private Sub TXT_Endereco_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Endereco.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Endereco.Text = ""
        End If
    End Sub

    Private Sub TXT_CEP_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_CEP.MouseDoubleClick
        If (Alterar = True) Then
            TXT_CEP.Clear()
        End If
    End Sub

    Private Sub TXT_Conta_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Conta.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Conta.Text = ""
        End If
    End Sub

    Private Sub TXT_Nascimento_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If (Alterar = True) Then
            TXT_Nascimento.Clear()
        End If
    End Sub

    Private Sub MST_Celular_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If (Alterar = True) Then
            TXT_Celular.Clear()
        End If
    End Sub

    Private Sub MST_TelefoneComercial_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If (Alterar = True) Then
            TXT_TelefoneComercial.Clear()
        End If
    End Sub

    Private Sub MST_Telefone_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        If (Alterar = True) Then
            TXT_Telefone.Clear()
        End If
    End Sub

    Private Sub TXT_Agencia_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Agencia.MouseDoubleClick
        If (Alterar = True) Then
            TXT_Agencia.Text = ""
        End If
    End Sub

    Private Sub TXT_InfoAdicionais_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_InfoAdicionais.MouseDoubleClick
        If (Alterar = True) Then
            TXT_InfoAdicionais.Text = ""
        End If
    End Sub

    'Voltar a informação inicial, caso a informação no campo não seja alterada

    Private Sub TXT_Nome_LostFocus(sender As Object, e As EventArgs) Handles TXT_Nome.LostFocus
        If (TXT_Nome.Text = "") Then
            TXT_Nome.Text = Nome
        End If
    End Sub

    Private Sub TXT_Email_LostFocus(sender As Object, e As EventArgs) Handles TXT_Email.LostFocus
        If (TXT_Email.Text = "") Then
            TXT_Email.Text = Email
        End If
    End Sub

    Private Sub TXT_CPF_LostFocus(sender As Object, e As EventArgs)
        If (TXT_CPF.Text = "") Then
            TXT_CPF.Text = CPF
        End If
    End Sub

    Private Sub TXT_N_Endereco_LostFocus(sender As Object, e As EventArgs) Handles TXT_N_Endereco.LostFocus
        If (TXT_Endereco.Text = "") Then
            TXT_Endereco.Text = NEndereco
        End If
    End Sub

    Private Sub TXT_Cidade_LostFocus(sender As Object, e As EventArgs) Handles TXT_Cidade.LostFocus
        If (TXT_Cidade.Text = "") Then
            TXT_Cidade.Text = Cidade
        End If
    End Sub

    Private Sub TXT_UF_LostFocus(sender As Object, e As EventArgs) Handles TXT_UF.LostFocus
        If (TXT_UF.Text = "") Then
            TXT_UF.Text = UF
        End If
    End Sub

    Private Sub TXT_Bairro_LostFocus(sender As Object, e As EventArgs) Handles TXT_Bairro.LostFocus
        If (TXT_Bairro.Text = "") Then
            TXT_Bairro.Text = Bairro
        End If
    End Sub

    Private Sub TXT_Endereco_LostFocus(sender As Object, e As EventArgs) Handles TXT_Endereco.LostFocus
        If (TXT_Endereco.Text = "") Then
            TXT_Endereco.Text = Endereco
        End If
    End Sub

    Private Sub TXT_CEP_LostFocus(sender As Object, e As EventArgs) Handles TXT_CEP.LostFocus
        If (TXT_CEP.Text = "") Then
            TXT_CEP.Text = CEP
        End If
    End Sub

    Private Sub TXT_Conta_LostFocus(sender As Object, e As EventArgs) Handles TXT_Conta.LostFocus
        If (TXT_Conta.Text = "") Then
            TXT_Conta.Text = Conta
        End If
    End Sub

    Private Sub TXT_Nascimento_LostFocus(sender As Object, e As EventArgs)
        If (TXT_Nascimento.Text = "") Then
            TXT_Nascimento.Text = Nascimento
        End If
    End Sub

    Private Sub MST_Celular_LostFocus(sender As Object, e As EventArgs)
        If (TXT_Celular.Text = "") Then
            TXT_Celular.Text = Celular
        End If
    End Sub

    Private Sub MST_TelefoneComercial_LostFocus(sender As Object, e As EventArgs)
        If (TXT_TelefoneComercial.Text = "") Then
            TXT_TelefoneComercial.Text = TelefoneCom
        End If
    End Sub

    Private Sub MST_Telefone_LostFocus(sender As Object, e As EventArgs)
        If (TXT_Telefone.Text = "") Then
            TXT_Telefone.Text = Telefone
        End If
    End Sub

    Private Sub TXT_Agencia_LostFocus(sender As Object, e As EventArgs) Handles TXT_Agencia.LostFocus
        If (TXT_Agencia.Text = "") Then
            TXT_Agencia.Text = Agencia
        End If
    End Sub

    Private Sub TXT_InfoAdicionais_LostFocus(sender As Object, e As EventArgs) Handles TXT_InfoAdicionais.LostFocus
        If (TXT_InfoAdicionais.Text = "") Then
            TXT_InfoAdicionais.Text = Infos
        End If
    End Sub

    Private Sub BTN_Alterar_Click(sender As Object, e As EventArgs) Handles BTN_Alterar.Click
        Dim comando As New MySqlCommand("Update Clientes set (Nome_Cliente, CPF_Cliente, Email_Cliente, Data_Nasc_Cliente, Telefone_Cliente, Telefone_Com_Cliente, Celular_Cliente, CEP_Cliente, Endereco_Cliente, N_Endereco_Cliente, Bairro_Cliente, Cidade_Cliente, UF_Cliente, Banco_Cliente, Agencia_Cliente, Conta_Cliente, Infos_Adic_Cliente, Status_Cliente) values (@Nome_Cliente, @CPF_Cliente, @Email_Cliente, @Data_Nasc_Cliente, @Telefone_Cliente, @Telefone_Com_Cliente, @Celular_Cliente, @CEP_Cliente, @Endereco_Cliente, @N_Endereco_Cliente, @Bairro_Cliente, @Cidade_Cliente, @UF_Cliente, @Banco_Cliente, @Agencia_Cliente, @Conta_Cliente, @Infos_Adic_Cliente, @Status_Cliente) where Nome_Cliente=@Nome_Cliente", Conexao)
        AbrirBD()
        comando.Parameters.Add("@Nome_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Nome_Cliente").Value = TXT_Nome.Text

        comando.Parameters.Add("@CPF_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@CPF_Cliente").Value = TXT_CPF.Text

        comando.Parameters.Add("@Email_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Email_Cliente").Value = TXT_Email.Text

        comando.Parameters.Add("@Data_Nasc_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Data_Nasc_Cliente").Value = TXT_Nascimento.Text

        comando.Parameters.Add("@Telefone_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Telefone_Cliente").Value = TXT_Telefone.Text()

        comando.Parameters.Add("@Telefone_Com_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Telefone_Com_Cliente").Value = TXT_TelefoneComercial.Text

        comando.Parameters.Add("@Celular_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Celular_Cliente").Value = TXT_Celular.Text

        comando.Parameters.Add("@CEP_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@CEP_Cliente").Value = TXT_CEP.Text

        comando.Parameters.Add("@Endereco_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Endereco_Cliente").Value = TXT_Endereco.Text

        comando.Parameters.Add("@N_Endereco_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@N_Endereco_Cliente").Value = TXT_N_Endereco.Text

        comando.Parameters.Add("@Bairro_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Bairro_Cliente").Value = TXT_Bairro.Text

        comando.Parameters.Add("@Cidade_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Cidade_Cliente").Value = TXT_Cidade.Text

        comando.Parameters.Add("@UF_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@UF_Cliente").Value = TXT_UF.Text

        comando.Parameters.Add("@Banco_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Banco_Cliente").Value = CMB_Banco.Text

        comando.Parameters.Add("@Agencia_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Agencia_Cliente").Value = TXT_Agencia.Text

        comando.Parameters.Add("@Conta_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Conta_Cliente").Value = TXT_Conta.Text

        comando.Parameters.Add("@Infos_Adic_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Infos_Adic_Cliente").Value = TXT_InfoAdicionais.Text

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Alterações no cadastro realizadas com sucesso!", "Alteração no cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar o cadastro!" & ex.Message, "Erro na Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub BTN_CEP_Click(sender As Object, e As EventArgs) Handles BTN_CEP.Click
        Try
            Dim ds As New DataSet()
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", TXT_CEP.Text)
            ds.ReadXml(xml)
            TXT_Endereco.Text = ds.Tables(0).Rows(0)("logradouro").ToString()
            TXT_Bairro.Text = ds.Tables(0).Rows(0)("bairro").ToString()
            TXT_Cidade.Text = ds.Tables(0).Rows(0)("cidade").ToString()
            TXT_UF.Text = ds.Tables(0).Rows(0)("uf").ToString()
        Catch ex As Exception
            MessageBox.Show("Erro ao buscar o CEP! " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If (TXT_Endereco.Text = "") Then
            MessageBox.Show("CEP não encontrado! Tente novamente!", "Busca de CEP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            TXT_N_Endereco.ReadOnly = False
            TXT_N_Endereco.Focus()
        End If
    End Sub

    'Menu

    Private Sub LocalizarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click
        Localizar_Funcionarios.Show()
    End Sub

    Private Sub AdimitirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdimitirToolStripMenuItem.Click
        Cadastro_Funcionario.Show()
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        Localizar_Clientes.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem1.Click
        Cadastro_Cliente.Show()
    End Sub

    Private Sub ProjetosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjetosToolStripMenuItem.Click
        Localizar_Compras.Show()
    End Sub

    Private Sub NovaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaToolStripMenuItem.Click
        Comprar.Show()
    End Sub

    Private Sub SoftwareDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareDesktopToolStripMenuItem.Click
        Orcamento_VB.Show()
    End Sub

    Private Sub WebSitesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebSitesToolStripMenuItem.Click
        Orcamento.Show()
    End Sub

    Private Sub LocalizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem1.Click
        Localizar_Produtos.Show()
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Cadastro_Produto.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        MenuLogado = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub
End Class