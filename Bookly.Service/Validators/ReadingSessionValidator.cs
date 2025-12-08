using FluentValidation;
using Bookly.Domain.Entities;

namespace Bookly.Service.Validators
{
    public class ReadingSessionValidator : AbstractValidator<ReadingSession>
    {
        public ReadingSessionValidator()
        {
            RuleFor(c => c.Date)
                 .NotEmpty().WithMessage("The date of the session is required!");

            RuleFor(c => c.PagesReadToday)
                .NotEmpty().WithMessage("The number of pages read today is required!"); 
            RuleFor(c => c.BookId)
                .NotEmpty().WithMessage("The book ID is required!");

            RuleFor(c => c.UserId)
                .NotEmpty().WithMessage("The user ID is required!");

            RuleFor(c => c.ReadingProcessId)
                .NotEmpty().WithMessage("The reading process ID is required!");
        }
    }
}