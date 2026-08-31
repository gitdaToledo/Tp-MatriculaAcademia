namespace Tp___Matrícula_na_Academia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbManha = new System.Windows.Forms.RadioButton();
            this.rbTarde = new System.Windows.Forms.RadioButton();
            this.rbNoite = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.ckYoga = new System.Windows.Forms.CheckBox();
            this.ckMed = new System.Windows.Forms.CheckBox();
            this.ckTai = new System.Windows.Forms.CheckBox();
            this.ckFeng = new System.Windows.Forms.CheckBox();
            this.ckCrom = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtVlPagar = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.listBoxModa = new System.Windows.Forms.ListBox();
            this.gpPeriodo = new System.Windows.Forms.GroupBox();
            this.gpCortesia = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpModal = new System.Windows.Forms.GroupBox();
            this.btnSetaEsquerdaDupla = new System.Windows.Forms.Button();
            this.btnSetaDireitaDupla = new System.Windows.Forms.Button();
            this.btnSetaEsquerda = new System.Windows.Forms.Button();
            this.btnSetaDireita = new System.Windows.Forms.Button();
            this.listBoxEscolhido = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpPeriodo.SuspendLayout();
            this.gpCortesia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpModal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // rbManha
            // 
            this.rbManha.AutoSize = true;
            this.rbManha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbManha.Location = new System.Drawing.Point(6, 19);
            this.rbManha.Name = "rbManha";
            this.rbManha.Size = new System.Drawing.Size(58, 17);
            this.rbManha.TabIndex = 3;
            this.rbManha.TabStop = true;
            this.rbManha.Text = "Manhã";
            this.rbManha.UseVisualStyleBackColor = true;
            this.rbManha.CheckedChanged += new System.EventHandler(this.rbPeriodo_CheckedChanged);
            // 
            // rbTarde
            // 
            this.rbTarde.AutoSize = true;
            this.rbTarde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTarde.Location = new System.Drawing.Point(192, 19);
            this.rbTarde.Name = "rbTarde";
            this.rbTarde.Size = new System.Drawing.Size(53, 17);
            this.rbTarde.TabIndex = 4;
            this.rbTarde.TabStop = true;
            this.rbTarde.Text = "Tarde";
            this.rbTarde.UseVisualStyleBackColor = true;
            this.rbTarde.CheckedChanged += new System.EventHandler(this.rbPeriodo_CheckedChanged);
            // 
            // rbNoite
            // 
            this.rbNoite.AutoSize = true;
            this.rbNoite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNoite.Location = new System.Drawing.Point(359, 19);
            this.rbNoite.Name = "rbNoite";
            this.rbNoite.Size = new System.Drawing.Size(50, 17);
            this.rbNoite.TabIndex = 5;
            this.rbNoite.TabStop = true;
            this.rbNoite.Text = "Noite";
            this.rbNoite.UseVisualStyleBackColor = true;
            this.rbNoite.CheckedChanged += new System.EventHandler(this.rbPeriodo_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(84, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(362, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(84, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(362, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // ckYoga
            // 
            this.ckYoga.AutoSize = true;
            this.ckYoga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckYoga.Location = new System.Drawing.Point(6, 19);
            this.ckYoga.Name = "ckYoga";
            this.ckYoga.Size = new System.Drawing.Size(51, 17);
            this.ckYoga.TabIndex = 8;
            this.ckYoga.Text = "Yoga";
            this.ckYoga.UseVisualStyleBackColor = true;
            this.ckYoga.Click += new System.EventHandler(this.ckCortesia_CheckedChanged);
            // 
            // ckMed
            // 
            this.ckMed.AutoSize = true;
            this.ckMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckMed.Location = new System.Drawing.Point(6, 42);
            this.ckMed.Name = "ckMed";
            this.ckMed.Size = new System.Drawing.Size(76, 17);
            this.ckMed.TabIndex = 9;
            this.ckMed.Text = "Meditação";
            this.ckMed.UseVisualStyleBackColor = true;
            this.ckMed.Click += new System.EventHandler(this.ckCortesia_CheckedChanged);
            // 
            // ckTai
            // 
            this.ckTai.AutoSize = true;
            this.ckTai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckTai.Location = new System.Drawing.Point(6, 65);
            this.ckTai.Name = "ckTai";
            this.ckTai.Size = new System.Drawing.Size(93, 17);
            this.ckTai.TabIndex = 10;
            this.ckTai.Text = "Tai Chi Chuan";
            this.ckTai.UseVisualStyleBackColor = true;
            this.ckTai.Click += new System.EventHandler(this.ckCortesia_CheckedChanged);
            // 
            // ckFeng
            // 
            this.ckFeng.AutoSize = true;
            this.ckFeng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckFeng.Location = new System.Drawing.Point(6, 88);
            this.ckFeng.Name = "ckFeng";
            this.ckFeng.Size = new System.Drawing.Size(74, 17);
            this.ckFeng.TabIndex = 11;
            this.ckFeng.Text = "Feng Shui";
            this.ckFeng.UseVisualStyleBackColor = true;
            this.ckFeng.Click += new System.EventHandler(this.ckCortesia_CheckedChanged);
            // 
            // ckCrom
            // 
            this.ckCrom.AutoSize = true;
            this.ckCrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckCrom.Location = new System.Drawing.Point(6, 111);
            this.ckCrom.Name = "ckCrom";
            this.ckCrom.Size = new System.Drawing.Size(88, 17);
            this.ckCrom.TabIndex = 12;
            this.ckCrom.Text = "Cromoterapia";
            this.ckCrom.UseVisualStyleBackColor = true;
            this.ckCrom.Click += new System.EventHandler(this.ckCortesia_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cortesia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Valor a Pagar(R$)";
            // 
            // txtQtd
            // 
            this.txtQtd.ForeColor = System.Drawing.Color.Red;
            this.txtQtd.Location = new System.Drawing.Point(81, 38);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 20);
            this.txtQtd.TabIndex = 17;
            // 
            // txtCor
            // 
            this.txtCor.ForeColor = System.Drawing.Color.Red;
            this.txtCor.Location = new System.Drawing.Point(271, 38);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 18;
            // 
            // txtVlPagar
            // 
            this.txtVlPagar.ForeColor = System.Drawing.Color.Black;
            this.txtVlPagar.Location = new System.Drawing.Point(500, 34);
            this.txtVlPagar.Name = "txtVlPagar";
            this.txtVlPagar.Size = new System.Drawing.Size(100, 20);
            this.txtVlPagar.TabIndex = 19;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(31, 412);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 20;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // listBoxModa
            // 
            this.listBoxModa.DisplayMember = "Ginástica Ritmica";
            this.listBoxModa.FormattingEnabled = true;
            this.listBoxModa.Items.AddRange(new object[] {
            "Ginástica Rítmica",
            "Hidroginástica",
            "Musculação",
            "Natação",
            "Patinação",
            "Pilates",
            "RPM",
            "Squash"});
            this.listBoxModa.Location = new System.Drawing.Point(9, 19);
            this.listBoxModa.Name = "listBoxModa";
            this.listBoxModa.Size = new System.Drawing.Size(148, 134);
            this.listBoxModa.Sorted = true;
            this.listBoxModa.TabIndex = 22;
            this.listBoxModa.SelectedIndexChanged += new System.EventHandler(this.listBoxModa_SelectedIndexChanged);
            // 
            // gpPeriodo
            // 
            this.gpPeriodo.Controls.Add(this.rbTarde);
            this.gpPeriodo.Controls.Add(this.rbNoite);
            this.gpPeriodo.Controls.Add(this.rbManha);
            this.gpPeriodo.Location = new System.Drawing.Point(31, 86);
            this.gpPeriodo.Name = "gpPeriodo";
            this.gpPeriodo.Size = new System.Drawing.Size(415, 52);
            this.gpPeriodo.TabIndex = 24;
            this.gpPeriodo.TabStop = false;
            this.gpPeriodo.Text = "Período";
            // 
            // gpCortesia
            // 
            this.gpCortesia.Controls.Add(this.ckYoga);
            this.gpCortesia.Controls.Add(this.ckMed);
            this.gpCortesia.Controls.Add(this.ckTai);
            this.gpCortesia.Controls.Add(this.ckFeng);
            this.gpCortesia.Controls.Add(this.ckCrom);
            this.gpCortesia.Location = new System.Drawing.Point(466, 144);
            this.gpCortesia.Name = "gpCortesia";
            this.gpCortesia.Size = new System.Drawing.Size(171, 160);
            this.gpCortesia.TabIndex = 25;
            this.gpCortesia.TabStop = false;
            this.gpCortesia.Text = "Cortesia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVlPagar);
            this.groupBox1.Controls.Add(this.txtCor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(31, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 81);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // gpModal
            // 
            this.gpModal.Controls.Add(this.btnSetaEsquerdaDupla);
            this.gpModal.Controls.Add(this.btnSetaDireitaDupla);
            this.gpModal.Controls.Add(this.btnSetaEsquerda);
            this.gpModal.Controls.Add(this.btnSetaDireita);
            this.gpModal.Controls.Add(this.listBoxEscolhido);
            this.gpModal.Controls.Add(this.listBoxModa);
            this.gpModal.Location = new System.Drawing.Point(31, 144);
            this.gpModal.Name = "gpModal";
            this.gpModal.Size = new System.Drawing.Size(415, 160);
            this.gpModal.TabIndex = 27;
            this.gpModal.TabStop = false;
            this.gpModal.Text = "Modalidade";
            // 
            // btnSetaEsquerdaDupla
            // 
            this.btnSetaEsquerdaDupla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetaEsquerdaDupla.Location = new System.Drawing.Point(170, 114);
            this.btnSetaEsquerdaDupla.Name = "btnSetaEsquerdaDupla";
            this.btnSetaEsquerdaDupla.Size = new System.Drawing.Size(75, 23);
            this.btnSetaEsquerdaDupla.TabIndex = 27;
            this.btnSetaEsquerdaDupla.Text = "<<";
            this.btnSetaEsquerdaDupla.UseVisualStyleBackColor = true;
            this.btnSetaEsquerdaDupla.Click += new System.EventHandler(this.btnSetaEsquerdaDupla_Click);
            // 
            // btnSetaDireitaDupla
            // 
            this.btnSetaDireitaDupla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetaDireitaDupla.Location = new System.Drawing.Point(170, 85);
            this.btnSetaDireitaDupla.Name = "btnSetaDireitaDupla";
            this.btnSetaDireitaDupla.Size = new System.Drawing.Size(75, 23);
            this.btnSetaDireitaDupla.TabIndex = 26;
            this.btnSetaDireitaDupla.Text = ">>";
            this.btnSetaDireitaDupla.UseVisualStyleBackColor = true;
            this.btnSetaDireitaDupla.Click += new System.EventHandler(this.btnSetaDireitaDupla_Click);
            // 
            // btnSetaEsquerda
            // 
            this.btnSetaEsquerda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetaEsquerda.Location = new System.Drawing.Point(170, 56);
            this.btnSetaEsquerda.Name = "btnSetaEsquerda";
            this.btnSetaEsquerda.Size = new System.Drawing.Size(75, 23);
            this.btnSetaEsquerda.TabIndex = 25;
            this.btnSetaEsquerda.Text = "<";
            this.btnSetaEsquerda.UseVisualStyleBackColor = true;
            this.btnSetaEsquerda.Click += new System.EventHandler(this.btnSetaEsquerda_Click);
            // 
            // btnSetaDireita
            // 
            this.btnSetaDireita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetaDireita.Location = new System.Drawing.Point(170, 27);
            this.btnSetaDireita.Name = "btnSetaDireita";
            this.btnSetaDireita.Size = new System.Drawing.Size(75, 23);
            this.btnSetaDireita.TabIndex = 24;
            this.btnSetaDireita.Text = ">";
            this.btnSetaDireita.UseVisualStyleBackColor = true;
            this.btnSetaDireita.Click += new System.EventHandler(this.btnSetaDireita_Click);
            // 
            // listBoxEscolhido
            // 
            this.listBoxEscolhido.FormattingEnabled = true;
            this.listBoxEscolhido.Location = new System.Drawing.Point(256, 19);
            this.listBoxEscolhido.Name = "listBoxEscolhido";
            this.listBoxEscolhido.Size = new System.Drawing.Size(148, 134);
            this.listBoxEscolhido.TabIndex = 23;
            this.listBoxEscolhido.SelectedIndexChanged += new System.EventHandler(this.listBoxEscolhido_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Tp___Matrícula_na_Academia.Properties.Resources.steve_jobs__1_;
            this.pictureBox1.Location = new System.Drawing.Point(472, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 117);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = global::Tp___Matrícula_na_Academia.Properties.Resources.Captura_de_tela_2026_08_31_011741;
            this.btnSair.Location = new System.Drawing.Point(132, 400);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(45, 46);
            this.btnSair.TabIndex = 21;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpPeriodo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpModal);
            this.Controls.Add(this.gpCortesia);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia XPTO";
            this.gpPeriodo.ResumeLayout(false);
            this.gpPeriodo.PerformLayout();
            this.gpCortesia.ResumeLayout(false);
            this.gpCortesia.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpModal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbManha;
        private System.Windows.Forms.RadioButton rbTarde;
        private System.Windows.Forms.RadioButton rbNoite;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox ckYoga;
        private System.Windows.Forms.CheckBox ckMed;
        private System.Windows.Forms.CheckBox ckTai;
        private System.Windows.Forms.CheckBox ckFeng;
        private System.Windows.Forms.CheckBox ckCrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtVlPagar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ListBox listBoxModa;
        private System.Windows.Forms.GroupBox gpPeriodo;
        private System.Windows.Forms.GroupBox gpCortesia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpModal;
        private System.Windows.Forms.Button btnSetaEsquerdaDupla;
        private System.Windows.Forms.Button btnSetaDireitaDupla;
        private System.Windows.Forms.Button btnSetaEsquerda;
        private System.Windows.Forms.Button btnSetaDireita;
        private System.Windows.Forms.ListBox listBoxEscolhido;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

