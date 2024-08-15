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
    public partial class FmlCriarConta : Form
    {
        public FmlCriarConta()
        {
            InitializeComponent();
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            CPTM cptm = new CPTM();
            cptm.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string cpf = boxCPFRegistro.Text;
            string senha = boxSenhaRegistro.Text;

            //Validação do máximo de números
            if (cpf.Length != 11)
            {
                MessageBox.Show("Por favor, preencha o CPF com 11 números.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validação se o usuário digitou o campo CPF.
            if (string.IsNullOrWhiteSpace(boxCPFRegistro.Text))
            {
                MessageBox.Show("Por favor, preencha o CPF.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validação se o usuário digitou o campo senha.
            if (string.IsNullOrWhiteSpace(boxSenhaRegistro.Text))
            {
                MessageBox.Show("Por favor, preencha a Senha.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CPTM cptm = new CPTM();
            cptm.Show();
            this.Hide();
        }

        private void boxCPFRegistro_TextChanged(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
