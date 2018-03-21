using StarGrocery.DBContext;
using StarGrocery.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarGrocery.DbModel;

namespace StarGrocery.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly SGContext Context;

        public UserRepository(SGContext context)
        {
            this.Context = context;
        }

        public List<dboUsers> GetAllUsers()
        {
            var allUsers = (from u in Context.users
                        select u).ToList();
            return allUsers;
        }
    }
}