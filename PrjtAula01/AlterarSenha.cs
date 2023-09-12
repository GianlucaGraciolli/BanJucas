using PrjtAula01.Classes;
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
    public partial class AlterarSenha : Form
    {
        public AlterarSenha()
        {
            InitializeComponent();
        }

        private void salvarBotaoAltSenha_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSenhaAlterar.Text == txtConfSenhaAlt.Text)
                {
                    SqlConnection conexao =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());


                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "pu_AlterarSenha";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("senhaLogin", txtSenhaAlterar.Text);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Senha alterada com sucesso!", "Info!");
                    UIClear.CleanTxtBoxes(this);
                }

                else
                {
                    throw new Exception("ERRO DOIDÃO, ACERTA ISSO");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AlterarSenha_Load(object sender, EventArgs e)
        {

        }
    }
}
