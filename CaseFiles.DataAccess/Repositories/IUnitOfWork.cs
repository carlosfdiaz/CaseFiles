using System;
using System.Collections.Generic;
using System.Text;

namespace CaseFiles.DataAccess.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
