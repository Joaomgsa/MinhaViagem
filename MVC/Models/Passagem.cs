using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaViagem_V1.Models
{
    public class Passagem
    {
        public int PassagemID { get; set; }

        public int DestinoID { get; set; }

        public int ClienteID { get; set; }

        public DateTime DataViagem { get; set; }
        
        public Cliente Cliente { get; set; }

        public Destino Destino { get; set; }

    }
}
