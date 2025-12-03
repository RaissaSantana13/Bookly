using FluentValidation;
using Bookly.Domain.Entities;

namespace Bookly.Service.Validatorrs
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("The name of the user is required!");
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("The email of the user is required!");
            RuleFor(p => p.Password)
                .NotEmpty().WithMessage("Sua senha não poder ser vazia")
                .MinimumLength(8).WithMessage("Sua senha deve ter no mínimo 8 caracteres.")
                .MaximumLength(16).WithMessage("Sua senha deve ter no máximo 16 caracteres.")
                .Matches(@"[A-Z]+").WithMessage("Sua senha deve conter pelo menos uma letra maiúscula.")
                .Matches(@"[a-z]+").WithMessage("Sua senha deve conter pelo menos uma letra minúscula.")
                .Matches(@"[0-9]+").WithMessage("Sua senha deve conter pelo menos um número.")
                .Matches(@"[\!\?\*\.\@]+").WithMessage("Sua senha deve conter pelo menos um caractere especial (! ? * .).");
            RuleFor(c => c.RegistrationDate)
                .NotEmpty().WithMessage("The registration date of the user is required!");

        }
    }
}