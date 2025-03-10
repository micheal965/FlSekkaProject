using Int.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int.Core.Repositories.Contract
{
    public interface ICarRepository : IGenericRepository<Car>
    {
        Task SaveChangesAsync();
    }
}
