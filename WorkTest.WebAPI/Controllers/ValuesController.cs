using Microsoft.AspNetCore.Mvc;
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
        [HttpGet("filtro/{nome}")]
        public ActionResult GetFiltro(string nome)
        {
            var listCliente = _context.Clientes
                              .Where(c => c.Nome.Contains(nome))
                              .ToList();
            //var listCliente = (from cliente in _context.Clientes
            //                   where cliente.Nome.Contains(nome)
            //                  select cliente).ToList();

            foreach (var item in listCliente)
            {

            }


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
            cliente.Nome = "Robin";
            //_context.Clientes.Add(cliente);
            _context.SaveChanges();
            
            return Ok();
        }

        // GET api/values/5
        [HttpGet("AddRange")]
        public ActionResult GetAddRange()
        {
            _context.AddRange(
                new Cliente { Nome = "Mikhael" },
                new Cliente { Nome = "Arthur"  },
                new Cliente { Nome = "Matheus" },
                new Cliente { Nome = "Giovana" },
                new Cliente { Nome = "Yasmin"  }
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
