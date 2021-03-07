using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkTest.Dominio
{
    public class Cliente
    {
        //CLASSE CLIENTE
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public List<Endereco> Enderecos { get; set; }
        //public ICollection<Endereco> Endereco { get; set; }




    }
}
