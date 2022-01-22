namespace WinFormsApp1
{
    partial class Menu
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
            this.Cadastrar_participantes = new System.Windows.Forms.Button();
            this.Cadastrar_emails = new System.Windows.Forms.Button();
            this.importar_custos_cetip = new System.Windows.Forms.Button();
            this.editar_participantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cadastrar_participantes
            // 
            this.Cadastrar_participantes.Location = new System.Drawing.Point(49, 63);
            this.Cadastrar_participantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cadastrar_participantes.Name = "Cadastrar_participantes";
            this.Cadastrar_participantes.Size = new System.Drawing.Size(214, 66);
            this.Cadastrar_participantes.TabIndex = 0;
            this.Cadastrar_participantes.Text = "Cadastrar_participantes";
            this.Cadastrar_participantes.UseVisualStyleBackColor = true;
            this.Cadastrar_participantes.Click += new System.EventHandler(this.Cadastrar_participantes_Click);
            // 
            // Cadastrar_emails
            // 
            this.Cadastrar_emails.Location = new System.Drawing.Point(304, 63);
            this.Cadastrar_emails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cadastrar_emails.Name = "Cadastrar_emails";
            this.Cadastrar_emails.Size = new System.Drawing.Size(214, 66);
            this.Cadastrar_emails.TabIndex = 1;
            this.Cadastrar_emails.Text = "Cadastrar_emails";
            this.Cadastrar_emails.UseVisualStyleBackColor = true;
            this.Cadastrar_emails.Click += new System.EventHandler(this.Cadastrar_emails_Click);
            // 
            // importar_custos_cetip
            // 
            this.importar_custos_cetip.Location = new System.Drawing.Point(49, 157);
            this.importar_custos_cetip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.importar_custos_cetip.Name = "importar_custos_cetip";
            this.importar_custos_cetip.Size = new System.Drawing.Size(214, 66);
            this.importar_custos_cetip.TabIndex = 2;
            this.importar_custos_cetip.Text = "Importar_custos_Cetip";
            this.importar_custos_cetip.UseVisualStyleBackColor = true;
            this.importar_custos_cetip.Click += new System.EventHandler(this.importar_custos_cetip_Click);
            // 
            // editar_participantes
            // 
            this.editar_participantes.Location = new System.Drawing.Point(304, 157);
            this.editar_participantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editar_participantes.Name = "editar_participantes";
            this.editar_participantes.Size = new System.Drawing.Size(214, 66);
            this.editar_participantes.TabIndex = 3;
            this.editar_participantes.Text = "Editar Participantes";
            this.editar_participantes.UseVisualStyleBackColor = true;
            this.editar_participantes.Click += new System.EventHandler(this.editar_participantes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.editar_participantes);
            this.Controls.Add(this.importar_custos_cetip);
            this.Controls.Add(this.Cadastrar_emails);
            this.Controls.Add(this.Cadastrar_participantes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Cadastrar_participantes;
        private Button Cadastrar_emails;
        private Button importar_custos_cetip;
        private Button editar_participantes;
    }
}