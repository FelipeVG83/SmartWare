Imports MySql.Data.MySqlClient
Public Class Localizar_Funcionarios

    Private Sub ListView1_mouseDoubleClick(sender As Object, e As EventArgs) Handles ListView1.MouseDoubleClick
        NomeF = ListView1.FocusedItem.Text
        Localizar_Funcionario.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Pesquisar Todos
        If (ComboBox1.SelectedIndex = 0) Then
            ListView1.Items.Clear()
            Dim comando As New MySqlCommand("Select Cod_Funcionario, Nome_Funcionario, Cargo_Funcionario, Status_Funcionario from Funcionarios", Conexao)
            AbrirBD()
            Dim dr As MySqlDataReader
            dr = comando.ExecuteReader
            While dr.Read
                Dim nomequalquer As New ListViewItem
                nomequalquer.Text = dr("Cod_Funcionario")
                nomequalquer.SubItems.Add(dr("Nome_Funcionario"))
                nomequalquer.SubItems.Add(dr("Cargo_Funcionario"))
                nomequalquer.SubItems.Add(dr("Status_Funcionario"))
                ListView1.Items.Add(nomequalquer)
            End While
            dr.Close()
            FecharBD()
        Else
            'Pesquisar por Nome
            If (ComboBox1.SelectedIndex = 1) Then
                ListView1.Items.Clear()
                Dim comando As New MySqlCommand("Select Cod_Funcionario, Nome_Funcionario, Cargo_Funcionario, Status_Funcionario from Funcionarios where Nome_Funcionario = @Nome_Funcionario ", Conexao)
                AbrirBD()
                comando.Parameters.Add("@Nome_Funcionario", MySqlDbType.VarChar)
                comando.Parameters("@Nome_Funcionario").Value = TXT_Busca.Text
                Dim dr As MySqlDataReader
                dr = comando.ExecuteReader
                Dim nomequalquer As New ListViewItem
                While dr.Read
                    nomequalquer.Text = dr("Cod_Funcionario")
                    nomequalquer.SubItems.Add(dr("Nome_Funcionario"))
                    nomequalquer.SubItems.Add(dr("Cargo_Funcionario"))
                    nomequalquer.SubItems.Add(dr("Status_Funcionario"))
                    ListView1.Items.Add(nomequalquer)
                End While
                If (nomequalquer.Text = "") Then
                    MessageBox.Show("Nenhum funcionário encontrado! Tente Novamente!", "Informação não encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                dr.Close()
                FecharBD()
            Else
                'Pesquisar por Cargo
                If (ComboBox1.SelectedIndex = 2) Then
                    ListView1.Items.Clear()
                    Dim comando As New MySqlCommand("Select Cod_Funcionario, Nome_Funcionario, Cargo_Funcionario, Status_Funcionario from Funcionarios where Cargo_Funcionario = @Cargo_Funcionario", Conexao)
                    AbrirBD()
                    comando.Parameters.Add("@Cargo_Funcionario", MySqlDbType.VarChar)
                    comando.Parameters("@Cargo_Funcionario").Value = TXT_Busca.Text
                    Dim dr As MySqlDataReader
                    dr = comando.ExecuteReader
                    Dim nomequalquer As New ListViewItem
                    While dr.Read
                        nomequalquer.Text = dr("Cod_Funcionario")
                        nomequalquer.SubItems.Add(dr("Nome_Funcionario"))
                        nomequalquer.SubItems.Add(dr("Cargo_Funcionario"))
                        nomequalquer.SubItems.Add(dr("Status_Funcionario"))
                        ListView1.Items.Add(nomequalquer)
                    End While
                    dr.Close()
                    FecharBD()
                Else
                    'Pesquisar por Departamento
                    If (ComboBox1.SelectedIndex = 3) Then
                        ListView1.Items.Clear()
                        Dim comando As New MySqlCommand("Select Cod_Funcionario, Nome_Funcionario, Cargo_Funcionario, Status_Funcionario from Funcionarios where Depto_Funcionario = @Depto_Funcionario", Conexao)
                        AbrirBD()
                        comando.Parameters.Add("@Depto_Funcionario", MySqlDbType.VarChar)
                        comando.Parameters("@Depto_Funcionario").Value = TXT_Busca.Text
                        Dim dr As MySqlDataReader
                        dr = comando.ExecuteReader
                        Dim nomequalquer As New ListViewItem
                        While dr.Read
                            nomequalquer.Text = dr("Cod_Funcionario")
                            nomequalquer.SubItems.Add(dr("Nome_Funcionario"))
                            nomequalquer.SubItems.Add(dr("Cargo_Funcionario"))
                            nomequalquer.SubItems.Add(dr("Status_Funcionario"))
                            ListView1.Items.Add(nomequalquer)
                        End While
                        dr.Close()
                        FecharBD()
                    Else
                        'Pesquisar por Status dos Funcionários
                        If (ComboBox1.SelectedIndex = 4) Then
                            TXT_Busca.Visible = False
                            CMB_Status.Visible = True
                            ListView1.Items.Clear()
                            Dim comando As New MySqlCommand("Select Cod_Funcionario, Nome_Funcionario, Cargo_Funcionario, Status_Funcionario from Funcionarios where Status_Funcionario = @Status_Funcionario", Conexao)
                            AbrirBD()
                            comando.Parameters.Add("@Status_Funcionario", MySqlDbType.VarChar)
                            comando.Parameters("@Status_Funcionario").Value = CMB_Status.SelectedItem
                            Dim dr As MySqlDataReader
                            dr = comando.ExecuteReader
                            Dim nomequalquer As New ListViewItem
                            While dr.Read
                                nomequalquer.Text = dr("Cod_Funcionario")
                                nomequalquer.SubItems.Add(dr("Nome_Funcionario"))
                                nomequalquer.SubItems.Add(dr("Cargo_Funcionario"))
                                nomequalquer.SubItems.Add(dr("Status_Funcionario"))
                                ListView1.Items.Add(nomequalquer)
                            End While
                            If (nomequalquer.Text = "") Then
                                MessageBox.Show("Nenhum Funcionário encontrado! Tente Novamente!", "Informação não encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                            dr.Close()
                            FecharBD()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex = 0) Then
            TXT_Busca.Visible = True
            TXT_Busca.ReadOnly = True
            CMB_Status.Visible = False
            CMB_Depto.Visible = False
        Else
            If (ComboBox1.SelectedIndex = 1) Then
                TXT_Busca.Visible = True
                TXT_Busca.ReadOnly = False
                CMB_Status.Visible = False
                CMB_Depto.Visible = False
            Else
                If (ComboBox1.SelectedIndex = 2) Then
                    TXT_Busca.Visible = True
                    TXT_Busca.ReadOnly = False
                    CMB_Status.Visible = False
                    CMB_Depto.Visible = False
                Else
                    If (ComboBox1.SelectedIndex = 3) Then
                        TXT_Busca.Visible = False
                        TXT_Busca.ReadOnly = True
                        CMB_Depto.Visible = True
                        CMB_Status.Visible = False
                    Else
                        TXT_Busca.Visible = False
                        TXT_Busca.ReadOnly = True
                        CMB_Depto.Visible = False
                        CMB_Status.Visible = True
                    End If
                End If
            End If
        End If
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

  
    Private Sub Localizar_Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TST_NomeLogado.Text = MenuLogado
        TXT_Data.Text = Today & " - " & Horario(TimeOfDay.Hour) & ":" & Min(TimeOfDay.Minute)
    End Sub
End Class