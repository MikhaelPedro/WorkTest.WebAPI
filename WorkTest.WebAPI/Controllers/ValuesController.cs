using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkTest.Dominio;
using WorkTest.Repo;

namespace WorkTest.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly ClienteContext _context;
        public ValuesController(ClienteContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet("filtro/{cpf}")]
        public ActionResult GetFiltro(string cpf)
        {
            var listCliente = _context.Clientes
                              .Where(c => EF.Functions.Like(c.CPF, $"%{cpf}%"))
                              .OrderBy(h => h.CPF)
                              .LastOrDefault();
            //var listCliente = (from cliente in _context.Clientes
            //                   where cliente.Nome.Contains(nome)
            //                  select cliente).ToList();

            //foreach (var item in listCliente)
            //{

            //}


            return Ok(listCliente);
        }

    // GET api/values/5
    [HttpGet("Atualizar/{nameClient}")]
    public ActionResult Get(string nameClient)
    {
        //var cliente = new Cliente { Nome = nameClient };

        var cliente = _context.Clientes
                          .Where(c => c.Id == 2)
                          .FirstOrDefault();
        cliente.Nome = "Mikhael Sclengmann";
        //_context.Clientes.Add(cliente);
        _context.SaveChanges();

        return Ok();
    }

    // GET api/values/5
    [HttpGet("AddRange")]
    public ActionResult GetAddRange()
    {
        _context.AddRange(
                new Cliente { Nome = "Mikhael", CPF = "59862801858",  Email = "mikhael@gmail.com", Telefone = "11958462065" },
                new Cliente { Nome = "Beatriz", CPF = "12856254865", Email = "Beatriz@gmail.com", Telefone = "11985029530" },
                new Cliente { Nome = "Matheus", CPF = "25925382693", Email = "Matheus@gmail.com", Telefone = "11943128502" },
                new Cliente { Nome = "Giovana", CPF = "56851656645", Email = "Giovana@gmail.com", Telefone = "11967825430" },
                new Cliente { Nome = "Yasmin", CPF = "06575963506", Email = "Yasmin@gmail.com", Telefone = "11995782567" }
            );
        _context.SaveChanges();

        return Ok();
    }


    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpGet("Delete/{id}")]
    public void Delete(int id)
    {
        var cliente = _context.Clientes
                              .Where(x => x.Id == id)
                              .Single();
        _context.Clientes.Remove(cliente);
        _context.SaveChanges();
    }
}
}
