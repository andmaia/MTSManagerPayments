using CrossCutting.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Credentials
{
    public class CredentialsResponseDTO
    {
        public string? Id { get; set; }
        public string? Email { get; set; }
        public Permission Permission { get; set; }

    }
}
