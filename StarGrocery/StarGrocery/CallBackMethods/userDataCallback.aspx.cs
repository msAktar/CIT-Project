using StarGrocery.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StarGrocery
{
    public partial class userDataCallback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (IUnitOfWork dbTask = new UnitOfWork())
            {
               var users = dbTask.DataRepo.GetAllUsers();
            }
        }

        [WebMethod]
        public static object GetCategories()
        {
            using (IUnitOfWork dbTask = new UnitOfWork())
            {
                var data = dbTask.DataRepo.GetAllCategories();

                return data;
            }

        }

    }
}