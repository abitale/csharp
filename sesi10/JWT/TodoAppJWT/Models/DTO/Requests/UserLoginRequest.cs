using System.ComponentModel.DataAnnotations;

namespace TodoAppJWT.Models.DTO.Requests
{
    public class UserLoginRequest
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}