using CrossCutting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Credentials
{
    public class CredentialsRequestDTO
    {
        public string? CredentialsId { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public Permission Permission { get; set; }
        public string? ConfirmationPassword {  get; set; }
    }
}
