using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Helpers
{
    public class ErrorResponse
    {
        public string? Status {  get; set; }
        public string? Message { get; set; }

        public bool Sucess { get; set; }
    }
}
