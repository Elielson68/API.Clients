using API.Clients.Domain.Models.ViewModel.Input;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Clients.Domain.Validations
{
    public class RegisterClientValidation: AbstractValidator<ClientRegister>
    {
        public RegisterClientValidation()
        {

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("This field don't be empty!");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("This field don't correct!")
                .NotEmpty().WithMessage("This field don't correct!");

            RuleFor(x => x.PhoneNumber)
                .Matches(@"/(\+\d{2}\s\(\d{2,3}\)\s\d{8,9}|\d{12,14})/g").WithMessage("The format of PhoneNumber not is correct")
                .NotEmpty().WithMessage("This field don't be empty!");
        }

    }
}
