using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjGaragem.Models
{
    public class Foto
    {
        public int Id { get; set; }
        public int idCarro { get; set; }
        public string Caminho { get; set; }
        public string Legenda { get; set; }
    }
}
