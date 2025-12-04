using FluentValidation;
using Bookly.Domain.Entities;

namespace Bookly.Service.Validators
{
    public class ReadingSessionValidator : AbstractValidator<ReadingSession>
    {
        public ReadingSessionValidator()
        {
            RuleFor(c => c.Date)
                .NotEmpty().WithMessage("The the of the session is required!");
            RuleFor(c => c.PagesReadToday)
                .NotEmpty().WithMessage("The nunber of the pages read today is required!");
            RuleFor(c => c.Book)
                .NotEmpty().WithMessage("The book of the Reading Session is required!");
            RuleFor(c => c.User)
                .NotEmpty().WithMessage("The user of the Reading Session is required!");
            RuleFor(c => c.ReadingProcess)
                .NotEmpty().WithMessage("The reading process of the Reading Session is required!");
        }
    }
}