namespace PerigosIntergalacticos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ptbProcuradoIcone = new PictureBox();
            lblProcuradoNome = new Label();
            lblProcuradoSobrenome = new Label();
            lblProcuradoTitulo = new Label();
            lblProcuradoIdade = new Label();
            lblProcuradoPeso = new Label();
            lblProcuradoAltura = new Label();
            lblProcuradoNivel = new Label();
            lblProcuradoEspecie = new Label();
            btnMaisInformacoes = new Button();
            lblMensagem = new Label();
            lblProcuradoRA = new Label();
            cbbSelecaoRA = new ComboBox();
            lblProcuradoGalaxia = new Label();
            lblProcuradoPlaneta = new Label();
            lblMensagemLocalizacao = new Label();
            lblMensagemProcurado = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbProcuradoIcone).BeginInit();
            SuspendLayout();
            // 
            // ptbProcuradoIcone
            // 
            ptbProcuradoIcone.Image = Properties.Resources.DefaultAvatarIcon;
            ptbProcuradoIcone.ImageLocation = "";
            ptbProcuradoIcone.InitialImage = Properties.Resources.DefaultAvatarIcon;
            ptbProcuradoIcone.Location = new Point(21, 47);
            ptbProcuradoIcone.Name = "ptbProcuradoIcone";
            ptbProcuradoIcone.Size = new Size(208, 230);
            ptbProcuradoIcone.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbProcuradoIcone.TabIndex = 0;
            ptbProcuradoIcone.TabStop = false;
            // 
            // lblProcuradoNome
            // 
            lblProcuradoNome.AutoSize = true;
            lblProcuradoNome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcuradoNome.Location = new Point(262, 93);
            lblProcuradoNome.Name = "lblProcuradoNome";
            lblProcuradoNome.Size = new Size(54, 18);
            lblProcuradoNome.TabIndex = 3;
            lblProcuradoNome.Text = "Nome:";
            // 
            // lblProcuradoSobrenome
            // 
            lblProcuradoSobrenome.AutoSize = true;
            lblProcuradoSobrenome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcuradoSobrenome.Location = new Point(505, 93);
            lblProcuradoSobrenome.Name = "lblProcuradoSobrenome";
            lblProcuradoSobrenome.Size = new Size(94, 18);
            lblProcuradoSobrenome.TabIndex = 4;
            lblProcuradoSobrenome.Text = "Sobrenome:";
            // 
            // lblProcuradoTitulo
            // 
            lblProcuradoTitulo.AutoSize = true;
            lblProcuradoTitulo.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcuradoTitulo.Location = new Point(257, 12);
            lblProcuradoTitulo.Name = "lblProcuradoTitulo";
            lblProcuradoTitulo.Size = new Size(244, 36);
            lblProcuradoTitulo.TabIndex = 5;
            lblProcuradoTitulo.Text = "Procurado Titulo";
            // 
            // lblProcuradoIdade
            // 
            lblProcuradoIdade.AutoSize = true;
            lblProcuradoIdade.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcuradoIdade.Location = new Point(262, 164);
            lblProcuradoIdade.Name = "lblProcuradoIdade";
            lblProcuradoIdade.Size = new Size(51, 18);
            lblProcuradoIdade.TabIndex = 6;
            lblProcuradoIdade.Text = "Idade:";
            // 
            // lblProcuradoPeso
            // 
            lblProcuradoPeso.AutoSize = true;
            lblProcuradoPeso.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcuradoPeso.Location = new Point(505, 199);
            lblProcuradoPeso.Name = "lblProcuradoPeso";
            lblProcuradoPeso.Size = new Size(49, 18);
            lblProcuradoPeso.TabIndex = 7;
            lblProcuradoPeso.Text = "Peso:";
            // 
            // lblProcuradoAltura
            // 
            lblProcuradoAltura.AutoSize = true;
            lblProcuradoAltura.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcuradoAltura.Location = new Point(262, 199);
            lblProcuradoAltura.Name = "lblProcuradoAltura";
            lblProcuradoAltura.Size = new Size(52, 18);
            lblProcuradoAltura.TabIndex = 8;
            lblProcuradoAltura.Text = "Altura:";
            // 
            // lblProcuradoNivel
            // 
            lblProcuradoNivel.AutoSize = true;
            lblProcuradoNivel.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold);
            lblProcuradoNivel.Location = new Point(257, 234);
            lblProcuradoNivel.Name = "lblProcuradoNivel";
            lblProcuradoNivel.Size = new Size(312, 43);
            lblProcuradoNivel.TabIndex = 10;
            lblProcuradoNivel.Text = "Nivel Do Procurado:";
            // 
            // lblProcuradoEspecie
            // 
            lblProcuradoEspecie.AutoSize = true;
            lblProcuradoEspecie.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcuradoEspecie.Location = new Point(505, 164);
            lblProcuradoEspecie.Name = "lblProcuradoEspecie";
            lblProcuradoEspecie.Size = new Size(70, 18);
            lblProcuradoEspecie.TabIndex = 13;
            lblProcuradoEspecie.Text = "Especie:";
            // 
            // btnMaisInformacoes
            // 
            btnMaisInformacoes.Location = new Point(21, 468);
            btnMaisInformacoes.Name = "btnMaisInformacoes";
            btnMaisInformacoes.Size = new Size(117, 29);
            btnMaisInformacoes.TabIndex = 14;
            btnMaisInformacoes.Text = "Mais Informações";
            btnMaisInformacoes.UseVisualStyleBackColor = true;
            btnMaisInformacoes.Click += btnMaisInformacoes_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(144, 475);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(100, 15);
            lblMensagem.TabIndex = 15;
            lblMensagem.Text = "Status do Sistema";
            // 
            // lblProcuradoRA
            // 
            lblProcuradoRA.AutoSize = true;
            lblProcuradoRA.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcuradoRA.Location = new Point(262, 61);
            lblProcuradoRA.Name = "lblProcuradoRA";
            lblProcuradoRA.Size = new Size(34, 18);
            lblProcuradoRA.TabIndex = 18;
            lblProcuradoRA.Text = "RA:";
            // 
            // cbbSelecaoRA
            // 
            cbbSelecaoRA.FormattingEnabled = true;
            cbbSelecaoRA.Items.AddRange(new object[] { "P2468H7", "G7862D1", "C9876J5", "H1234K8", "M5678N9", "V4321W6" });
            cbbSelecaoRA.Location = new Point(21, 12);
            cbbSelecaoRA.Name = "cbbSelecaoRA";
            cbbSelecaoRA.Size = new Size(208, 23);
            cbbSelecaoRA.TabIndex = 1;
            cbbSelecaoRA.TextChanged += cbbSelecaoRA_TextChanged;
            // 
            // lblProcuradoGalaxia
            // 
            lblProcuradoGalaxia.AutoSize = true;
            lblProcuradoGalaxia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcuradoGalaxia.Location = new Point(262, 129);
            lblProcuradoGalaxia.Name = "lblProcuradoGalaxia";
            lblProcuradoGalaxia.Size = new Size(65, 18);
            lblProcuradoGalaxia.TabIndex = 22;
            lblProcuradoGalaxia.Text = "Galaxia:";
            // 
            // lblProcuradoPlaneta
            // 
            lblProcuradoPlaneta.AutoSize = true;
            lblProcuradoPlaneta.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProcuradoPlaneta.Location = new Point(505, 129);
            lblProcuradoPlaneta.Name = "lblProcuradoPlaneta";
            lblProcuradoPlaneta.Size = new Size(65, 18);
            lblProcuradoPlaneta.TabIndex = 23;
            lblProcuradoPlaneta.Text = "Planeta:";
            // 
            // lblMensagemLocalizacao
            // 
            lblMensagemLocalizacao.AutoSize = true;
            lblMensagemLocalizacao.Location = new Point(21, 450);
            lblMensagemLocalizacao.Name = "lblMensagemLocalizacao";
            lblMensagemLocalizacao.Size = new Size(119, 15);
            lblMensagemLocalizacao.TabIndex = 24;
            lblMensagemLocalizacao.Text = "Status da Localização";
            // 
            // lblMensagemProcurado
            // 
            lblMensagemProcurado.AutoSize = true;
            lblMensagemProcurado.Location = new Point(21, 425);
            lblMensagemProcurado.Name = "lblMensagemProcurado";
            lblMensagemProcurado.Size = new Size(114, 15);
            lblMensagemProcurado.TabIndex = 25;
            lblMensagemProcurado.Text = "Status do Procurado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(862, 509);
            Controls.Add(lblMensagemProcurado);
            Controls.Add(lblMensagemLocalizacao);
            Controls.Add(lblProcuradoPlaneta);
            Controls.Add(lblProcuradoGalaxia);
            Controls.Add(cbbSelecaoRA);
            Controls.Add(lblProcuradoRA);
            Controls.Add(lblMensagem);
            Controls.Add(btnMaisInformacoes);
            Controls.Add(lblProcuradoEspecie);
            Controls.Add(lblProcuradoNivel);
            Controls.Add(lblProcuradoAltura);
            Controls.Add(lblProcuradoPeso);
            Controls.Add(lblProcuradoIdade);
            Controls.Add(lblProcuradoTitulo);
            Controls.Add(lblProcuradoSobrenome);
            Controls.Add(lblProcuradoNome);
            Controls.Add(ptbProcuradoIcone);
            MaximumSize = new Size(878, 548);
            MinimumSize = new Size(878, 548);
            Name = "Form1";
            Text = "Procurados Intergalacticos";
            ((System.ComponentModel.ISupportInitialize)ptbProcuradoIcone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbProcuradoIcone;
        private ToolStripSplitButton toolStripSplitButton1;
        private Label lblProcuradoNome;
        private Label lblProcuradoSobrenome;
        private Label lblProcuradoTitulo;
        private Label lblProcuradoIdade;
        private Label lblProcuradoPeso;
        private Label lblProcuradoAltura;
        private Label lblProcuradoNivel;
        private Label lblProcuradoEspecie;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripButton toolStripButton1;
        private ToolStripComboBox toolStripComboBox2;
        private Button btnMaisInformacoes;
        private Label lblMensagem;
        private Label lblProcuradoRA;
        private ComboBox cbbSelecaoRA;
        private Label lblProcuradoGalaxia;
        private Label lblProcuradoPlaneta;
        private Label lblMensagemLocalizacao;
        private Label lblMensagemProcurado;
    }
}
