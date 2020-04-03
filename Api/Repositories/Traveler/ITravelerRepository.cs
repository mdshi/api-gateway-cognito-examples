using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Api
{
    public interface ITravelerRepository : IGenericRepository<Traveler>
    {
        Task<bool> MyCustomRepositoryMethodExampleAsync();
    }
}
