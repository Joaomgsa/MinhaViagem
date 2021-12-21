using MinhaViagem_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaViagem_V1.Data
{
    public class DbInitializer
    {
        public static void Initialize(AgenciaContext context)
        {
            context.Database.EnsureCreated();

            //Procurando por algum cliente
            if (context.Clientes.Any())
            {
                return; // DB já Populado
            }

            var clientes = new Cliente[]
            {

                new Cliente{Nome="Carson",SobreNome="Wentz",Cpf="78945612325",Email="carsonwentz@gmail.com"},
                new Cliente{Nome="Dak",SobreNome="Prescott",Cpf="87456987845",Email="dak@gmail.com"},
                new Cliente{Nome="Geno",SobreNome="Smith",Cpf="46578912336",Email="genosmith@hotmail.com"}
            };
            foreach (Cliente c in clientes)
            {
                context.Clientes.Add(c);
            }
            context.SaveChanges();

            var destinos = new Destino[]
            {
                new Destino{DestinoID=1024,NomeDestino="Campo Grande",CidadeDestino="Rio de Janeiro",ValorPassagem=299.0},
                new Destino{DestinoID=3046,NomeDestino="Chapada Diamantina",CidadeDestino="Lencois",ValorPassagem=799.0},
                new Destino{DestinoID=2035,NomeDestino="Porto de Galinhas",CidadeDestino="Ipojuca",ValorPassagem=999.0},
                new Destino{DestinoID=1019,NomeDestino="NY",CidadeDestino="Nova Iorque",ValorPassagem=2999.9},
                new Destino{DestinoID=1648,NomeDestino="Sydney",CidadeDestino="Sydney",ValorPassagem=4990.9},
                new Destino{DestinoID=1716,NomeDestino="Taj Mahal",CidadeDestino="Agra",ValorPassagem=9999.9}
            };
            foreach (Destino d in destinos)
            {
                context.Destinos.Add(d);
            }
            context.SaveChanges();


            var passagens = new Passagem[]
            {
                new Passagem{ClienteID=1,DestinoID=1024,DataViagem=DateTime.Parse("2021-09-01")},
                new Passagem{ClienteID=2,DestinoID=3046,DataViagem=DateTime.Parse("2021-10-01")},
                new Passagem{ClienteID=3,DestinoID=2035,DataViagem=DateTime.Parse("2021-07-01")},
                new Passagem{ClienteID=1,DestinoID=1019,DataViagem=DateTime.Parse("2021-05-01")},
                new Passagem{ClienteID=2,DestinoID=1648,DataViagem=DateTime.Parse("2021-03-01")},
                new Passagem{ClienteID=3,DestinoID=1716,DataViagem=DateTime.Parse("2021-04-01")}
            };
            foreach (Passagem p in passagens)
            {
                context.Passagens.Add(p);
            }
            context.SaveChanges();
        }
    }
}
