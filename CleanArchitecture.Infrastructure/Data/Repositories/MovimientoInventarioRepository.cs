using CleanArchitecture.Application.Interface;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class MovimientoInventarioRepository : RepositoryBase<MovimientoInventario>, IMovimientoInventarioRepository
    {
        public MovimientoInventarioRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
