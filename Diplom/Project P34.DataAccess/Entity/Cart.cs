using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project_P34.DataAccess.Entity
{
    [Table("tblCart")]
   public class Cart
    {
        [Key]
        public string Id { get; set; }
        //Id product
        //id user
    }
}
