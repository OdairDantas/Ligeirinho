using System.ComponentModel.DataAnnotations;

namespace Ligeirinho.API.ViewModels
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "Nome é Obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é Obrigatório!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é Obrigatória!")]
        [StringLength(255, ErrorMessage = "Deve ter entre 5 e 255 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }


    }
}
