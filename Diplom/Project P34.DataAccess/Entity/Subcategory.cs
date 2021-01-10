using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project_P34.DataAccess.Entity
{
    [Table("tblSubCategory")]
   public class Subcategory
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

      
        //Id subcategory
    }
}
