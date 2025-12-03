using FluentValidation;
using Bookly.Domain.Entities;

namespace Bookly.Service.Validatorrs
{
    public class ReadingProcessValidator : AbstractValidator<ReadingProcess>
    {
        public ReadingProcessValidator()
        {
            RuleFor(c => c.StartDate)
                .NotEmpty().WithMessage("The start date of the reading process is required!");
            RuleFor(c => c.User)
                .NotEmpty().WithMessage("The user of the reading process is required!");
            RuleFor(c => c.Book)
                .NotEmpty().WithMessage("The book of the reading process is required!");
        }
    }
}