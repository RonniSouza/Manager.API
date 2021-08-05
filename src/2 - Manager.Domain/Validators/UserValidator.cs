using FluentValidation;
using Manager.Domain.Entities;

namespace Manager.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia.")

                .NotNull()
                .WithMessage("A entidade não pode ser nula.");

            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("O nome não pode ser nulo.")

                .NotNull()
                .WithMessage("O nome não pode ser nulo.")

                .MinimumLength(6)
                .WithMessage("O nome deve ter no mínimo 3 caracteres")

                .MinimumLength(6)
                .WithMessage("O nome deve ter no mínimo 80 caracteres");

            RuleFor(x => x.Password)
                .NotNull()
                .WithMessage("A senha não pode ser nulo. ")

                .NotNull()
                .WithMessage("A senha não pode ser vazio.")

                .MinimumLength(6)
                .WithMessage("A senha deve ter no mínimo 6 caracteres")

                .MaximumLength(30)
                .WithMessage("A senha deve ter no mãximo 30 caracteres");

            RuleFor(x => x.Email)
                .NotNull()
                .WithMessage("O email não pode ser nulo.")

                .NotNull()
                .WithMessage("O email não pode ser vazio.")

                .MinimumLength(10)
                .WithMessage("O email deve ter no mínimo 3 caracteres")

                .MaximumLength(100)
                .WithMessage("O email deve ter no máximo 80 caracteres")
                
                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("O email informado não é válido");

            
        }

    }
}