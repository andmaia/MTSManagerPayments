using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Worker
{
    public class WorkerUpdateDTO
    {
        public string? Name { get; set; }
        public string? Cpf { get; set; }
        public float Comission { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
