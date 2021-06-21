using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjGaragem.Models
{
    public class Imposto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int IdCarro { get; set; }
        public DateTime Vencimento { get; set; }
        public bool Pago { get; set; }
    }
}
