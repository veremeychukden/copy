using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project_P34.DataAccess.Entity
{
    [Table("tblWishList")]
    public class WishList
    {
        [Key]
        public string Id { get; set; }
     // id product
     // id user
    }
}
