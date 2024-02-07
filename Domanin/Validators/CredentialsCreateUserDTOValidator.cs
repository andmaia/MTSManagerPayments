using Domain.DTO.Credentials;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class CredentialsCreateUserDTOValidator:AbstractValidator<CredentialsCreateUserDTO>
    {
        public CredentialsCreateUserDTOValidator() 
        {
            RuleFor(x => x.Email)
               .NotEmpty().WithMessage("Email field is required.")
               .EmailAddress().WithMessage("The Email field is not a valid email address.");

            RuleFor(x => x.Permission)
                .IsInEnum().WithMessage("The credentials must have a valide permission");
        }
    }
}
