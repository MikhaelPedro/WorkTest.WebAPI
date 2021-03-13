using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WorkTest.Dominio;
using WorkTest.Repo;

namespace WorkTest.Repo
{
    public interface IEFCoreRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangeAsync();

        Task<Cliente[]> GetAllClientes(bool incluirEndereco = false);
        Task<Cliente> GetClientebyId(int id);
        Task<Cliente> GetClientesbyCPF(string cpf);


    }
}
