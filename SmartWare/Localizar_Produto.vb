Imports MySql.Data.MySqlClient
Public Class Localizar_Produto

    Dim Nome, Categoria, Preco, Linguagem, Pacote, Status As String
    Private Sub Localizar_Produto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)

        Dim comando As New MySqlCommand("Select * from Produtos where Nome_Produto = @Nome_Produto", Conexao)
        AbrirBD()
        comando.Parameters.Add("@Nome_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Nome_Produto").Value = NomeP
        Dim dr As MySqlDataReader
        dr = comando.ExecuteReader
        While dr.Read
            Nome = dr("Nome_Produto")
            TXT_Nome.Text = Nome
            Categoria = dr("Categoria_Produto")
            If (dr("Categoria_Produto") = "Desktop") Then
                RDB_Desktop.Checked = True
            Else
                If (dr("Categoria_Produto") = "Mobile") Then
                    RDB_Mobile.Checked = True
                Else
                    If (dr("Categoria_Produto") = "WEB") Then
                        RDB_Web.Checked = True
                    End If
                End If
            End If
            Preco = dr("Preco_Produto")
            TXT_Preco.Text = Preco
            Linguagem = dr("Linguagem_Produto")
            TXT_Linguagem.Text = Linguagem
            Pacote = dr("Pacote_Produto")
            ComboBox1.SelectedItem = Pacote
            Status = dr("Status_Produto")
            LBL_Status.Text = Status
        End While
        If (LBL_Status.Text = "Ativo") Then
            BTN_Desativar.Text = "Desativar"
            BTN_Desativar.Enabled = True
            BTN_Alterar.Enabled = True
        Else
            If (LBL_Status.Text = "Inativo") Then
                BTN_Desativar.Text = "Desativado"
                BTN_Desativar.Enabled = False
                BTN_Alterar.Enabled = False
            End If
        End If
    End Sub

    Private Sub TXT_Nome_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Nome.MouseDoubleClick
        TXT_Nome.Clear()
    End Sub

    Private Sub TXT_Preco_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Preco.MouseDoubleClick
        TXT_Preco.Clear()
    End Sub

    Private Sub TXT_Linguagem_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Linguagem.MouseDoubleClick
        TXT_Linguagem.Clear()
    End Sub

    Private Sub TXT_Nome_LostFocus(sender As Object, e As EventArgs) Handles TXT_Nome.LostFocus
        If (TXT_Nome.Text = "") Then
            TXT_Nome.Text = Nome
        End If
    End Sub

    Private Sub TXT_Preco_LostFocus(sender As Object, e As EventArgs) Handles TXT_Preco.LostFocus
        If (TXT_Preco.Text = "") Then
            TXT_Preco.Text = Preco
        End If
    End Sub

    Private Sub TXT_Linguagem_LostFocus(sender As Object, e As EventArgs) Handles TXT_Linguagem.LostFocus
        If (TXT_Linguagem.Text = "") Then
            TXT_Linguagem.Text = Linguagem
        End If
    End Sub

    Private Sub BTN_Alterar_Click(sender As Object, e As EventArgs) Handles BTN_Alterar.Click
        Dim Categoria As String

        If (RDB_Desktop.Checked = True) Then
            Categoria = "Desktop"
        Else
            If (RDB_Mobile.Checked = True) Then
                Categoria = "Mobile"
            Else
                If (RDB_Web.Checked = True) Then
                    Categoria = "WEB"
                End If
            End If
        End If
        Dim comando As New MySqlCommand("Update Produtos set Nome_Produto=@Nome_Produto, Categoria_Produto=@Categoria_Produto, Preco_Produto=@Preco_Produto, Linguagem_Produto=@Linguagem_Produto, Pacote_Produto=@Pacote_Produto", Conexao)
        AbrirBD()
        comando.Parameters.Add("@Nome_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Nome_Produto").Value = TXT_Nome.Text

        comando.Parameters.Add("@Categoria_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Categoria_Produto").Value = Categoria

        comando.Parameters.Add("@Preco_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Preco_Produto").Value = TXT_Preco.Text

        comando.Parameters.Add("@Linguagem_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Linguagem_Produto").Value = TXT_Linguagem.Text

        comando.Parameters.Add("@Pacote_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Pacote_Produto").Value = ComboBox1.SelectedItem
        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Alteração no Produto efetuada com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar o Produto! " & ex.Message, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub BTN_Desativar_Click(sender As Object, e As EventArgs) Handles BTN_Desativar.Click
        Dim comando As New MySqlCommand("Update Produtos set Status_Produto = @Status_Produto", Conexao)
        AbrirBD()
        comando.Parameters.Add("@Status_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Status_Produto").Value = "Inativo"
        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Produto Desativado!", "Desativação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao desativar o Produto! " & ex.Message, "Desativação", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    'Menu

    Private Sub AdimitirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdimitirToolStripMenuItem.Click
        Cadastro_Funcionario.Show()
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        Localizar_Clientes.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem1.Click
        Cadastro_Cliente.Show()
    End Sub

    Private Sub NovaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaToolStripMenuItem.Click
        Comprar.Show()
    End Sub

    Private Sub ProjetosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjetosToolStripMenuItem.Click
        Localizar_Compras.Show()
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

    Private Sub LocalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click
        Localizar_Funcionarios.Show()
    End Sub
End Class