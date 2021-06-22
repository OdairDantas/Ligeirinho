using Ligeirinho.API.Entities;
using Ligeirinho.API.ViewModels;

namespace Ligeirinho.API.AutoMappers
{
    public class TokenMappingProfile: MappingProfile
    {
        public TokenMappingProfile()
        {
            CreateMap<Token, TokenViewModel>().ReverseMap();

        }
    }
}
