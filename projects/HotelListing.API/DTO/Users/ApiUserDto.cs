using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTO.Users
{
    public class LoginDto : LoginDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

    }
}