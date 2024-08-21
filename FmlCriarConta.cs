using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViaCep;

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

            string arquivo = @"C:\Users\Aluno\Documents\Dados.txt";

            string nome, email, senha, rg, cpf, telefone, celular;
            string cep, rua, bairro, complemento, numero, cidade, uf;

            nome = boxNome.Text;
            email = boxEmail.Text;
            senha = boxSenhaRegistro.Text;
            rg = boxRG.Text;
            cpf = boxCPF.Text;
            telefone = boxTelefone.Text;
            celular = boxCelular.Text;

            rua = boxRua.Text;
            cep = boxCEP.Text;
            bairro = boxBairro.Text;
            complemento = boxComplemento.Text;
            numero = boxNumero.Text;
            cidade = boxCidade.Text;
            uf = boxUF.Text;

            string dados = "===========================\n" +
               $"Nome: {nome}\n" +
               $"Email: {email}\n" +
               $"Senha: {senha}\n" +
               $"RG: {rg}\n" +
               $"CPF: {cpf}\n" +
               $"Telefone: {telefone}\n" +
               $"Celular: {celular}\n" +
               $"CEP: {cep}\n" +
               $"Rua: {rua}\n" +
               $"Bairro: {bairro}\n" +
               $"Complemento: {complemento}\n" +
               $"Número: {numero}\n" +
               $"Cidade: {cidade}\n" +
               $"UF: {uf}\n" +
               "===========================";

            if (cpf.Length != 11)
            {
                MessageBox.Show("Por favor, preencha o CPF com 11 números.", "Campo Obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validação se o usuário digitou o campo CPF.
            if (string.IsNullOrWhiteSpace(boxNome.Text))
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

            try
            {
                File.AppendAllText(arquivo, dados + Environment.NewLine);

                MessageBox.Show("Dados salvos com sucesso no arquivo.");

                boxNome.Clear();
                boxEmail.Clear();
                boxRG.Clear();
                boxCPF.Clear();
                boxTelefone.Clear();
                boxCelular.Clear();

                boxRua.Clear();
                boxCEP.Clear();
                boxBairro.Clear();
                boxComplemento.Clear();
                boxNumero.Clear();
                boxCidade.Clear();
                boxUF.Clear();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Salvar os dados. " + erro);

            }

            CPTM cptm = new CPTM();
            cptm.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCPFRegistro_Click(object sender, EventArgs e)
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var result = new ViaCepClient().Search(boxCEP.Text);
            boxRua.Text = result.Street;
            boxBairro.Text = result.Neighborhood;
            boxCidade.Text = result.City;
            boxUF.Text = result.StateInitials;
        }

        private void boxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxCPF_TextChanged(object sender, EventArgs e)
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
