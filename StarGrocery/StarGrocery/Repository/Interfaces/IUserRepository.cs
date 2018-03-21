using StarGrocery.DbModel;
using System.Collections.Generic;

namespace StarGrocery.Repository.Interfaces
{
    public interface IUserRepository
    {
        List<dboUsers> GetAllUsers();
    }
}