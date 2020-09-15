using CaseFiles.Data;
using CaseFiles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseFiles.DataAccess.Repositories
{
    class CaseRepository : Repository<Case>, ICaseRepository
    {
        private readonly ApplicationDbContext _db;

        public CaseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
