Imports MySql.Data.MySqlClient
Public Class Menu2
    Dim OutroEvento As String

    Private Sub TXT_CEP_Validated(sender As Object, e As EventArgs) Handles TXT_CEP.Validated
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

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_Evento.SelectedIndexChanged
        If (CMB_Evento.SelectedItem = "Outro") Then
            OutroEvento = InputBox("Digite o nome do Evento: ", "Outro Evento")
            CMB_Evento.Items.Add(OutroEvento)
            CMB_Evento.SelectedItem = OutroEvento
        End If
    End Sub
    Private Sub Cliente_LostFocus(sender As Object, e As EventArgs) Handles TXT_Cliente.LostFocus
        Dim comando As New MySqlCommand("select CEP_Cliente, Endereco_Cliente, N_Endereco_Cliente, Bairro_Cliente, Cidade_Cliente, UF_Cliente from Clientes where Nome_Cliente = @Nome_Cliente", Conexao)
        AbrirBD()
        comando.Parameters.Add("@Nome_Cliente", MySqlDbType.VarChar)
        comando.Parameters("@Nome_Cliente").Value = TXT_Cliente.Text
        Dim dr As MySqlDataReader
        dr = comando.ExecuteReader
        While dr.Read
            TXT_CEP.ReadOnly = True
            TXT_CEP.Text = dr("CEP_Cliente")
            TXT_Endereco.Text = dr("Endereco_Cliente")
            TXT_N_Endereco.Text = dr("N_Endereco_Cliente")
            TXT_Bairro.Text = dr("Bairro_Cliente")
            TXT_Cidade.Text = dr("Cidade_Cliente")
            TXT_UF.Text = dr("UF_Cliente")
        End While
        dr.Close()
        FecharBD()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim comando As New MySqlCommand("Insert into Agenda (Evento_Agenda, Data_Agenda, Cliente_Agenda, CEP_Agenda, Endereco_Agenda, N_Endereco_Agenda, Bairro_Agenda, Cidade_Agenda, UF_Agenda, Descricao_Agenda, Funcionario_Agenda) values (@Evento_Agenda, @Data_Agenda, @Cliente_Agenda, @CEP_Agenda, @Endereco_Agenda, @N_Endereco_Agenda, @Bairro_Agenda, @Cidade_Agenda, @UF_Agenda, @Descricao_Agenda, @Funcionario_Agenda)", Conexao)
        AbrirBD()

        comando.Parameters.Add("@Evento_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@Evento_Agenda").Value = CMB_Evento.SelectedItem

        comando.Parameters.Add("@Data_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@Data_Agenda").Value = Data_Evento.Text

        comando.Parameters.Add("@Cliente_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@Cliente_Agenda").Value = TXT_Cliente.Text

        comando.Parameters.Add("@CEP_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@CEP_Agenda").Value = TXT_CEP.Text

        comando.Parameters.Add("@Endereco_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@Endereco_Agenda").Value = TXT_Endereco.Text

        comando.Parameters.Add("@N_Endereco_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@N_Endereco_Agenda").Value = TXT_N_Endereco.Text

        comando.Parameters.Add("@Bairro_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@Bairro_Agenda").Value = TXT_Bairro.Text

        comando.Parameters.Add("@Cidade_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@Cidade_Agenda").Value = TXT_Cidade.Text

        comando.Parameters.Add("@UF_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@UF_Agenda").Value = TXT_UF.Text

        comando.Parameters.Add("@Descricao_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@Descricao_Agenda").Value = TXT_Descricao.Text

        comando.Parameters.Add("@Funcionario_Agenda", MySqlDbType.VarChar)
        comando.Parameters("@Funcionario_Agenda").Value = CMB_Func.Text

        Try
            comando.ExecuteNonQuery()
            MessageBox.Show("Evento Cadastrado com sucesso!", "Cadastrar Evento", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao cadastrar o Evento." & ex.Message, "Cadastrar Evento", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FecharBD()
        End Try
    End Sub

    Private Sub CMB_Func_MouseClick(sender As Object, e As MouseEventArgs) Handles CMB_Func.MouseClick
        CMB_Func.Items.Clear()
        Dim comando As New MySqlCommand("select Nome_Funcionario from Funcionarios", Conexao)
        AbrirBD()
        Dim dr As MySqlDataReader
        dr = comando.ExecuteReader
        While dr.Read
            CMB_Func.Items.Add(dr("Nome_Funcionario"))
        End While
        dr.Close()
        FecharBD()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim comando2 As New MySqlCommand("select Data_Agenda, Evento_Agenda, Cliente_Agenda, Endereco_Agenda, N_Endereco_Agenda, Bairro_Agenda, Cidade_Agenda, UF_Agenda, Descricao_Agenda from Agenda", Conexao)
        AbrirBD()
        Dim dr As MySqlDataReader
        dr = comando2.ExecuteReader
        While dr.Read
            Dim agendaqualquer As New ListViewItem
            agendaqualquer.Text = dr("Data_Agenda")
            agendaqualquer.SubItems.Add(dr("Evento_Agenda"))
            agendaqualquer.SubItems.Add(dr("Cliente_Agenda"))
            agendaqualquer.SubItems.Add(dr("Endereco_Agenda") & " " & dr("N_Endereco_Agenda") & " / " & dr("Bairro_Agenda") & ", " & dr("Cidade_Agenda") & " - " & dr("UF_Agenda"))
            agendaqualquer.SubItems.Add(dr("Descricao_Agenda"))
            LSV_Agenda.Items.Add(agendaqualquer)
        End While
        dr.Close()
        FecharBD()
        Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Localizar_Clientes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Localizar_Funcionarios.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TXT_Data.Text = Today & " - " & TimeOfDay.Hour & ":" & TimeOfDay.Minute
    End Sub

    Private Sub TabPage1_GotFocus(sender As Object, e As EventArgs) Handles TabPage1.GotFocus
        Dim comando2 As New MySqlCommand("select Data_Agenda, Evento_Agenda, Cliente_Agenda, Endereco_Agenda, N_Endereco_Agenda, Bairro_Agenda, Cidade_Agenda, UF_Agenda, Descricao_Agenda from Agenda", Conexao)
        AbrirBD()
        Dim dr As MySqlDataReader
        dr = comando2.ExecuteReader
        While dr.Read
            Dim agendaqualquer As New ListViewItem
            agendaqualquer.Text = dr("Data_Agenda")
            agendaqualquer.SubItems.Add(dr("Evento_Agenda"))
            agendaqualquer.SubItems.Add(dr("Cliente_Agenda"))
            agendaqualquer.SubItems.Add(dr("Endereco_Agenda") & " " & dr("N_Endereco_Agenda") & " / " & dr("Bairro_Agenda") & ", " & dr("Cidade_Agenda") & " - " & dr("UF_Agenda"))
            agendaqualquer.SubItems.Add(dr("Descricao_Agenda"))
            LSV_Agenda.Items.Add(agendaqualquer)
        End While
        dr.Close()
        FecharBD()
    End Sub

    'Menu

    Private Sub Menu2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim palavras As String() = NomeLogin.Split(New Char() {" "c})
        MenuLogado = palavras(0) & " " & palavras(palavras.Length - 1)
        TST_NomeLogado.Text = "Olá, " & MenuLogado
        TXT_Data.Text = Today & " - " & TimeOfDay.Hour & ":" & TimeOfDay.Minute
        Timer1.Enabled = True
        If Idioma = "Inglês" Then
            Button1.Text = "Employers"
            Button2.Text = "Worker"
            Button3.Text = "New accont"
            Button4.Text = "Purchases"
            ColumnHeader1.Text = "Data"
            ColumnHeader2.Text = "Event"
            ColumnHeader3.Text = "Employer"
            ColumnHeader4.Text = "Place"
            ColumnHeader5.Text = "Description"
            TabPage1.Text = "Event"
            TabPage1.Text = "New event"
            Label1.Text = "Event"
            Label2.Text = "Data"
            Label3.Text = "Client"
            Label4.Text = "Decription"
            Label5.Text = "Employer"
            Label6.Text = "address"
            Label7.Text = "CEP"
            Label8.Text = "UF"
            Label9.Text = "Neighborhod"
            Label10.Text = "City"
            MenuToolStripMenuItem.Text = "Menu"
            FuncionáriosToolStripMenuItem.Text = ""
            ClientesToolStripMenuItem.Text = ""

        End If
    End Sub

    Private Sub AdimitirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdimitirToolStripMenuItem.Click
        Cadastro_Funcionario.Show()
    End Sub

    Private Sub LocalizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click
        Localizar_Funcionarios.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem1.Click
        Cadastro_Cliente.Show()
    End Sub

    Private Sub BuscarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem1.Click
        Localizar_Clientes.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Comprar.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Localizar_Compras.Show()
    End Sub

    Private Sub WebSitesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebSitesToolStripMenuItem.Click
        Orcamento.Show()
    End Sub

    Private Sub SoftwareDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareDesktopToolStripMenuItem.Click
        Orcamento_VB.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Cadastro_Produto.Show()
    End Sub

    Private Sub LocalizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem1.Click
        Localizar_Produtos.Show()
    End Sub

    Private Sub NovaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaToolStripMenuItem.Click
        Comprar.Show()
    End Sub

    Private Sub ProjetosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjetosToolStripMenuItem.Click
        Localizar_Compra2.Show()
    End Sub

End Class