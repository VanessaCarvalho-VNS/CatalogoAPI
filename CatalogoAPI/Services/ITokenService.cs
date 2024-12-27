using CatalogoAPI.Models;

namespace CatalogoAPI.Services
{
    public interface ITokenService
    {
        string GerarToken(string key, string issuer, string audience, UserModel user);
    }
}
