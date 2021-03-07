using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTest.Dominio
{
    public class Endereco
    {
        //CLASSE ENDEREÇO
        public int Id { get; set; }
        public string NomeEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public Cliente Cliente { get; set; }
        //public Cliente Cliente { get; set; }
        //public int ClienteId { get; set; }




    }
}
