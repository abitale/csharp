using System.ComponentModel.DataAnnotations;

namespace TodoAppJWT.Models.DTO.Requests
{
    public class UserRegistrationDto
    {
        [Required]
        public string username {get;set;}
        [Required]
        public string email {get;set;}
        [Required]
        public string password {get;set;}
    }
}