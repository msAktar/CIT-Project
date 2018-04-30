using StarGrocery.DBContext;
using StarGrocery.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StarGrocery.DbModel;

namespace StarGrocery.Repository
{
    public class DataRepository : IDataRepository
    {
        protected readonly SGContext Context;

        public DataRepository(SGContext context)
        {
            this.Context = context;
        }

        public List<dboUsers> GetAllUsers()
        {
            var allUsers = (from u in Context.users
                        select u).ToList();
            return allUsers;
        }

        public List<dboCategory> GetAllCategories()
        {
            var allCategories = (from u in Context.categories
                            select u).OrderBy(x=>x.categoryName).ToList();
            return allCategories;
        }
    }
}