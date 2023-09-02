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
using static System.Net.Mime.MediaTypeNames;

namespace PrjtAula01
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void lblCriarCadastro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCad_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtNomeCad.Text, out var valorDigitado))
            {
                txtNomeCad.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRendaCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btAcessoCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaCad.Text == txtConfSenhaCad.Text)
                {
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_Cliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    //inserindo parâmetros na procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("nome", txtNomeCad.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCpfCad.Text);
                    cmd.Parameters.AddWithValue("rg", txtRgCad.Text);
                    cmd.Parameters.AddWithValue("celular", txtCelCad.Text);
                    cmd.Parameters.AddWithValue("email", txtEmailCad.Text);
                    cmd.Parameters.AddWithValue("logradouro", txtLogradCad.Text);
                    cmd.Parameters.AddWithValue("numerologradouro", txtNumLogCad.Text);
                    cmd.Parameters.AddWithValue("cep", txtCEPCad.Text);
                    cmd.Parameters.AddWithValue("cidade", txtCidadeCad.Text);
                    cmd.Parameters.AddWithValue("estado", cbEstado.Text);
                    cmd.Parameters.AddWithValue("genero", txtGeneroCad.Text);
                    cmd.Parameters.AddWithValue("datanasc", Convert.ToDateTime(dtpNasc.Text));
                    cmd.Parameters.AddWithValue("renda", txtRendaCad.Text);
                    cmd.Parameters.AddWithValue("senhalogin", txtSenhaCad.Text);

                    //abrir conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery();//Executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UIClear.CleanTxtBoxes(this);
                }
                else
                {
                    throw new Exception("Os campos de senhas não coincidem");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumLogCad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
