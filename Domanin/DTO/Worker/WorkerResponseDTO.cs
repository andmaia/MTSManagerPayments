using Domain.DTO.Credentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Worker
{
    public class WorkerResponseDTO
    {

        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime FinishedDate { get; set; }
        public bool IsActive { get; set; }
        public float Comission { get; set; }

        public CredentialsResponseDTO? Credentials { get; set; }
        public string? CompanyId {  get; set; }
    }
}
