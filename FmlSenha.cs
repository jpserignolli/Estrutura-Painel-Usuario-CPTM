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
    public partial class FmlSenha : Form
    {
        public FmlSenha()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha = boxSenha.Text;

            if (string.IsNullOrWhiteSpace(boxSenha.Text)){
                MessageBox.Show("Por favor, preencha a Senha.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FmlPainelUsuario fmlusuario = new FmlPainelUsuario();
            fmlusuario.Show();

            this.Hide();
        }
    }
}
