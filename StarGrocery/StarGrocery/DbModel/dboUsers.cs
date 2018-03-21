using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarGrocery.DbModel
{

    [Table("users")]
    public class dboUsers
    {

        [Key]
        public int userid { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public DateTime? updatedTime { get; set; }
    }

}
