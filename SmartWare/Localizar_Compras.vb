Imports MySql.Data.MySqlClient
Public Class Localizar_Compras

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedItem = "Todos") Then
            TXT_Busca.Enabled = False
            TXT_Busca.Visible = True
            LBL_Ate.Visible = False
            DateTimePicker1.Visible = False
            ListView1.Items.Clear()
            Dim comando As New MySqlCommand("Select Cod_Compra, Nome_Cliente_Compra, Preco_Total_Compra, Mensalidade_Compra from Compras", Conexao)
            AbrirBD()
            Dim dr As MySqlDataReader
            dr = comando.ExecuteReader
            While dr.Read
                Dim nomequalquer As New ListViewItem
                nomequalquer.Text = dr("Cod_Compra")
                nomequalquer.SubItems.Add(dr("Nome_Cliente_Compra"))
                nomequalquer.SubItems.Add(dr("Preco_Total_Compra"))
                nomequalquer.SubItems.Add(dr("Mensalidade_Compra"))
                ListView1.Items.Add(nomequalquer)
            End While
            dr.Close()
            FecharBD()
        Else
            If (ComboBox1.SelectedItem = "Nome do Cliente") Then
                TXT_Busca.Enabled = True
                TXT_Busca.Visible = True
                LBL_Ate.Visible = False
                DateTimePicker1.Visible = False
                ListView1.Items.Clear()
                Dim comando As New MySqlCommand("Select Cod_Compra, Nome_Cliente_Compra, Preco_Total_Compra, Mensalidade_Compra from Compras where Nome_Cliente_Compra = @Nome_Cliente_Compra", Conexao)
                AbrirBD()
                comando.Parameters.Add("@Nome_Cliente_Compra", MySqlDbType.VarChar)
                comando.Parameters("@Nome_Cliente_Compra").Value = TXT_Busca.Text
                Dim dr As MySqlDataReader
                dr = comando.ExecuteReader
                While dr.Read
                    Dim nomequalquer As New ListViewItem
                    nomequalquer.Text = dr("Cod_Compra")
                    nomequalquer.SubItems.Add(dr("Nome_Cliente_Compra"))
                    nomequalquer.SubItems.Add(dr("Preco_Total_Compra"))
                    nomequalquer.SubItems.Add(dr("Mensalidade_Compra"))
                    ListView1.Items.Add(nomequalquer)
                End While
                dr.Close()
                FecharBD()
            Else
                If (ComboBox1.SelectedItem = "Data de Entrega") Then
                    TXT_Busca.Enabled = False
                    TXT_Busca.Visible = False
                    LBL_Ate.Visible = True
                    DateTimePicker1.Visible = True
                    Dim comando As New MySqlCommand("Select Cod_Compra, Nome_Cliente_Compra, Preco_Total_Compra, Mensalidade_Compra from Compras where Previsao_Compra = @Previsao_Compra", Conexao)
                    AbrirBD()
                    comando.Parameters.Add("@Previsao_Compra", MySqlDbType.VarChar)
                    comando.Parameters("@Previsao_Compra").Value = DateTimePicker1.Text
                    Dim dr As MySqlDataReader
                    dr = comando.ExecuteReader
                    While dr.Read
                        Dim nomequalquer As New ListViewItem
                        nomequalquer.Text = dr("Cod_Compra")
                        nomequalquer.SubItems.Add(dr("Nome_Cliente_Compra"))
                        nomequalquer.SubItems.Add(dr("Preco_Total_Compra"))
                        nomequalquer.SubItems.Add(dr("Mensalidade_Compra"))
                        ListView1.Items.Add(nomequalquer)
                    End While
                    dr.Close()
                    FecharBD()
                Else
                    MessageBox.Show("Nenhuma compra localizada!", "Pesquisar Compra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        NomeSelectCompra = ListView1.FocusedItem.Text

    End Sub

    'Menu

    Private Sub LocalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click
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

    Private Sub Localizar_Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
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