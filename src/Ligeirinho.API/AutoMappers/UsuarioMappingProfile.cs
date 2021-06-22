using Ligeirinho.API.Entities;
using Ligeirinho.API.ViewModels;

namespace Ligeirinho.API.AutoMappers
{
    public class UsuarioMappingProfile: MappingProfile
    {
        public UsuarioMappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
        }
    }
}
