using Ligeirinho.API.Entities;
using System.Threading.Tasks;

namespace Ligeirinho.API.Services
{
    public interface IOAuthService
    {
        Task<Token> ObterToken(Usuario usuario);
    }
}