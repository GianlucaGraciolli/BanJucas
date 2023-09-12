using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjtAula01
{
    public partial class TelaCriarConta : Form
    {
        public TelaCriarConta()
        {
            InitializeComponent();
        }

        private void TelaCriarConta_Load(object sender, EventArgs e)
        {

        }

        private void bttCriarConta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaConta.Text == txtConfSenhaConta.Text)
                {
                    Conta conta = new Conta();
                    conta.IdCliente = UsuarioLogado.IdCliente;
                    conta.AberturaConta = DateTime.Now;
                    conta.Saldo = Convert.ToDecimal(txtValDepCad.Text);
                    conta.StatusConta = "Ativa";
                    conta.TipoConta = "Corrente";
                    conta.Limite = UsuarioLogado.Renda * 0.3m;
                    conta.SenhaConta = txtSenhaConta.Text;

                    //Criando uma conexão
                    SqlConnection conexao =
                               new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_Conta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCorrentista", conta.IdCliente);
                    cmd.Parameters.AddWithValue("dataAbertura", conta.AberturaConta);
                    cmd.Parameters.AddWithValue("saldo", conta.Saldo);
                    cmd.Parameters.AddWithValue("statusConta", conta.StatusConta);
                    cmd.Parameters.AddWithValue("statusConta", conta.TipoConta);
                    cmd.Parameters.AddWithValue("statusConta", conta.Limite);
                    cmd.Parameters.AddWithValue("senhaconta", conta.SenhaConta);

                    //abrir a conexão
                    conexao.Open();

                    //executa o comando no BD e captura o retorno devolvido pelo procedimento
                    conta.IdCliente = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show(conta.IdCliente.ToString());

                    conexao.Close();
                    MessageBox.Show("Conta criada com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UsuarioLogado.Contas.Add(conta);

                    UIClear.CleanTxtBoxes(this);

                }
                else
                {
                    throw new Exception("Os campos de senha não coincidem!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
