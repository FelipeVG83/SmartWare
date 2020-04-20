Imports MySql.Data.MySqlClient
Public Class Localizar_Produtos

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedItem = "Todos") Then
            TXT_Busca.Enabled = False
            TXT_Busca.Visible = True
            CMB_Status.Visible = False
        Else
            If (ComboBox1.SelectedItem = "Nome") Then
                TXT_Busca.Enabled = True
                TXT_Busca.Visible = True
                CMB_Status.Visible = False
            Else
                If (ComboBox1.SelectedItem = "Status") Then
                    TXT_Busca.Enabled = False
                    TXT_Busca.Visible = False
                    CMB_Status.Visible = True
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedItem = "Todos") Then
            ListView1.Items.Clear()
            Dim comando As New MySqlCommand("Select * from Produtos", Conexao)
            AbrirBD()
            Dim dr As MySqlDataReader
            dr = comando.ExecuteReader
            While dr.Read
                Dim nomequalquer As New ListViewItem
                nomequalquer.Text = dr("Cod_Produto")
                nomequalquer.SubItems.Add(dr("Nome_Produto"))
                nomequalquer.SubItems.Add(dr("Status_Produto"))
                nomequalquer.SubItems.Add(dr("Categoria_Produto"))
                nomequalquer.SubItems.Add(dr("Linguagem_Produto"))
                ListView1.Items.Add(nomequalquer)
            End While
            dr.Close()
            FecharBD()
        Else
            If (ComboBox1.SelectedItem = "Nome") Then
                ListView1.Items.Clear()
                Dim comando As New MySqlCommand("Select * from Produtos where Nome_Produto=@Nome_Produto", Conexao)
                AbrirBD()
                comando.Parameters.Add("@Nome_Produto", MySqlDbType.VarChar)
                comando.Parameters("@Nome_Produto").Value = TXT_Busca.Text
                Dim dr As MySqlDataReader
                dr = comando.ExecuteReader
                While dr.Read
                    Dim nomequalquer As New ListViewItem
                    nomequalquer.Text = dr("Cod_Produto")
                    nomequalquer.SubItems.Add(dr("Nome_Produto"))
                    nomequalquer.SubItems.Add(dr("Status_Produto"))
                    nomequalquer.SubItems.Add(dr("Categoria_Produto"))
                    nomequalquer.SubItems.Add(dr("Linguagem_Produto"))
                    ListView1.Items.Add(nomequalquer)
                End While
                dr.Close()
                FecharBD()
            Else
                If (ComboBox1.SelectedItem = "Status") Then
                    ListView1.Items.Clear()
                    Dim comando As New MySqlCommand("Select * from Produtos where Status_Produto=@Status_Produto", Conexao)
                    AbrirBD()
                    comando.Parameters.Add("@Status_Produto", MySqlDbType.VarChar)
                    comando.Parameters("@Status_Produto").Value = CMB_Status.SelectedItem
                    Dim dr As MySqlDataReader
                    dr = comando.ExecuteReader
                    While dr.Read
                        Dim nomequalquer As New ListViewItem
                        nomequalquer.Text = dr("Cod_Produto")
                        nomequalquer.SubItems.Add(dr("Nome_Produto"))
                        nomequalquer.SubItems.Add(dr("Status_Produto"))
                        nomequalquer.SubItems.Add(dr("Categoria_Produto"))
                        nomequalquer.SubItems.Add(dr("Linguagem_Produto"))
                        ListView1.Items.Add(nomequalquer)
                    End While
                    dr.Close()
                    FecharBD()
                End If
            End If
        End If
    End Sub

   
    Private Sub Localizar_Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
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