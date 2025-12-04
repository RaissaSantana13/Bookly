using FluentValidation;
using Bookly.Domain.Entities;

namespace Bookly.Service.Validators
{
    public class GenreValidator : AbstractValidator<Genre>
    {
        public GenreValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("The name of the genre is required!");
            //RuleFor(c => c.Books)
                //.NotEmpty().WithMessage("The book of the genre is required!");
        }
    }
}