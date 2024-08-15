namespace Estrutura_Painel_Usuário_CPTM
{
    partial class FmlCriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmlCriarConta));
            this.lblInformacaoSenha = new System.Windows.Forms.Label();
            this.lblCPFRegistro = new System.Windows.Forms.Label();
            this.boxCPFRegistro = new System.Windows.Forms.TextBox();
            this.lblSenhaRegistro = new System.Windows.Forms.Label();
            this.boxSenhaRegistro = new System.Windows.Forms.TextBox();
            this.btnCancelarRegistro = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInformacaoSenha
            // 
            this.lblInformacaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacaoSenha.Location = new System.Drawing.Point(12, 33);
            this.lblInformacaoSenha.Name = "lblInformacaoSenha";
            this.lblInformacaoSenha.Size = new System.Drawing.Size(139, 16);
            this.lblInformacaoSenha.TabIndex = 4;
            this.lblInformacaoSenha.Text = "Registre sua Conta";
            this.lblInformacaoSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInformacaoSenha.UseCompatibleTextRendering = true;
            // 
            // lblCPFRegistro
            // 
            this.lblCPFRegistro.AutoSize = true;
            this.lblCPFRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFRegistro.ForeColor = System.Drawing.Color.Black;
            this.lblCPFRegistro.Location = new System.Drawing.Point(54, 79);
            this.lblCPFRegistro.Name = "lblCPFRegistro";
            this.lblCPFRegistro.Size = new System.Drawing.Size(36, 16);
            this.lblCPFRegistro.TabIndex = 7;
            this.lblCPFRegistro.Text = "CPF";
            // 
            // boxCPFRegistro
            // 
            this.boxCPFRegistro.Location = new System.Drawing.Point(57, 98);
            this.boxCPFRegistro.Name = "boxCPFRegistro";
            this.boxCPFRegistro.Size = new System.Drawing.Size(215, 20);
            this.boxCPFRegistro.TabIndex = 8;
            this.boxCPFRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxCPFRegistro.TextChanged += new System.EventHandler(this.boxCPFRegistro_TextChanged);
            // 
            // lblSenhaRegistro
            // 
            this.lblSenhaRegistro.AutoSize = true;
            this.lblSenhaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaRegistro.ForeColor = System.Drawing.Color.Black;
            this.lblSenhaRegistro.Location = new System.Drawing.Point(54, 133);
            this.lblSenhaRegistro.Name = "lblSenhaRegistro";
            this.lblSenhaRegistro.Size = new System.Drawing.Size(51, 16);
            this.lblSenhaRegistro.TabIndex = 9;
            this.lblSenhaRegistro.Text = "Senha";
            // 
            // boxSenhaRegistro
            // 
            this.boxSenhaRegistro.Location = new System.Drawing.Point(57, 152);
            this.boxSenhaRegistro.Name = "boxSenhaRegistro";
            this.boxSenhaRegistro.Size = new System.Drawing.Size(215, 20);
            this.boxSenhaRegistro.TabIndex = 10;
            this.boxSenhaRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRegistro.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarRegistro.Location = new System.Drawing.Point(57, 232);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(136, 32);
            this.btnCancelarRegistro.TabIndex = 13;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = true;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(212, 232);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(136, 32);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FmlCriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelarRegistro);
            this.Controls.Add(this.boxSenhaRegistro);
            this.Controls.Add(this.lblSenhaRegistro);
            this.Controls.Add(this.boxCPFRegistro);
            this.Controls.Add(this.lblCPFRegistro);
            this.Controls.Add(this.lblInformacaoSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmlCriarConta";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmlCriarConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacaoSenha;
        private System.Windows.Forms.Label lblCPFRegistro;
        private System.Windows.Forms.TextBox boxCPFRegistro;
        private System.Windows.Forms.Label lblSenhaRegistro;
        private System.Windows.Forms.TextBox boxSenhaRegistro;
        private System.Windows.Forms.Button btnCancelarRegistro;
        private System.Windows.Forms.Button btnRegistrar;
    }
}