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
    public partial class FormCollection : Form
    {
        public FormCollection()
        {
            InitializeComponent();
        }

        private void FormCollection_Load(object sender, EventArgs e)
        {
            //Declarando e criando array
            string[] meuArrayString = new string[3];

            //Declarando e criando array com valores
            int[] meuArrayInt = { 2, 7, 8, 9, 11 };

            //colocando informações nos arrays
            meuArrayString[0] = "Tobaias";
            //exibindo informações do array
            string mensagemFinal = "";

            for (int contador = 0; contador < meuArrayString.Length; contador++)
            {
                mensagemFinal = mensagemFinal + $"{meuArrayString[contador]}\n";
            }
            MessageBox.Show(meuArrayString[0]);
        }
    }
}
