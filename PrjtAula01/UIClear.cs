using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjtAula01
{
    public static class UIClear
    {
        public static void CleanTxtBoxes(Form form)
        {
            foreach (Control controle in form.Controls)
            {
                if (controle is TextBox || controle is ComboBox)
                {
                    controle.Text = string.Empty;
                }
                else if (controle is DateTimePicker)
                {
                    controle.Text = DateTime.Now.ToString();
                }
            }            
        }
    }
}
