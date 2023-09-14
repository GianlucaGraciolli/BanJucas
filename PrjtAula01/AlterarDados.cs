using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
