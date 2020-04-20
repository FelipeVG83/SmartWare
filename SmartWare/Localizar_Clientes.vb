Imports MySql.Data.MySqlClient
Public Class Localizar_Clientes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Pesquisar Todos
        If (ComboBox1.SelectedIndex = 0) Then
            ListView1.Items.Clear()
            Dim comando As New MySqlCommand("Select Nome_Cliente, Cidade_Cliente, UF_Cliente, Status_Cliente from Clientes", Conexao)
            AbrirBD()
            Dim dr As MySqlDataReader
            dr = comando.ExecuteReader
            While dr.Read
                Dim nomequalquer As New ListViewItem
                nomequalquer.Text = dr("Nome_Cliente")
                nomequalquer.SubItems.Add(dr("UF_Cliente") & " - " & dr("Cidade_Cliente"))
                nomequalquer.SubItems.Add(dr("Status_Cliente"))
                ListView1.Items.Add(nomequalquer)
            End While
            dr.Close()
            FecharBD()
        Else
            'Pesquisar por Nome
            If (ComboBox1.SelectedIndex = 1) Then
                ListView1.Items.Clear()
                Dim comando As New MySqlCommand("Select Nome_Cliente, UF_Cliente, Cidade_Cliente, Status_Cliente from Clientes where Nome_Cliente = @Nome_Cliente ", Conexao)
                AbrirBD()
                comando.Parameters.Add("@Nome_Cliente", MySqlDbType.VarChar)
                comando.Parameters("@Nome_Cliente").Value = TXT_Busca.Text
                Dim dr As MySqlDataReader
                dr = comando.ExecuteReader
                Dim nomequalquer As New ListViewItem
                While dr.Read
                    nomequalquer.Text = dr("Nome_Cliente")
                    nomequalquer.SubItems.Add(dr("UF_Cliente") & " - " & dr("Cidade_Cliente"))
                    nomequalquer.SubItems.Add(dr("Status_Cliente"))
                    ListView1.Items.Add(nomequalquer)
                End While
                If (nomequalquer.Text = "") Then
                    MessageBox.Show("Nenhum cliente encontrado! Tente Novamente!", "Informação não encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                dr.Close()
                FecharBD()
            Else
                'Pesquisar Clientes Físicos
                If (ComboBox1.SelectedIndex = 2) Then
                    ListView1.Items.Clear()
                    Dim comando As New MySqlCommand("Select Nome_Cliente, Cidade_Cliente, UF_Cliente, Status_Cliente from Clientes", Conexao)
                    AbrirBD()
                    Dim dr As MySqlDataReader
                    dr = comando.ExecuteReader
                    While dr.Read
                        Dim nomequalquer As New ListViewItem
                        nomequalquer.Text = dr("Nome_Cliente")
                        nomequalquer.SubItems.Add(dr("UF_Cliente") & " - " & dr("Cidade_Cliente"))
                        nomequalquer.SubItems.Add(dr("Status_Cliente"))
                        ListView1.Items.Add(nomequalquer)
                    End While
                    dr.Close()
                    FecharBD()
                Else
                    'Pesquisar Clientes Jurídicos
                    If (ComboBox1.SelectedIndex = 3) Then

                    Else
                        'Pesquisar por Status dos Clientes
                        If (ComboBox1.SelectedIndex = 4) Then
                            ListView1.Items.Clear()
                            Dim comando As New MySqlCommand("Select Nome_Cliente, UF_Cliente, Cidade_Cliente, Status_Cliente from Clientes where Status_Cliente = @Status_Cliente ", Conexao)
                            AbrirBD()
                            comando.Parameters.Add("@Status_Cliente", MySqlDbType.VarChar)
                            comando.Parameters("@Status_Cliente").Value = ComboBox2.SelectedItem
                            Dim dr As MySqlDataReader
                            dr = comando.ExecuteReader
                            Dim nomequalquer As New ListViewItem
                            While dr.Read
                                nomequalquer.Text = dr("Nome_Cliente")
                                nomequalquer.SubItems.Add(dr("UF_Cliente") & " - " & dr("Cidade_Cliente"))
                                nomequalquer.SubItems.Add(dr("Status_Cliente"))

                                ListView1.Items.Add(nomequalquer)

                            End While
                            If (nomequalquer.Text = "") Then
                                MessageBox.Show("Nenhum Cliente encontrado! Tente Novamente!", "Informação não encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                            dr.Close()
                            FecharBD()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        NomeC = ListView1.FocusedItem.Text
        Localizar_Cliente.Show()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex = 0) Or (ComboBox1.SelectedIndex = 2) Or (ComboBox1.SelectedIndex = 3) Then
            TXT_Busca.ReadOnly = True
            ComboBox2.Visible = False
        Else
            If (ComboBox1.SelectedIndex = 4) Then
                TXT_Busca.Visible = False
                ComboBox2.Visible = True
            Else
                TXT_Busca.ReadOnly = False
            End If
        End If
    End Sub


    Private Sub LocalizarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem.Click
        Localizar_Funcionarios.Show()
    End Sub
    Private Sub AdimitirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdimitirToolStripMenuItem.Click
        Cadastro_Funcionario.Show()
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

    Private Sub Localizar_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub
End Class