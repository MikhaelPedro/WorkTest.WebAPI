using Microsoft.AspNetCore.Http;
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
    public class ClienteController : ControllerBase
    {
        public readonly ClienteContext _context;

        public ClienteController(ClienteContext context)
        {
            _context = context;
        }
        // GET: api/Cliente
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(new Cliente());
            }
            catch(Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST: api/Cliente
        [HttpPost]
        public ActionResult Post(Cliente model)
        {
            try
            {               
                _context.Clientes.Add(model);
                _context.SaveChanges();

                return Ok("Cadastrado");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        //PUT: api/Cliente/5
        [HttpPut("{id}")]
        public ActionResult Put (int id, Cliente model)
        {
            try
            {
                if (_context
                    .Clientes
                    .AsNoTracking()
                    .FirstOrDefault(c => c.Id == id) != null)
                {
                    _context.Clientes.Update(model);
                    _context.SaveChanges();

                    return Ok("Atualizado");
                }
                return Ok("Não Encontrado!");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex} ");
            }
           
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        /*

        //Get : api/Cliente/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get (int id)

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]

        public void Put(int id, [FromBody] string value)
        {
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        */
    }
}

