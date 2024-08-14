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
            //Validação se o usuário digitou o campo CPF
            if(string.IsNullOrWhiteSpace(boxCPF.Text)){
                MessageBox.Show("Por favor, preencha o CPF.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FmlSenha fmlsenha = new FmlSenha();
            fmlsenha.Show();

            this.Hide();

        }

        private void boxCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = boxCPF.Text;
        }
    }
}
