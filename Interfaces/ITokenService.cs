using CapHead.Models;

namespace CapHead.Repositories;

public interface ITokenService
{
    Task<string> CreateToken(AppUser user);
}