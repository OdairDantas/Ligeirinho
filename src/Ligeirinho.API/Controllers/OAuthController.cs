using AutoMapper;
using Ligeirinho.API.Entities;
using Ligeirinho.API.Services;
using Ligeirinho.API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ligeirinho.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OAuthController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOAuthService _oAuthService;
        
        public OAuthController(IMapper mapper, IOAuthService oAuthService)
        {
            _mapper = mapper;
            _oAuthService = oAuthService;
        }

        [HttpPost]
        public async Task<IActionResult> ObterToken(UsuarioViewModel usuario)
        {
            
           var token = _mapper.Map<TokenViewModel>(await _oAuthService.ObterToken(_mapper.Map<Usuario>(usuario)));

            return Ok(token);
        }
    }
}
