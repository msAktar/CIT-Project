using StarGrocery.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarGrocery.Repository.Interfaces;

namespace StarGrocery.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SGContext _context;

        public UnitOfWork()
        {
            _context = new SGContext();
            DataRepo = new DataRepository(_context);
        }


        public IDataRepository DataRepo { get; private set; }

        public int SaveChanges()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}