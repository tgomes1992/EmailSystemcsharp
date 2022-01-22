namespace WinFormsApp1
{
    partial class CadastroParticipantes
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
            this.Cadastro = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.contacetip = new System.Windows.Forms.TextBox();
            this.containterna = new System.Windows.Forms.TextBox();
            this.cnpj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cadastro
            // 
            this.Cadastro.Location = new System.Drawing.Point(132, 268);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(361, 55);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastrar";
            this.Cadastro.UseVisualStyleBackColor = true;
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(267, 42);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(226, 31);
            this.nome.TabIndex = 1;
            // 
            // contacetip
            // 
            this.contacetip.Location = new System.Drawing.Point(267, 102);
            this.contacetip.Name = "contacetip";
            this.contacetip.Size = new System.Drawing.Size(226, 31);
            this.contacetip.TabIndex = 2;
            // 
            // containterna
            // 
            this.containterna.Location = new System.Drawing.Point(267, 163);
            this.containterna.Name = "containterna";
            this.containterna.Size = new System.Drawing.Size(226, 31);
            this.containterna.TabIndex = 3;
            // 
            // cnpj
            // 
            this.cnpj.Location = new System.Drawing.Point(267, 216);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(226, 31);
            this.cnpj.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Conta Interna";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "CNPJ";
            // 
            // CadastroParticipantes
            // 
            this.ClientSize = new System.Drawing.Size(651, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.containterna);
            this.Controls.Add(this.contacetip);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.Cadastro);
            this.Name = "CadastroParticipantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private TextBox contacetip;
        private TextBox nomeparticipante;
        private TextBox ContaInterna;
        private TextBox cnpj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Cadastro;
        private TextBox nome;
        private TextBox containterna;
       
    }
}