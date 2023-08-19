using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjtAula01
{
    internal class UIClear
    {
        public void CleanTxtBoxes(Form form)
        {
            foreach (Control controle in form.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Clear();
                }
            }            
        }
    }
}
