using System.ComponentModel.DataAnnotations;

namespace SupermarketWEB.Data
{
    public class User
    {
       [Required]
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
