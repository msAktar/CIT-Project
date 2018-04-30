using StarGrocery.DbModel;
using System.Collections.Generic;

namespace StarGrocery.Repository.Interfaces
{
    public interface IDataRepository
    {
        List<dboUsers> GetAllUsers();
        List<dboCategory> GetAllCategories();
    }
}