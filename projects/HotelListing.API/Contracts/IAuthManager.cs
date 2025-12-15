using HotelListing.API.DTO.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(LoginDto userDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);
    }
}
