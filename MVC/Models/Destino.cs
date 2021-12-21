using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaViagem_V1.Models
{
    
    public class Destino
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DestinoID { get; set; }

        public string NomeDestino { get; set; }

        public string CidadeDestino { get; set; }

        public double ValorPassagem { get; set; }

        public ICollection<Passagem> Passagens { get; set; }

    }
}
