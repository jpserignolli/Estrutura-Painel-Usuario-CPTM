namespace Estrutura_Painel_Usuário_CPTM
{
    partial class FmlSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmlSenha));
            this.lblInformacaoSenha = new System.Windows.Forms.Label();
            this.lblCPF2 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.boxSenha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.linkEsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.lblInfCPF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInformacaoSenha
            // 
            this.lblInformacaoSenha.AutoSize = true;
            this.lblInformacaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacaoSenha.Location = new System.Drawing.Point(12, 20);
            this.lblInformacaoSenha.Name = "lblInformacaoSenha";
            this.lblInformacaoSenha.Size = new System.Drawing.Size(123, 16);
            this.lblInformacaoSenha.TabIndex = 3;
            this.lblInformacaoSenha.Text = "Digite sua senha";
            // 
            // lblCPF2
            // 
            this.lblCPF2.AutoSize = true;
            this.lblCPF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF2.Location = new System.Drawing.Point(12, 60);
            this.lblCPF2.Name = "lblCPF2";
            this.lblCPF2.Size = new System.Drawing.Size(33, 16);
            this.lblCPF2.TabIndex = 4;
            this.lblCPF2.Text = "CPF";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(12, 117);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 16);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha";
            // 
            // boxSenha
            // 
            this.boxSenha.Location = new System.Drawing.Point(15, 136);
            this.boxSenha.Name = "boxSenha";
            this.boxSenha.Size = new System.Drawing.Size(215, 20);
            this.boxSenha.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(36, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Location = new System.Drawing.Point(178, 202);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(136, 32);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // linkEsqueciSenha
            // 
            this.linkEsqueciSenha.AutoSize = true;
            this.linkEsqueciSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEsqueciSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkEsqueciSenha.Location = new System.Drawing.Point(12, 159);
            this.linkEsqueciSenha.Name = "linkEsqueciSenha";
            this.linkEsqueciSenha.Size = new System.Drawing.Size(108, 13);
            this.linkEsqueciSenha.TabIndex = 10;
            this.linkEsqueciSenha.TabStop = true;
            this.linkEsqueciSenha.Text = "Esqueci minha senha";
            // 
            // lblInfCPF
            // 
            this.lblInfCPF.AutoSize = true;
            this.lblInfCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfCPF.Location = new System.Drawing.Point(12, 80);
            this.lblInfCPF.Name = "lblInfCPF";
            this.lblInfCPF.Size = new System.Drawing.Size(84, 15);
            this.lblInfCPF.TabIndex = 11;
            this.lblInfCPF.Text = "41251734863";
            // 
            // FmlSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 368);
            this.Controls.Add(this.lblInfCPF);
            this.Controls.Add(this.linkEsqueciSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.boxSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblCPF2);
            this.Controls.Add(this.lblInformacaoSenha);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmlSenha";
            this.Text = "Companhia Paulista de Trens Metropolitanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacaoSenha;
        private System.Windows.Forms.Label lblCPF2;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox boxSenha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel linkEsqueciSenha;
        private System.Windows.Forms.Label lblInfCPF;
    }
}