using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjtAula01.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrjtAula01
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.menu.Items[0].Text == "Login")
            {
                TelaLoginPrincipal telaLoginPrin = new TelaLoginPrincipal();
                telaLoginPrin.MdiParent = this;
                telaLoginPrin.Show();
            }
            else
            {
                menu.Items[0].Text = "Login";
                menu.Items[1].Visible = true;
                menu.Items[2].Visible = false;
                menu.Items[3].Visible = false;
                menu.Items[4].Visible = false;
                menu.Items[5].Visible = false;
                menu.Items[6].Visible = false;
                menu.Items[7].Visible = false;
                menu.Items[7].Text = String.Empty;
                menu.Items[8].Visible = false;
                menu.Items[8].Text = String.Empty;
                menu.Items[9].Visible = false;
                menu.Items[9].Text = String.Empty;

                UsuarioLogado.Deslogar();
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaLogin = new TelaLoginPrincipal();

            // instanciei a classe / criei o objeto
            TelaCadastro TelaCad = new TelaCadastro();


            //definindo a janela "pai" para o form TelaLogin, ou seja, obrigando a tela criada a ser aberta dentro do Form principal
            TelaCad.MdiParent = this;

            //usando metodo show
            TelaCad.Show();



        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeposito janelaDeposito = new TelaDeposito();
            janelaDeposito.MdiParent = this;
            janelaDeposito.Show();
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaSaque janelaSaque = new TelaSaque();
            janelaSaque.MdiParent = this;
            janelaSaque.Show();
        }

        private void transferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaTransferencia janelaTransferencia = new TelaTransferencia();
            janelaTransferencia.MdiParent = this;
            janelaTransferencia.Show();
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {



            // instanciei a classe / criei o objeto
            //TelaLoginPrincipal TelaLoginPrin = new TelaLoginPrincipal();
            //definindo a janela "pai" para o form TelaLogin, ou seja, obrigando a tela criada a ser aberta dentro do Form principal
            //TelaLoginPrin.MdiParent = this;
            //usando metodo show
            //TelaLoginPrin.Show();


        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.MdiParent = this;
            telaCadastro.Show();
        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCriarConta telaCriarConta = new TelaCriarConta();
            telaCriarConta.MdiParent = this;
            telaCriarConta.Show();
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarDados alterarDados = new AlterarDados();
            alterarDados.MdiParent = this;
            alterarDados.Show();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarSenha alterarSenha = new AlterarSenha();

            alterarSenha.MdiParent = this;
            alterarSenha.Show();
        }

        private void alterarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlterarConta alterarConta = new AlterarConta();

            alterarConta.MdiParent = this;
            alterarConta.Show();
        }
    }
}
