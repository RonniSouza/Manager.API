using System.ComponentModel.DataAnnotations;

namespace Manager.API.ViewModels
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "O nome não pode ser nulo.")]
        [MinLength(3, ErrorMessage = "O nome deveter no mínimo 3 caracteres.")]
        [MaxLength(80, ErrorMessage = "O nomo deve ter no máximo 80 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O email não pode ser vazio.")]
        [MinLength(10, ErrorMessage = "O email deve ter no mínimo 10 caracteres.")]
        [MaxLength(180, ErrorMessage = "O email deve ter no máximo 180 caracteres.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", 
                            ErrorMessage = "O email informado não é valido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha não pode ser vazia.")]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres.")]
        [MaxLength(80, ErrorMessage = "A senha deve ter no maximo 80 caracteres.")]
        public string Password { get; set; }
    }
}