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
        private readonly IEFCoreRepository _repo;

        public ClienteController(IEFCoreRepository repo)
        {
            _repo = repo;
        }
        // GET: api/Cliente
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var clientes = await _repo.GetAllClientes();

                return Ok(clientes);
            }
            catch(Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // GET: api/Cliente/5
        [HttpGet("{cpf}", Name = "Get")]
        public async Task<IActionResult> GetCPF(string cpf)
        {
            try
            {
                var cliente = await _repo.GetClientesbyCPF(cpf);

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        // POST: api/Cliente
        [HttpPost]
        public async Task<IActionResult> Post(Cliente model)
        {
            try
            {
                _repo.Add(model);

                if (await _repo.SaveChangeAsync())
                {
                    return Ok("Cadastrado");
                }
                return Ok("Não Cadastrado");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }
        }

        //PUT: api/Cliente/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Cliente model)
        {
            try
            {
                var cliente = await _repo.GetClientebyId(id);
                if (cliente != null)
                {
                    _repo.Update(model);
                    if (await _repo.SaveChangeAsync())
                    { 
                        return Ok("Alterado");
                    }
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex} ");
            }
            return BadRequest($"Não Alterado!");

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cliente = await _repo.GetClientebyId(id);
                if (cliente != null)
                {
                    _repo.Delete(cliente);
                    if(await _repo.SaveChangeAsync())

                    return Ok("Deletado");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex} "); 
            }
            return BadRequest($"Não deletado!");
        }
    }
}

