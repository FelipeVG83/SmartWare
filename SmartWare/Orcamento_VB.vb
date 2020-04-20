Public Class Orcamento_VB

    Inherits Windows.Forms.Form
    Dim X, Y, Ya, Xa, TesteLogo As Integer
    Dim lbl, texto, logo As Boolean
    Dim Nome, Del As String
    Dim qtdeLabel As Integer = -1
    Dim qtdeTexto As Integer = -1
    Dim qtdeLogo As Integer = -1
    Dim qtdeDiv As Integer = -1
    Dim fdlg As OpenFileDialog = New OpenFileDialog()
    Dim PictureBox, div As New PictureBox()
    Dim imagem As String
    Dim Style As String

    Private Function NomeLabel()
        qtdeLabel = (qtdeLabel + 1)
        Return "Texto" & qtdeLabel
    End Function
    Private Function NomeDiv()
        qtdeDiv = (qtdeDiv + 1)
        Return "Div" & qtdeDiv
    End Function
    Private Function Nometxtbox()
        qtdeTexto = (qtdeTexto + 1)
        Return "txtbox" & qtdeTexto
    End Function
    Private Function NomeLogo()
        qtdeLogo = (qtdeLogo + 1)
        Return "Logo" & qtdeLogo
    End Function


    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Preco.MouseClick
        Dim lblCount As New Label()
        Dim txtCount As New TextBox()
        Dim imgcount As New PictureBox()
        Dim txtboxcount As New PictureBox()

        X = e.X
        Y = e.Y
        TXT_LocalizaçãoX.Value = e.X
        TXT_LocalizaçãoY.Value = e.Y
        If (RDB_Button.Checked = True) Then
            Style = ComboBox1.Text
            With imgcount
                .Name = Nometxtbox()
                .Location = New System.Drawing.Point(X, Y)
                .Size() = New System.Drawing.Size(Xa, Ya)
                .Visible = True
                PictureBox.Width = Xa
                PictureBox.Height = Ya
                .BackgroundImage = My.Resources.Button
                .BackgroundImageLayout = ImageLayout.Stretch
                ' .SizeMode = PictureBoxSizeMode.Zoom
            End With
            Del = imgcount.Name
            ListBox1.Items.Add(Del)
            Preco.Controls.Add(imgcount)
        End If
        If (Rdb_txtbox.Checked = True) Then
            Style = ComboBox1.Text
            With imgcount
                .Name = Nometxtbox()
                .Location = New System.Drawing.Point(X, Y)
                .Size() = New System.Drawing.Size(Xa, Ya)
                .Visible = True
                PictureBox.Width = Xa
                PictureBox.Height = Ya
                .BackgroundImage = My.Resources.TextBox
                .BackgroundImageLayout = ImageLayout.Stretch
                ' .SizeMode = PictureBoxSizeMode.Zoom
            End With
            Del = imgcount.Name
            ListBox1.Items.Add(Del)
            Preco.Controls.Add(imgcount)
        End If



        If (RDB_Logo.Checked = True) Then
            If TXT_Imagem.Text = "" Then
                MessageBox.Show("Selecione uma imgagem")
                Exit Sub
            End If
            If ComboBox1.Text = "" Then
                MessageBox.Show("Selecione um tipo de tamanho")
                Exit Sub
            End If
            With imgcount
                .Name = NomeLogo()
                .Location = New System.Drawing.Point(X, Y)
                .Size() = New System.Drawing.Size(Xa, Ya)
                .Visible = True
                PictureBox.Width = Xa
                PictureBox.Height = Ya
                .BackgroundImage = Image.FromFile(TXT_Imagem.Text)
                .BackgroundImageLayout = ComboBox1.Text
            End With
            Del = imgcount.Name
            ListBox1.Items.Add(Del)
            Preco.Controls.Add(imgcount)

        Else
            If RDB_Label.Checked = True Then
                With lblCount
                    .Name = NomeLabel()
                    .Location = New System.Drawing.Point(X, Y)
                    .Size() = New System.Drawing.Size(Xa, Ya)
                    .Text = txt_texto.Text
                    .Font = FontDialog1.Font
                    .ForeColor = ColorDialog2.Color
                    .Visible = True
                    .BackColor = ColorDialog1.Color
                    lblCount.Width = Xa
                    lblCount.Height = Ya
                End With
                Del = lblCount.Name
                ListBox1.Items.Add(Del)
                Preco.Controls.Add(lblCount)


            End If
        End If

    End Sub
    Private Sub Orcamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl = False
        texto = False
        logo = False
        TXT_TamanhoX.Maximum = Preco.Width
        TXT_TamanhoY.Maximum = Preco.Height
        TXT_LocalizaçãoX.Maximum = Preco.Width
        TXT_LocalizaçãoY.Maximum = Preco.Height
    End Sub
    Private Sub LBL_Logo_Click(sender As Object, e As EventArgs) Handles LBL_Logo.Click
        txt_texto.ReadOnly = True
        RDB_Logo.Checked = True
    End Sub
    Private Sub TXT_TamanhoX_ValueChanged(sender As Object, e As EventArgs) Handles TXT_TamanhoX.ValueChanged
        Xa = TXT_TamanhoX.Value
        Ya = TXT_TamanhoY.Value
        If (RDB_Label.Checked = True) Then
            '   Me.lblCount.Width = Xa
            '     Me.lblCount.Height = Ya
        End If
    End Sub
    Private Sub TXT_TamanhoY_ValueChanged(sender As Object, e As EventArgs) Handles TXT_TamanhoY.ValueChanged
        Xa = TXT_TamanhoX.Value
        Ya = TXT_TamanhoY.Value
        If (RDB_Label.Checked = True) Then
            '    lblCount.Width = Xa
            '   lblCount.Height = Ya
        End If
    End Sub
    Private Sub txt_texto_TextChanged(sender As Object, e As EventArgs) Handles txt_texto.TextChanged
        Nome = txt_texto.Text
    End Sub
    Private Sub TXT_LocalizaçãoX_ValueChanged(sender As Object, e As EventArgs) Handles TXT_LocalizaçãoX.ValueChanged
        X = TXT_LocalizaçãoX.Value
        Y = TXT_LocalizaçãoY.Value
    End Sub
    Private Sub TXT_LocalizaçãoY_ValueChanged(sender As Object, e As EventArgs) Handles TXT_LocalizaçãoY.ValueChanged
        X = TXT_LocalizaçãoX.Value
        Y = TXT_LocalizaçãoY.Value
    End Sub
    Private Sub BTN_Fonte_Click(sender As Object, e As EventArgs) Handles BTN_Fonte.Click
        FontDialog1.ShowDialog()
        TXT_Fonte.Text = FontDialog1.Font.Name & "," & FontDialog1.Font.Size
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_Label.CheckedChanged
        If (RDB_Label.Checked = True) Then
            lbl = True
            LBL_Tamanho.Visible = True
            TXT_TamanhoX.Visible = True
            TXT_TamanhoY.Visible = True
            txt_texto.Visible = True
            LBL_X.Visible = True
            LBL_Texto2.Visible = True
            LBL_Localização.Visible = True
            TXT_LocalizaçãoX.Visible = True
            TXT_LocalizaçãoY.Visible = True
            LBL_X2.Visible = True
            LBL_Fonte.Visible = True
            TXT_Fonte.Visible = True
            LBL_Cor.Visible = True
            BTN_Cor.Visible = True
            BTN_Fonte.Visible = True
            LBL_CorFonte.Visible = True
            BTN_CorFonte.Visible = True

        End If
    End Sub
    Private Sub LBL_Label_Click(sender As Object, e As EventArgs) Handles LBL_Label.Click
        RDB_Label.Checked = True
    End Sub
    Private Sub BTN_Cor_Click(sender As Object, e As EventArgs) Handles BTN_Cor.Click
        ColorDialog1.ShowDialog()
        BTN_Cor.BackColor = ColorDialog1.Color
        BTN_Cor.Text = ColorDialog1.Color.Name
        If (RDB_Label.Checked = True) Then

        End If
    End Sub
    Private Sub BTN_CorFonte_Click(sender As Object, e As EventArgs) Handles BTN_CorFonte.Click
        ColorDialog2.ShowDialog()
        BTN_CorFonte.BackColor = ColorDialog2.Color
        BTN_CorFonte.Text = ColorDialog2.Color.Name
        If (RDB_Label.Checked = True) Then

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ListBox1.SelectedIndex < 0) Then
            MessageBox.Show("Selecione um objeto para apagá-lo!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim c As Control
            For Each c In Me.Preco.Controls
                If c.Name = ListBox1.SelectedItem.ToString Then
                    c.Dispose()
                End If
            Next

            Dim Selecao As Integer
            Selecao = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(Selecao)

        End If
    End Sub
    Private Sub BTN_Imagem_Click(sender As Object, e As EventArgs) Handles BTN_Imagem.Click
        OpenFileDialog1.Filter = "Imagem|*.jpg"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> Nothing Then
            TXT_Imagem.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ListBox1.SelectedIndex < 0) Then

        Else
            Dim c As Control
            For Each c In Me.Preco.Controls
                If c.Name = ListBox1.SelectedItem Then
                    c.Text = txt_texto.Text
                    c.ForeColor = ColorDialog2.Color
                    c.BackColor = ColorDialog1.Color
                    c.Font = FontDialog1.Font
                    c.Location = New System.Drawing.Point(TXT_LocalizaçãoX.Value, TXT_LocalizaçãoY.Value)
                    c.Width = TXT_TamanhoX.Value
                    c.Height = TXT_TamanhoY.Value
                End If
            Next
        End If
    End Sub


    Private Sub txtbox_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_txtbox.CheckedChanged
        TXT_TamanhoX.Value = 117
        TXT_TamanhoY.Value = 20
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i = 0 To ListBox1.Items.Count - 1
            Dim c As Control
            For Each c In Me.Preco.Controls
                If c.Name = ListBox1.Items(i).ToString Then
                    c.Dispose()
                End If
            Next
        Next
        ListBox1.Items.Clear()
    End Sub

  
    Private Sub RDB_Button_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_Button.CheckedChanged
        TXT_TamanhoX.Value = 77
        TXT_TamanhoY.Value = 23
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

    Private Sub LocalizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LocalizarToolStripMenuItem1.Click
        Localizar_Produtos.Show()
    End Sub
End Class