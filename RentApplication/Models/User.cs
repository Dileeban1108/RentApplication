using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentApplication.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        [Column(TypeName = "nvarchar(10000)")]
        public string Name { get; set; } = "";
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; } = "";
        [Column(TypeName = "nvarchar(20)")]
        public string Password { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public int PhoneNumber { get; set; }
        
           
    }
}
