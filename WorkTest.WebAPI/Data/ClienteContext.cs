using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkTest.WebAPI.Models;

namespace WorkTest.WebAPI.Data
{
    public class ClienteContext : DbContext
    {
        //ClienteContext
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; } //= new List<Endereco>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=sa123456;Persist Security Info=True;User ID=sa;Initial Catalog=RegisterApp;Data Source=DESKTOP-FTHISJ2");
        }

    }
}
