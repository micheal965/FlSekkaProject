using Int.Core.Entities;
using Int.Core.Repositories.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InT.Repository.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        private readonly FiElSekkaContext _context;

        public CarRepository(FiElSekkaContext context) : base(context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
