using FluentValidation;
using Bookly.Domain.Entities;

namespace Bookly.Service.Validators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(c => c.Title)
                .NotEmpty().WithMessage("The title of the book is required!");
            RuleFor(c => c.Pages)
                .NotEmpty().WithMessage("The number pages of the book is required!");
            RuleFor(c => c.PublicationYear)
                .NotEmpty().WithMessage("The publication year of the book is required!");
            RuleFor(c => c.Authors)
                .NotEmpty().WithMessage("The authors of the book is required!");
            RuleFor(c => c.Genres)
                .NotEmpty().WithMessage("The genres of the book is required!");
        }
    }
}