using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrutura_Painel_Usuário_CPTM
{
    public partial class CPTM : Form
    {
        public CPTM()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string cpf = boxCPF.Text;

            // Remove todos os caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Validação se o CPF tem exatamente 11 dígitos
            if (cpf.Length != 11)
            {
                MessageBox.Show("Por favor, preencha o CPF com 11 números.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validação se o usuário digitou o campo CPF
            if (string.IsNullOrWhiteSpace(boxCPF.Text)){
                MessageBox.Show("Por favor, preencha o CPF.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FmlSenha fmlsenha = new FmlSenha();
            fmlsenha.CPF = cpf;
            fmlsenha.Show();

            this.Hide();

        }
        private void linkDuvidas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.cptm.sp.gov.br/Pages/atendimento.aspx";

            try{
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex){

            }
        }

        private void linkPrimeiroAcesso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FmlCriarConta fmlCriarConta = new FmlCriarConta();
            fmlCriarConta.Show();
            this.Hide();
        }

        private void CPTM_Load(object sender, EventArgs e)
        {

        }

        private void boxCPF_TextChanged_1(object sender, EventArgs e)
        {
            TextBox tbCPF = sender as TextBox;
            if (tbCPF != null)
            {
                // Remove todos os caracteres não numéricos
                string filteredText = new string(tbCPF.Text.Where(char.IsDigit).ToArray());

                // Limita o texto a 11 caracteres
                if (filteredText.Length > 11)
                {
                    filteredText = filteredText.Substring(0, 11);
                }

                // Atualiza o texto do TextBox e move o cursor para o final
                tbCPF.Text = filteredText;
                tbCPF.SelectionStart = tbCPF.Text.Length;
            }
        }
    }
}
