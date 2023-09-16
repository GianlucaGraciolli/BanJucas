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
    public partial class TelaDeposito : Form
    {
        public TelaDeposito()
        {
            InitializeComponent();
        }

        private void lblVoltarDeposito_Click(object sender, EventArgs e)
        {


        }

        private void Extra_Load(object sender, EventArgs e)
        {

        }

        private void btConfirmarDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = new Conta();

                if (Convert.ToInt32(txtValorDeposito.Text) <= 0 || decimal.TryParse(txtValorDeposito.Text,out decimal result) == false)
                {
                    throw new Exception("Insira um caracter válido. \n *NÚMERO E/OU ACIMA DE ZERO"); 
                }
                else if (txtValorDeposito.Text == string.Empty)
                {
                    throw new Exception("Insira algum dado.");
                }
                else
                {
                    foreach (var item in UsuarioLogado.Contas)
                    {
                        if (item.IdConta == UsuarioLogado.ContaLogada)
                        {
                            conta = item;
                        }
                    }

                    
                    conta.Saldo = conta.Saldo + Convert.ToDecimal(txtValorDeposito.Text);

                    //Criando uma conexão
                    SqlConnection conexao =
                               new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pu_conta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    

                }




            }
            catch (Exception ex)
            {

                throw;
            }
            

        }
    }
}
