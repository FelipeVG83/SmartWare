Imports MySql.Data.MySqlClient
Public Class Localizar_Compra2

    Private Sub Localizar_Compra2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)

        Dim comando As New MySqlCommand("Select Nome_Cliente_Compra, Pacote_Compra, Produto_Desktop_Compra, Produto_Mobile_Compra, Produto_WebSite_Compra, Produto_ECommerce_Compra, Produto_SEO_Compra, Produto_Consultoria_Compra, Preco_Desktop_Compra, Preco_Mobile_Compra, Preco_WebSite_Compra, Preco_ECommerce_Compra, Preco_SEO_Compra, Preco_Consultoria_Compra, Preco_Projeto_Compra, QTDE_Licencas_Compra, Mensalidade_Compra, Previsao_Compra, Preco_Total_Compra, Descricao_Gerais_Compra, Descricao_Desktop_Compra, Descricao_Mobile_Compra, Descricao_WebSite_Compra, Descricao_ECommerce_Compra, Descricao_SEO_Compra, Descricao_Consultoria_Compra from Compras where Nome_Cliente_Compra=@Nome_Cliente_Compra", Conexao)
        AbrirBD()
        comando.Parameters.Add("@Nome_Cliente_Compra", MySqlDbType.VarChar)
        comando.Parameters("@Nome_Cliente_Compra").Value = NomeSelectCompra

        Dim dr As MySqlDataReader
        dr = comando.ExecuteReader
        While dr.Read
            TXT_Cliente.Text = NomeSelectCompra
            TXT_Pacote.Text = dr("Pacote_Compra")
            CHB_Desktop.Checked = dr("Produto_Desktop_Compra")
            CHB_Mobile.Checked = dr("Produto_Mobile_Compra")
            CHB_WEB.Checked = dr("Produto_WebSite_Compra")
            CHB_SEO.Checked = dr("Produto_SEO_Compra")
            CHB_ECommerce.Checked = dr("Produto_ECommerce_Compra")
            CHB_Consultoria.Checked = dr("Produto_Consultoria_Compra")
            LBL_Desktop.Text = dr("Preco_Desktop_Compra")
            LBL_Mobile.Text = dr("Preco_Mobile_Compra")
            LBL_Web.Text = dr("Preco_WebSite_Compra")
            LBL_ECommerce.Text = dr("Preco_ECommerce_Compra")
            LBL_SEO.Text = dr("Preco_SEO_Compra")
            LBL_Consultoria.Text = dr("Preco_Consultoria_Compra")
            TXT_QTDE.Text = dr("QTDE_Licencas_Compra")
            TXT_Mensalidade.Text = dr("Mensalidade_Compra")
            TXT_Previsao.Text = dr("Previsao_Compra")
            LBL_PrecoProjeto.Text = dr("Preco_Projeto_Compra")
            LBL_Total.Text = dr("Preco_Total_Compra")
            TXT_DescricaoGeral.Text = dr("Descricao_Gerais_Compra")
            TXT_DescricaoDesktop.Text = dr("Descricao_Desktop_Compra")
            TXT_DescricaoMobile.Text = dr("Descricao_Mobile_Compra")
            TXT_DescricaoWeb.Text = dr("Descricao_WebSite_Compra")
            TXT_ECommerce.Text = dr("Descricao_ECommerce_Compra")
            TXT_DescricaoSEO.Text = dr("Descricao_SEO_Compra")
            TXT_DescricaoConsultoria = dr("Descricao_Consultoria_Compra")
        End While
        dr.Close()
        FecharBD()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
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

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        MenuLogado = ""
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub
End Class