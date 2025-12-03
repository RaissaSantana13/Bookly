using FluentValidation;
using Bookly.Domain.Entities;

namespace Bookly.Service.Validatorrs
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("The name of the author is required!");
            // RuleFor(c => c.Books)
               // .NotEmpty().WithMessage("The books of the author is required!");
        }
    }
}