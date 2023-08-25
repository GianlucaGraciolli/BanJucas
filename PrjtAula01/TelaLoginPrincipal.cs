using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
                    UsuarioLogado.Renda = leitor.GetDouble(13);
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

                    MessageBox.Show("Seja Bem Vindo!");
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