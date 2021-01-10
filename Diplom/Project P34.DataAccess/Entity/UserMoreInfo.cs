using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project_P34.DataAccess.Entity
{
    [Table("tblUserMoreInfo")]
    public class UserMoreInfo
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string Promocode { get; set; }

        [Required]
        public string Image { get; set; }

        //id comment 1user - 8comment
        //id zhaloba 1user - 8comment
        //id wishlist 1user - 1wishlist
        //id cart  1user - 1wishlist
        public ICollection<Commentaries> Commentariess {get;set;}
        public virtual User User { get; set; }
    }
}
