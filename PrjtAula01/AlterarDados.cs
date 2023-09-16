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
    public partial class AlterarDados : Form
    {
        public AlterarDados()
        {
            InitializeComponent();
        }

        private void AlterarDados_Load(object sender, EventArgs e)
        {
            txtNomeAlt.Text = UsuarioLogado.Nome;
            txtCpfAlt.Text = UsuarioLogado.Cpf;
            txtRgAlt.Text = UsuarioLogado.Rg;
            txtCelAlt.Text = UsuarioLogado.Celular;
            txtEmailAlt.Text = UsuarioLogado.Email;
            dtpNascAlt.Text = Convert.ToString(UsuarioLogado.DataNasc);
            txtGeneroAlt.Text = UsuarioLogado.Genero;
            txtCEPAlt.Text = UsuarioLogado.Cep;
            txtLogradAlt.Text = UsuarioLogado.Logradouro;
            txtNumLogAlt.Text = UsuarioLogado.NumeroLogradouro;
            txtCidadeAlt.Text = UsuarioLogado.Cidade;
            cbEstadoAlt.Text = UsuarioLogado.Estado;
            txtRendaAlt.Text = Convert.ToString(UsuarioLogado.Renda);
        }

        private void salvarBotaoAlt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfSenhaLoginAlt.Text == String.Empty || txtSenhaLoginAlt.Text == String.Empty)
                {
                    throw new Exception("Digite algo nos campos de senha!");
                }
                else if (txtSenhaLoginAlt.Text != txtConfSenhaLoginAlt.Text)
                {
                    throw new Exception("As senhas não coincidem.");
                }
                else if (txtConfSenhaLoginAlt.Text != UsuarioLogado.SenhaLogin)
                {
                    throw new Exception("Senha incorreta.");
                }
                else
                {
                    SqlConnection conexao =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());


                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "pu_alterarDados";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("nome", txtNomeAlt.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCpfAlt.Text);
                    cmd.Parameters.AddWithValue("rg", txtRgAlt.Text);
                    cmd.Parameters.AddWithValue("celular", txtCelAlt.Text);
                    cmd.Parameters.AddWithValue("email", txtEmailAlt.Text);
                    cmd.Parameters.AddWithValue("logradouro", txtLogradAlt.Text);
                    cmd.Parameters.AddWithValue("numerologradouro", txtNumLogAlt.Text);
                    cmd.Parameters.AddWithValue("cep", txtCEPAlt.Text);
                    cmd.Parameters.AddWithValue("cidade", txtCidadeAlt.Text);
                    cmd.Parameters.AddWithValue("estado", cbEstadoAlt.Text);
                    cmd.Parameters.AddWithValue("genero", txtGeneroAlt.Text);
                    cmd.Parameters.AddWithValue("datanasc", Convert.ToDateTime(dtpNascAlt.Text));
                    cmd.Parameters.AddWithValue("renda", Convert.ToDecimal(txtRendaAlt.Text));
                    cmd.Parameters.AddWithValue("senhalogin", UsuarioLogado.SenhaLogin);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                    MessageBox.Show("Alteração feita com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
