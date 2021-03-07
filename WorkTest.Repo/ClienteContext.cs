
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkTest.Dominio;

namespace WorkTest.Repo
{
    public class ClienteContext : DbContext
    {

        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) {}

        //ClienteContext
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; } //= new List<Endereco>();


    }
}
