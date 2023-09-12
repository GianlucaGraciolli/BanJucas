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
using DTO;

namespace PrjtAula01
{
    public partial class AlterarConta : Form
    {
        public AlterarConta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AlterarConta_Load(object sender, EventArgs e)
        {
            foreach (var item in UsuarioLogado.Contas)
            {
                cbContas.Items.Add(item.IdConta);
            }
            cbContas.Text = cbContas.Items[0].ToString();
        }

        private void btAlterarConta_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao =
                new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());
                SqlDataReader leitor;

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "pu_ValidarSenhaConta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idconta", cbContas.Text);
                cmd.Parameters.AddWithValue("senhaConta", txtSenhaContaAlt.Text);

                conexao.Open();

                leitor = cmd.ExecuteReader();

                if (leitor.HasRows)
                {
                    UsuarioLogado.ContaLogada = Convert.ToInt32(cbContas.Text);
                    MessageBox.Show($"Você está agora na conta {UsuarioLogado.ContaLogada}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    throw new Exception("Senha Incorreta.");
                }

                conexao.Close();
                UIClear.CleanTxtBoxes(this);               

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
