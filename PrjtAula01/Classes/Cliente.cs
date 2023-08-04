using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjtAula01.Classes
{
    public class Cliente
    {
        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("ID NÃO PODE SER MENOR QUE ZERO");
                }
                else
                {
                    this._id = value;
                }
            }
        }
        public int Nome { get; set; }
    }
}
