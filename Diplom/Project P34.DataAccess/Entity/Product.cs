using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project_P34.DataAccess.Entity
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Image { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string CountryMade { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Rating { get; set; }
    //id subcategory
   //id images
     
    }
}
