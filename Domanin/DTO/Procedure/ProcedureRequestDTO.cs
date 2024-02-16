using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Procedure
{
    public class ProcedureRequestDTO
    {
        public string? CustomerName { get; set; }
        public string? WorkerId { get; set; }
    }
}
