using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IProcedureRepository
    {
        Task<string> CreateProcedure(Procedure data);
        Task<string> UpdateProcedure(Procedure data);
        Task<Procedure> GetProcedureById (string id);
        Task<Procedure> GetProcedureByPayment(string id);
        Task<Procedure> GetProcedureByWorker(string id);

        Task<IEnumerable<Procedure>> GetAllProceduresByCompanyId(string companyId);
        Task<IEnumerable<Procedure>> GetAllProceduresByStatus(string companyId,bool isActive=true);

    }
}
