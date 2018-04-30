
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarGrocery.DbModel
{

    [Table("Category")]
    public class dboCategory
    {

        [Key]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }

}
