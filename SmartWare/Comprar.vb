Imports MySql.Data.MySqlClient
Public Class Comprar
    Dim PrecoConsul As Double
    Dim PrecoTotal, PrecoProjeto As Double
    Private Sub CHB_Consultoria_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_Consultoria.CheckedChanged
        Dim HoraConsul As Integer
        If (CHB_Consultoria.Checked = True) Then
            HoraConsul = InputBox("Digite o número de horas: ", "Horas de Consultoria")
            PrecoConsul = HoraConsul * 200
            LBL_Consultoria.Text = "R$" & PrecoConsul
        End If
    End Sub

    Private Sub CMB_Pacote_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_Pacote.SelectedIndexChanged
        CMB_Pacote.Items.Clear()
        Dim comando As New MySqlCommand("Select Pacote_Produto from Produtos", Conexao)
        AbrirBD()
        Dim dr As MySqlDataReader
        dr = comando.ExecuteReader
        While dr.Read
            CMB_Pacote.Items.Add(dr("Pacote_Produto"))
        End While
        dr.Close()
        FecharBD()
        If (CMB_Pacote.Items.Item(0) = "") Then
            MessageBox.Show("Nenhum Pacote de Serviços cadastrado! Informe seu gerente para que sejam tomadas as devidas providencias!", "Nenhum Pacote Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim comando2 As New MySqlCommand("Select Categoria_Produto from Produtos where Pacote_Produto=@Pacote_Produto", Conexao)
            AbrirBD()

            comando2.Parameters.Add("@Pacote_Produto", MySqlDbType.VarChar)
            comando2.Parameters("@Pacote_Produto").Value = CMB_Pacote.SelectedItem

            Dim dr2 As MySqlDataReader
            dr = comando2.ExecuteReader
            If (dr2.Read = "Desktop") Then
                CHB_Desktop.Checked = True
                LBL_Desktop.Text = dr("Preco_Produto")
            End If
            If (dr2.Read = "Mobile") Then
                CHB_Mobile.Checked = True
                LBL_Mobile.Text = dr("Preco_Produto")
            End If
            If (dr2.Read = "WEB") Then
                CHB_WEB.Checked = True
                LBL_Web.Text = dr("Preco_Produto")
            End If
            If (dr2.Read = "ECommerce") Then
                CHB_ECommerce.Checked = True
                LBL_ECommerce.Text = dr("Preco_Produto")
            End If
            If (dr2.Read = "SEO") Then
                CHB_SEO.Checked = True
                LBL_SEO.Text = dr("Preco_Produto")
            End If
            dr.Close()
            FecharBD()
        End If
    End Sub

    Private Sub CMB_Cliente_GotFocus(sender As Object, e As EventArgs) Handles CMB_Cliente.GotFocus
        CMB_Cliente.Items.Clear()
        Dim comando As New MySqlCommand("select Nome_Cliente from Clientes", Conexao)
        AbrirBD()
        Dim dr As MySqlDataReader
        dr = comando.ExecuteReader
        While dr.Read
            CMB_Cliente.Items.Add(dr("Nome_Cliente"))
        End While
        dr.Close()
        FecharBD()
    End Sub

    Private Sub BTN_ConfirmarInfos_Click(sender As Object, e As EventArgs) Handles BTN_ConfirmarInfos.Click
        Localizar_Cliente.Show()
        Confirma = True
    End Sub

    Private Sub CMB_Cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_Cliente.SelectedIndexChanged
        NomeCC = CMB_Cliente.SelectedItem
    End Sub

    Private Sub Comprar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Confirma = False
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Confirmado = True) Then
            BTN_ConfirmarInfos.Enabled = False
            CMB_Cliente.Text = NomeCC
            CMB_Cliente.Enabled = False
        End If
        PrecoProjeto = LBL_Desktop.Text + LBL_Mobile.Text + LBL_Web.Text + LBL_SEO.Text + LBL_ECommerce.Text + LBL_Consultoria.Text
        PrecoTotal = (LBL_Desktop.Text * NUM_Lincencas.Value) + (LBL_Mobile.Text * NUM_Lincencas.Value) + LBL_Web.Text + LBL_SEO.Text + LBL_ECommerce.Text + LBL_Consultoria.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Desktop, Mobile, WebSite, Ecommerce, SEO, Consultoria As Boolean
        If (CHB_Desktop.Checked = True) Then
            Desktop = True
        End If
        If (CHB_Mobile.Checked = True) Then
            Mobile = True
        End If
        If (CHB_WEB.Checked = True) Then
            WebSite = True
        End If
        If (CHB_ECommerce.Checked = True) Then
            Ecommerce = True
        End If
        If (CHB_SEO.Checked = True) Then
            SEO = True
        End If
        If (CHB_Consultoria.Checked = True) Then
            Consultoria = True
        End If
        If (MessageBox.Show("Deseja realmente finalizar esta compra?", "Finalizar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Dim comando As New MySqlCommand("Insert into Compras (Nome_Cliente_Compra, Pacote_Compra, Produto_Desktop_Compra, Produto_Mobile_Compra, Produto_WebSite_Compra, Produto_ECommerce_Compra, Produto_SEO_Compra, Produto_Consultoria_Compra, Preco_Desktop_Compra, Preco_Mobile_Compra, Preco_WebSite_Compra, Preco_ECommerce_Compra, Preco_SEO_Compra, Preco_Consultoria_Compra, Preco_Projeto_Compra, QTDE_Licencas_Compra, Mensalidade_Compra, Previsao_Compra, Preco_Total_Compra, Descricao_Gerais_Compra, Descricao_Desktop_Compra, Descricao_Mobile_Compra, Descricao_WebSite_Compra, Descricao_ECommerce_Compra, Descricao_SEO_Compra, Descricao_Consultoria_Compra) values (@Nome_Cliente_Compra, @Pacote_Compra, @Produto_Desktop_Compra, @Produto_Mobile_Compra, @Produto_WebSite_Compra, @Produto_ECommerce_Compra, @Produto_SEO_Compra, @Produto_Consultoria_Compra, @Preco_Desktop_Compra, @Preco_Mobile_Compra, @Preco_WebSite_Compra, @Preco_ECommerce_Compra, @Preco_SEO_Compra, @Preco_Consultoria_Compra, @Preco_Projeto_Compra, @QTDE_Licencas_Compra, @Mensalidade_Compra, @Previsao_Compra, @Preco_Total_Compra, @Descricao_Gerais_Compra, @Descricao_Desktop_Compra, @Descricao_Mobile_Compra, @Descricao_WebSite_Compra, @Descricao_ECommerce_Compra, @Descricao_SEO_Compra, @Descricao_Consultoria_Compra)", Conexao)
            AbrirBD()
            comando.Parameters.Add("@Nome_Cliente_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Nome_Cliente_Compra").Value = CMB_Cliente.SelectedItem

            comando.Parameters.Add("@Pacote_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Pacote_Compra").Value = CMB_Pacote.SelectedItem

            comando.Parameters.Add("@Produto_Desktop_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Produto_Desktop_Compra").Value = Desktop

            comando.Parameters.Add("@Produto_Mobile_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Produto_Mobile_Compra").Value = Mobile

            comando.Parameters.Add("@Produto_WebSite_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Produto_WebSite_Compra").Value = WebSite

            comando.Parameters.Add("@Produto_ECommerce_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Produto_ECommerce_Compra").Value = Ecommerce

            comando.Parameters.Add("@Produto_SEO_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Produto_SEO_Compra").Value = SEO

            comando.Parameters.Add("@Produto_Consultoria_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Produto_Consultoria_Compra").Value = Consultoria

            comando.Parameters.Add("@Preco_Desktop_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Preco_Desktop_Compra").Value = LBL_Desktop.Text

            comando.Parameters.Add("@Preco_Mobile_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Preco_Mobile_Compra").Value = LBL_Mobile.Text

            comando.Parameters.Add("@Preco_WebSite_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Preco_WebSite_Compra").Value = LBL_Web.Text

            comando.Parameters.Add("@Preco_ECommerce_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Preco_ECommerce_Compra").Value = LBL_ECommerce.Text

            comando.Parameters.Add("@Preco_SEO_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Preco_SEO_Compra").Value = LBL_SEO.Text

            comando.Parameters.Add("@Preco_Consultoria_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Preco_Consultoria_Compra").Value = LBL_Consultoria.Text

            comando.Parameters.Add("@Preco_Projeto_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Preco_Projeto_Compra").Value = LBL_PrecoProjeto.Text

            comando.Parameters.Add("@QTDE_Licencas_Compra", MySqlDbType.VarChar)
            comando.Parameters("@QTDE_Licencas_Compra").Value = NUM_Lincencas.Value

            comando.Parameters.Add("@Mensalidade_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Mensalidade_Compra").Value = MST_Mensalidade.Text

            comando.Parameters.Add("@Previsao_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Previsao_Compra").Value = DateTimePicker1.Text

            comando.Parameters.Add("@Preco_Total_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Preco_Total_Compra").Value = LBL_Total.Text

            comando.Parameters.Add("@Descricao_Gerais_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Descricao_Gerais_Compra").Value = TXT_DescricaoGeral.Text

            comando.Parameters.Add("@Descricao_Desktop_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Descricao_Desktop_Compra").Value = TXT_DescricaoDesktop.Text

            comando.Parameters.Add("@Descricao_Mobile_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Descricao_Mobile_Compra").Value = TXT_DescricaoMobile.Text

            comando.Parameters.Add("@Descricao_WebSite_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Descricao_WebSite_Compra").Value = TXT_DescricaoWeb.Text

            comando.Parameters.Add("@Descricao_ECommerce_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Descricao_ECommerce_Compra").Value = TXT_ECommerce.Text

            comando.Parameters.Add("@Descricao_SEO_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Descricao_SEO_Compra").Value = TXT_DescricaoSEO.Text

            comando.Parameters.Add("@Descricao_Consultoria_Compra", MySqlDbType.VarChar)
            comando.Parameters("@Descricao_Consultoria_Compra").Value = TXT_DescricaoConsultoria.Text

            Try
                comando.ExecuteNonQuery()
                MessageBox.Show("Produto Cadastrado com sucesso!", "Cadastrar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao cadastrar o Produto." & ex.Message, "Cadastrar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                FecharBD()
            End Try

        End If
    End Sub


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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub
End Class