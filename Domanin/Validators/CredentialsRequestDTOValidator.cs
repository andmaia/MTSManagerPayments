using Domain.DTO.Credentials;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class CredentialsRequestDTOValidator:AbstractValidator<DTO.Credentials.CredentialsRequestDTO>
    {
        public CredentialsRequestDTOValidator() 
        {
            RuleFor(x => x.CredentialsId)
              .NotEmpty().WithMessage("CredentialsId cannot be empty.")
              .Length(36).WithMessage("CredentialsId must be a string with 36 characters.");

            RuleFor(x => x.Email)
               .NotEmpty().WithMessage("Email field is required.")
               .EmailAddress().WithMessage("The Email field is not a valid email address.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password field is required.")
                .MinimumLength(8).WithMessage("The password must be at least 8 characters long.")
                .Matches(@"[A-Z]+").WithMessage("The password must contain at least one uppercase letter.")
                .Matches(@"[a-z]+").WithMessage("The password must contain at least one lowercase letter.")
                .Matches(@"[0-9]+").WithMessage("The password must contain at least one number.")
                .Matches(@"[\W_]+").WithMessage("The password must contain at least one special character.");

            RuleFor(x => x.Permission)
                .IsInEnum().WithMessage("The credentials must have a valide permission");

            RuleFor(x => x.ConfirmationPassword)
                .Equal(x => x.Password).WithMessage("Password and Confirm Password do not match.");
        }
    }
}
