using System.ComponentModel.DataAnnotations;

namespace Movieplayingwebsite.Models.DTO
{
    public class LoginModel
    {
        [Required]
        public string? Username { get; set; }
        //? specifies nullable strings
        [Required]
        public string? Password { get; set; }

    }
}
