using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using DTO;
using PrjtAula01.Classes;

namespace PrjtAula01
{
    public partial class TelaLoginPrincipal : Form
    {
        public TelaLoginPrincipal()
        {
            InitializeComponent();
        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Criando uma conexão
                SqlConnection conexao =
            new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());
            SqlDataReader leitor; //declarando uma variável do tipo leitor de dados

            //Criando um comando
            SqlCommand cmd = new SqlCommand();

            //criando texto do comando, tipo e conexão que será usada
            cmd.CommandText = "ps_ValidarLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            //passando os parâmetros necessários
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("cpf", caixaLogin.Text);
            cmd.Parameters.AddWithValue("senhaLogin", senhaLogin.Text);

            conexao.Open(); //abrindo a conexão

            //igualando o leitor ao resultado trazido do BD
            leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                leitor.Read();

                UsuarioLogado.IdCliente = leitor.GetInt32(0);
                UsuarioLogado.Nome = leitor.GetString(1);
                UsuarioLogado.Cpf = leitor.GetString(2);
                if (!leitor.IsDBNull(3))
                {
                    UsuarioLogado.Rg = leitor.GetString(3);
                }
                UsuarioLogado.Celular = leitor.GetString(4);
                UsuarioLogado.Email = leitor.GetString(5);
                UsuarioLogado.Logradouro = leitor.GetString(6);
                UsuarioLogado.NumeroLogradouro = leitor.GetString(7);
                UsuarioLogado.Cep = leitor.GetString(8);
                UsuarioLogado.Cidade = leitor.GetString(9);
                UsuarioLogado.Estado = leitor.GetString(10);
                UsuarioLogado.Genero = leitor.GetString(11);
                UsuarioLogado.DataNasc = leitor.GetDateTime(12);
                UsuarioLogado.Renda = leitor.GetDecimal(13);
                UsuarioLogado.SenhaLogin = leitor.GetString(14);
                //fechando leitor
                leitor.Close();

                //criando texto do comando, tipo e conexão que será usada
                cmd.CommandText = "ps_buscaContasPorIdCliente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //passando os parâmetros necessários
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idcliente", UsuarioLogado.IdCliente);

                //ler novamente o leitor
                leitor = cmd.ExecuteReader();

                //verificar se há linhas retornadas do leitor
                if (leitor.HasRows)
                {
                    //repete a leitura e enquanto há linhas segue na estrutura
                    //de repetição
                    while (leitor.Read())
                    {
                        //cria uma conta na memória
                        Conta conta = new Conta();
                        //passa os dados do leitor para a conta na memória - objeto conta
                        conta.IdConta = leitor.GetInt32(0);
                        conta.IdCliente = leitor.GetInt32(1);
                        conta.Saldo = leitor.GetDecimal(2);
                        conta.Limite = leitor.GetDecimal(3);
                        conta.TipoConta = leitor.GetString(4);
                        conta.StatusConta = leitor.GetString(5);
                        conta.AberturaConta = leitor.GetDateTime(6);
                            if (!leitor.IsDBNull(7))
                            {
                                conta.EncerramentoConta = leitor.GetDateTime(7);
                            }                                
                        conta.SenhaConta = leitor.GetString(8);

                        //adiciona a conta recém criada na memória para a colection de contas
                        UsuarioLogado.Contas.Add(conta);
                    }
                }
                leitor.Close(); //fecha leitor
                conexao.Close(); //fecha conexao com BD

                Form telaLogin = Application.OpenForms["TelaLogin"];
                //acessando o formulário aberto através da variável janelaPrincipal
                MenuStrip menuPrincipal = (MenuStrip)telaLogin.Controls[0];
                menuPrincipal.Items[0].Text = "Logout";
                menuPrincipal.Items[1].Visible = false;
                menuPrincipal.Items[2].Visible = true;
                menuPrincipal.Items[3].Visible = true;
                menuPrincipal.Items[4].Visible = true;
                menuPrincipal.Items[5].Visible = true;
                menuPrincipal.Items[6].Visible = true;
                menuPrincipal.Items[7].Visible = true;
                menuPrincipal.Items[8].Visible = true;
                menuPrincipal.Items[8].Text = UsuarioLogado.Nome;
                menuPrincipal.Items[9].Visible = true;
                if (UsuarioLogado.Contas.Count == 0)
                {
                    menuPrincipal.Items[9].Text = "não há contas";
                    MessageBox.Show($"Olá,{UsuarioLogado.Nome}");
                }
                else
                {
                    menuPrincipal.Items[9].Text = $"Conta: {UsuarioLogado.Contas[0].IdCliente.ToString()}";

                    MessageBox.Show($"Olá,{UsuarioLogado.Nome}!\n" +
                        $"Você foi logado na conta {UsuarioLogado.Contas[0].IdCliente.ToString()}\n" +
                        $"Para trocar de conta, utilize o menu Conta\\Alternar Conta");
                }


                //MessageBox.Show($"{CorrentistaLogado.Id.ToString()},{CorrentistaLogado.NomeCorrentista},{CorrentistaLogado.DataNascimento.ToString()},{CorrentistaLogado.Logradouro}," +
                //    $"{CorrentistaLogado.Numero},{CorrentistaLogado.Complemento},{CorrentistaLogado.Cidade}," +
                //    $"{CorrentistaLogado.Estado},{CorrentistaLogado.Cpf},{CorrentistaLogado.Senha},{CorrentistaLogado.Celular}");
                this.Close();


















                //MessageBox.Show("Seja Bem Vindo!");
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
















            //código quando o botão ENTRAR for clicado

            /*if (caixaLogin.Text == String.Empty || senhaLogin.Text == String.Empty)
            {
                lblMsgLogin.Text = "Dados não informados!";
                caixaLogin.Focus();

            }

            else if (caixaLogin.Text == "12345678900" && senhaLogin.Text == "123456")
            {
                TelaLoginPrincipal telaLogin = new TelaLoginPrincipal();

                // instanciei a classe / criei o objeto
                MenuPrincipal TelaMenu = new MenuPrincipal();

                //usando metodo show
                TelaMenu.Show();
            }

            else if (caixaLogin.TextLength < 11 || senhaLogin.TextLength < 6)
            {
                lblMsgLogin.Text = "Preencha os dados corretamente";

            }

            Conta MinhaConta = new Conta();

            MinhaConta.Status = "ATIVA";

            MessageBox.Show(MinhaConta.Status);*/

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void criarCadastro_Click(object sender, EventArgs e)
        {
            // instanciei a classe / criei o objeto
            TelaCadastro TelaLogin = new TelaCadastro();

            //usando metodo show
            TelaLogin.Show();

        }

        private void caixaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaLoginPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}