using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaViagem_V1.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string SobreNome { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public ICollection<Passagem> Passagens { get; set; }
    }
}
