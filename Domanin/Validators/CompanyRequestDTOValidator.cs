using CrossCutting.Helpers;
using Domain.DTO.Company;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validators
{
    public class CompanyRequestDTOValidator:AbstractValidator<CompanyRequestDTO>
    {
        public CompanyRequestDTOValidator() 
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("The company name can not be empty");
            RuleFor(x=>x.Cnpj)
                .Matches(@"^\d+$").WithMessage("The Cnpj field can only contain digits.")
                .Must(DocumentValidator.IsValidCnpj).WithMessage("The Cnpj field is not a valid Cnpj.")
                .When(x => !string.IsNullOrWhiteSpace(x.Cnpj));

        }
    }
}
