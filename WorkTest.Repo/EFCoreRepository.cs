using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WorkTest.Dominio;

namespace WorkTest.Repo
{
    public class EFCoreRepository : IEFCoreRepository
    {
        private readonly ClienteContext _context;

        public EFCoreRepository(ClienteContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        
        public async Task<bool> SaveChangeAsync()
        {
            return(await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Cliente[]> GetAllClientes(bool incluirEndereco = false)
        {
            IQueryable<Cliente> query = _context.Clientes
                .Include(c => c.Enderecos);

            query = query.AsNoTracking().OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Cliente> GetClientebyId(int id)
        {
            IQueryable<Cliente> query = _context.Clientes
                .Include(c => c.Enderecos);

            query = query.AsNoTracking().OrderBy(c => c.Id);

            return await query.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Cliente> GetClientesbyCPF(string cpf)
        {
            IQueryable<Cliente> query = _context.Clientes
                .Include(c => c.Enderecos);

            query = query.AsNoTracking()
                .Where(c => c.CPF.Contains(cpf))
                .OrderBy(c => c.CPF);

            return await query.FirstOrDefaultAsync(c => c.CPF.Contains(cpf));
        }

    }
}
