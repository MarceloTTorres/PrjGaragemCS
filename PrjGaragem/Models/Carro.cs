using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjGaragem.Models
{
    public class Carro
    {
        public int Id { get; set; }

        public string NomeProprietario { get; set; }
        public string Renavam { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }
        public double Km { get; set; }
        public int QtdPortas { get; set; }
        public string Placa { get; set; }
        public int Exibicoes { get; set; }
        public int Views { get; set; }
        public double PrecoCompra { get; set; }
        public double MargemMinima { get; set; }
        public double PrecoVenda { get; set; }
    }
}
