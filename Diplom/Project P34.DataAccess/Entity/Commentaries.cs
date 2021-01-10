using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project_P34.DataAccess.Entity
{
    [Table("tblCommentaries")]
   public class Commentaries
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime DateComment { get; set; }

        public string UserId { get; set; }
        public UserMoreInfo UserMoreInfo { get; set; }

        //Id uSER
        //Id subcategory

    }
}
