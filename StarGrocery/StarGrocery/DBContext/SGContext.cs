using StarGrocery.DbModel;
using System.Data.Entity;

namespace StarGrocery.DBContext
{
    public class SGContext : DbContext
    {
        public SGContext() : base("name=localDB")
        {
            this.Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer<SGContext>(null);
            var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public virtual DbSet<dboUsers> users { get; set; }
        public virtual DbSet<dboCategory> categories { get; set; }
    }
}