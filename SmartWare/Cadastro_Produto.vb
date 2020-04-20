Imports MySql.Data.MySqlClient
Public Class Cadastro_Produto

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedItem = "Novo") Then
            Dim Novo As String
            Novo = InputBox("Digite o novo Pacote: ", "Novo Pacote")
            ComboBox1.Items.Add(Novo)
        End If
    End Sub

    Private Sub BTN_Cadastrar_Click(sender As Object, e As EventArgs) Handles BTN_Cadastrar.Click
        Dim Categoria As String

        If (RDB_Desktop.Checked = True) Then
            Categoria = "Desktop"
        Else
            If (RDB_Mobile.Checked = True) Then
                Categoria = "Mobile"
            Else
                If (RDB_Web.Checked = True) Then
                    Categoria = "WEB"
                Else
                    If (RDB_ECommerce.Checked = True) Then
                        Categoria = "ECommerce"
                    Else
                        If (RDB_SEO.Checked = True) Then
                            Categoria = "SEO"
                        Else
                            MessageBox.Show("Selecione a categoria do Produto!", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                End If
            End If
        End If

        Dim comando As New MySqlCommand("Insert into Produtos (Nome_Produto, Categoria_Produto, Preco_Produto, Linguagem_Produto, Pacote_Produto) values (@Nome_Produto, @Categoria_Produto, @Preco_Produto, @Linguagem_Produto, @Pacote_Produto)", Conexao)
        AbrirBD()

        comando.Parameters.Add("@Nome_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Nome_Produto").Value = TXT_Nome.Text

        comando.Parameters.Add("@Categoria_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Categoria_Produto").Value = Categoria

        comando.Parameters.Add("@Preco_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Preco_Produto").Value = MST_Preco.Text

        comando.Parameters.Add("@Linguagem_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Linguagem_Produto").Value = TXT_Linguagem.Text

        comando.Parameters.Add("@Pacote_Produto", MySqlDbType.VarChar)
        comando.Parameters("@Pacote_Produto").Value = ComboBox1.SelectedItem

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Produto Cadastrado com sucesso!", "Cadastrar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao cadastrar o Produto." & ex.Message, "Cadastrar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    'Menu

    Private Sub Menu2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub

    Private Sub LocalizarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click
        Localizar_Funcionarios.Show()
    End Sub

    Private Sub AdimitirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AdimitirToolStripMenuItem.Click
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        MenuLogado = ""
        Me.Hide()
        Form1.Show()
    End Sub
End Class