using StarGrocery.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
               var users = dbTask.UserRepo.GetAllUsers();
            }
        }
    }
}