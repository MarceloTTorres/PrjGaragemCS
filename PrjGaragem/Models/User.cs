using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjGaragem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Nivel { get; set; }
        public bool Bloqueado { get; set; }
    }
}
