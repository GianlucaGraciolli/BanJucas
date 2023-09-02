    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Conta
    {
        public int IdConta { get; set; }
        public int IdCliente { get; set; }
        public string StatusConta { get; set; }
        public string TipoConta { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public DateTime AberturaConta { get; set; }
        public DateTime? EncerramentoConta { get; set; }
        public string SenhaConta { get; set; }
    }
}
