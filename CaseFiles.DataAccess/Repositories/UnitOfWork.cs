using CaseFiles.Data;
using CaseFiles.DataAccess.Repositories;
using CaseFiles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaseFiles.DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICaseRepository Case { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Case = new CaseRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
