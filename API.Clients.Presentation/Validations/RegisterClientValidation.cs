using API.Clients.Dto;
using API.Clients.Models;
using FluentValidation;

namespace API.Clients.Validations
{
    public class RegisterClientValidation: AbstractValidator<Client>
    {
        public RegisterClientValidation()
        {

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("This field don't be empty!");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("This field is not correct!")
                .NotEmpty().WithMessage("This field don't be empty!");

            RuleFor(x => x.PhoneNumber)
                .Matches(@"(\+\d{2}\s\(\d{2,3}\)\s\d{8,9}|\d{12,14})").WithMessage("The format of PhoneNumber not is correct. Accepted formats: +55 (91) 940028922 or 5591940028922")
                .NotEmpty().WithMessage("This field don't be empty!");
        }

    }
}
