using StarGrocery.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarGrocery.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IDataRepository DataRepo { get; }
        int SaveChanges();
    }
}