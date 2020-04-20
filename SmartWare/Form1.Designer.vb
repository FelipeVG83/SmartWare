<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txt_Login = New System.Windows.Forms.TextBox()
        Me.TxT_senha = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBL_UsuarioIncorreto = New System.Windows.Forms.Label()
        Me.LBL_SenhaIncorreta = New System.Windows.Forms.Label()
        Me.LBL_UsuarioBloqueado = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(128, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Entrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Txt_Login
        '
        Me.Txt_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Login.Location = New System.Drawing.Point(158, 343)
        Me.Txt_Login.Name = "Txt_Login"
        Me.Txt_Login.Size = New System.Drawing.Size(100, 24)
        Me.Txt_Login.TabIndex = 1
        '
        'TxT_senha
        '
        Me.TxT_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxT_senha.Location = New System.Drawing.Point(158, 369)
        Me.TxT_senha.Name = "TxT_senha"
        Me.TxT_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxT_senha.Size = New System.Drawing.Size(100, 24)
        Me.TxT_senha.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(264, 346)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(134, 16)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Esqueceu o usuario?"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(264, 372)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(127, 16)
        Me.LinkLabel2.TabIndex = 6
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Esqueceu a senha?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Senha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(102, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 264)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'LBL_UsuarioIncorreto
        '
        Me.LBL_UsuarioIncorreto.AutoSize = True
        Me.LBL_UsuarioIncorreto.BackColor = System.Drawing.Color.Transparent
        Me.LBL_UsuarioIncorreto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_UsuarioIncorreto.ForeColor = System.Drawing.Color.Red
        Me.LBL_UsuarioIncorreto.Location = New System.Drawing.Point(25, 312)
        Me.LBL_UsuarioIncorreto.Name = "LBL_UsuarioIncorreto"
        Me.LBL_UsuarioIncorreto.Size = New System.Drawing.Size(404, 18)
        Me.LBL_UsuarioIncorreto.TabIndex = 8
        Me.LBL_UsuarioIncorreto.Text = "Esse usuário da SmartWare não existe. Insira outro usuário!"
        Me.LBL_UsuarioIncorreto.Visible = False
        '
        'LBL_SenhaIncorreta
        '
        Me.LBL_SenhaIncorreta.AutoSize = True
        Me.LBL_SenhaIncorreta.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SenhaIncorreta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SenhaIncorreta.ForeColor = System.Drawing.Color.Red
        Me.LBL_SenhaIncorreta.Location = New System.Drawing.Point(27, 312)
        Me.LBL_SenhaIncorreta.Name = "LBL_SenhaIncorreta"
        Me.LBL_SenhaIncorreta.Size = New System.Drawing.Size(335, 18)
        Me.LBL_SenhaIncorreta.TabIndex = 9
        Me.LBL_SenhaIncorreta.Text = "A senha inserida está incorreta. Tente novamente!"
        Me.LBL_SenhaIncorreta.Visible = False
        '
        'LBL_UsuarioBloqueado
        '
        Me.LBL_UsuarioBloqueado.AutoSize = True
        Me.LBL_UsuarioBloqueado.BackColor = System.Drawing.Color.Transparent
        Me.LBL_UsuarioBloqueado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_UsuarioBloqueado.ForeColor = System.Drawing.Color.Red
        Me.LBL_UsuarioBloqueado.Location = New System.Drawing.Point(25, 312)
        Me.LBL_UsuarioBloqueado.Name = "LBL_UsuarioBloqueado"
        Me.LBL_UsuarioBloqueado.Size = New System.Drawing.Size(427, 18)
        Me.LBL_UsuarioBloqueado.TabIndex = 10
        Me.LBL_UsuarioBloqueado.Text = "Usuário Bloqueado! Informe ao seu gerente para desbloqueá-lo!"
        Me.LBL_UsuarioBloqueado.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(360, 349)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(158, 130)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartWare.My.Resources.Resources._6_all_BG
        Me.ClientSize = New System.Drawing.Size(485, 495)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LBL_UsuarioBloqueado)
        Me.Controls.Add(Me.LBL_SenhaIncorreta)
        Me.Controls.Add(Me.LBL_UsuarioIncorreto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxT_senha)
        Me.Controls.Add(Me.Txt_Login)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(493, 522)
        Me.MinimumSize = New System.Drawing.Size(493, 522)
        Me.Name = "Form1"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Txt_Login As System.Windows.Forms.TextBox
    Friend WithEvents TxT_senha As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LBL_UsuarioIncorreto As System.Windows.Forms.Label
    Friend WithEvents LBL_SenhaIncorreta As System.Windows.Forms.Label
    Friend WithEvents LBL_UsuarioBloqueado As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
