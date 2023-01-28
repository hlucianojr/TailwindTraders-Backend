using Tailwind.Traders.Login.Api2.Models;

namespace Tailwind.Traders.Login.Api2.Services
{
    public interface ITokenHandlerService
    {
        TokenResponseModel SignIn(string username);

        TokenResponseModel RefreshAccessToken(string token);
    }
}
