using System.ComponentModel.DataAnnotations;

namespace CRUD_With_Client_ServerValidation.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MinLength(3, ErrorMessage = "min length is 3")]
        [MaxLength(20, ErrorMessage = "max length is 20")]

        public string Name { get; set; }

        [Required]
        [Range(20, 80)]
        public int Age { get; set; }
        
        public string City { get; set; }
    }
}
