namespace WinFormsApp1
{
    partial class EditarParticipantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cnpj = new System.Windows.Forms.TextBox();
            this.containterna = new System.Windows.Forms.TextBox();
            this.contacetip = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.Cadastro = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.select = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Conta Interna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // cnpj
            // 
            this.cnpj.Location = new System.Drawing.Point(468, 221);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(226, 31);
            this.cnpj.TabIndex = 13;
            // 
            // containterna
            // 
            this.containterna.Location = new System.Drawing.Point(468, 168);
            this.containterna.Name = "containterna";
            this.containterna.Size = new System.Drawing.Size(226, 31);
            this.containterna.TabIndex = 12;
            // 
            // contacetip
            // 
            this.contacetip.Location = new System.Drawing.Point(468, 107);
            this.contacetip.Name = "contacetip";
            this.contacetip.Size = new System.Drawing.Size(226, 31);
            this.contacetip.TabIndex = 11;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(468, 47);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(226, 31);
            this.nome.TabIndex = 10;
            // 
            // Cadastro
            // 
            this.Cadastro.Location = new System.Drawing.Point(333, 273);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(361, 55);
            this.Cadastro.TabIndex = 9;
            this.Cadastro.Text = "Editar";
            this.Cadastro.UseVisualStyleBackColor = true;
            this.Cadastro.Click += new System.EventHandler(this.Cadastro_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 33);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // select
            // 
            this.select.AutoSize = true;
            this.select.Location = new System.Drawing.Point(50, 89);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(198, 25);
            this.select.TabIndex = 19;
            this.select.Text = "Selecione o Participante";
            this.select.Click += new System.EventHandler(this.label5_Click);
            // 
            // EditarParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 368);
            this.Controls.Add(this.select);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.containterna);
            this.Controls.Add(this.contacetip);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.Cadastro);
            this.Name = "EditarParticipantes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditarParticipantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox cnpj;
        private TextBox containterna;
        private TextBox contacetip;
        private TextBox nome;
        private Button Cadastro;
        private ComboBox comboBox1;
        private Label select;
    }
}