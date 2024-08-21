namespace Estrutura_Painel_Usuário_CPTM
{
    partial class CPTM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPTM));
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoMenu = new System.Windows.Forms.Label();
            this.lblInformacaoPainel = new System.Windows.Forms.Label();
            this.boxCPF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkDuvidas = new System.Windows.Forms.LinkLabel();
            this.linkPrimeiroAcesso = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // lblInfoMenu
            // 
            this.lblInfoMenu.AutoSize = true;
            this.lblInfoMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMenu.Location = new System.Drawing.Point(62, 50);
            this.lblInfoMenu.Name = "lblInfoMenu";
            this.lblInfoMenu.Size = new System.Drawing.Size(218, 15);
            this.lblInfoMenu.TabIndex = 1;
            this.lblInfoMenu.Text = "Digite seu CPF para acessar sua conta";
            // 
            // lblInformacaoPainel
            // 
            this.lblInformacaoPainel.AutoSize = true;
            this.lblInformacaoPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacaoPainel.Location = new System.Drawing.Point(12, 9);
            this.lblInformacaoPainel.Name = "lblInformacaoPainel";
            this.lblInformacaoPainel.Size = new System.Drawing.Size(268, 16);
            this.lblInformacaoPainel.TabIndex = 2;
            this.lblInformacaoPainel.Text = "Identifique-se no Painel Pessoal com:";
            // 
            // boxCPF
            // 
            this.boxCPF.Location = new System.Drawing.Point(65, 97);
            this.boxCPF.Name = "boxCPF";
            this.boxCPF.Size = new System.Drawing.Size(215, 20);
            this.boxCPF.TabIndex = 3;
            
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // linkDuvidas
            // 
            this.linkDuvidas.AutoSize = true;
            this.linkDuvidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDuvidas.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkDuvidas.Location = new System.Drawing.Point(62, 189);
            this.linkDuvidas.Name = "linkDuvidas";
            this.linkDuvidas.Size = new System.Drawing.Size(236, 16);
            this.linkDuvidas.TabIndex = 6;
            this.linkDuvidas.TabStop = true;
            this.linkDuvidas.Text = "Está com dúvidas e precisa de ajuda?";
            this.linkDuvidas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDuvidas_LinkClicked);
            // 
            // linkPrimeiroAcesso
            // 
            this.linkPrimeiroAcesso.AutoSize = true;
            this.linkPrimeiroAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPrimeiroAcesso.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkPrimeiroAcesso.Location = new System.Drawing.Point(125, 218);
            this.linkPrimeiroAcesso.Name = "linkPrimeiroAcesso";
            this.linkPrimeiroAcesso.Size = new System.Drawing.Size(98, 16);
            this.linkPrimeiroAcesso.TabIndex = 7;
            this.linkPrimeiroAcesso.TabStop = true;
            this.linkPrimeiroAcesso.Text = "Registrar conta";
            this.linkPrimeiroAcesso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrimeiroAcesso_LinkClicked);
            // 
            // CPTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.linkPrimeiroAcesso);
            this.Controls.Add(this.linkDuvidas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxCPF);
            this.Controls.Add(this.lblInformacaoPainel);
            this.Controls.Add(this.lblInfoMenu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CPTM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Companhia Paulista de Trens Metropolitanos";
            this.Load += new System.EventHandler(this.CPTM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfoMenu;
        private System.Windows.Forms.Label lblInformacaoPainel;
        private System.Windows.Forms.TextBox boxCPF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkDuvidas;
        private System.Windows.Forms.LinkLabel linkPrimeiroAcesso;
    }
}

