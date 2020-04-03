using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Api
{
    public interface IMedicalCenterRepository : IGenericRepository<MedicalCenter>
    {
        Task<bool> MyCustomRepositoryMethodExampleAsync();
    }
}
