using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Data.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [Range( 3 , 20)]
        public int Password { get; set; }
        [StringLength(1)]
        public string AdminRole { get; set; }

    }
}
