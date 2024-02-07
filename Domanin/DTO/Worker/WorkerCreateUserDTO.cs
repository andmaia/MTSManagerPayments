using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Worker
{
    public class WorkerCreateUserDTO
    {
        public string? Name { get; set; }
        public float Comission { get; set; }
        public string? CredentialsId { get; set; }
        public string? CompanyId { get; set; }
    }
}
