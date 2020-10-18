using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Premium.Calculator.Persistence.Repositories
{
    public interface IUnitOfWork : IDisposable
    {        
        void Save();

        Task<int> SaveChangesAsync();
    }
}
