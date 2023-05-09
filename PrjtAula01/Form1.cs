using System.Diagnostics.Eventing.Reader;

namespace PrjtAula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            //c�digo quando o bot�o ENTRAR for clicado

            string mensagem;

            if (CaixaLogin.Text == String.Empty || CaixaSenha.Text == String.Empty)
            {
                mensagem = "Dados n�o informados";
            }
            else if (CaixaLogin.TextLength < 11 || CaixaSenha.TextLength < 6)
            {
                mensagem = "Preencha os dados corretamente";
            }

            else
            {
                if (CaixaLogin.Text == "12345678900" && CaixaSenha.Text == "123456")
                {
                    mensagem = "Usu�rio Verificado";
                }
                else
                {
                    mensagem = "Usu�rio Inexistente";
                }

            }
            // Mensagem.Text = mensagem; // mensagem em um label

            MessageBox.Show(mensagem, "Aviso!");
        }
    }
}