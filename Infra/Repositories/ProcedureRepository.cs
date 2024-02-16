using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class ProcedureRepository : IProcedureRepository
    {

        private readonly DatabaseContext _databaseContext;

        public ProcedureRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<string> CreateProcedure(Procedure data)
        {
            await _databaseContext.Procedures.AddAsync(data);
            await _databaseContext.SaveChangesAsync();
            return data.Id;
        }

        public async Task<IEnumerable<Procedure>> GetAllProceduresByCompanyId(string companyId)
        {
            var procedures =await  _databaseContext.Procedures.AsNoTracking()
                .Where(c=>c.Worker.CompanyId == companyId).ToListAsync();
            return procedures;
        }

        public async Task<IEnumerable<Procedure>> GetAllProceduresByStatus(string companyId, bool isActive = true)
        {
            var procedures = await _databaseContext.Procedures.AsNoTracking()
                  .Where(c => c.Worker.CompanyId == companyId && c.IsActive ==isActive).ToListAsync();
            return procedures;
        }

        public async Task<Procedure> GetProcedureById(string id)
        {
            var procedure = await _databaseContext.Procedures.FindAsync(id);
            return procedure;
        }

        public async Task<Procedure> GetProcedureByPayment(string id)
        {
            var procedure = await _databaseContext.Procedures.FindAsync(id);
            return procedure;
        }

        public async Task<Procedure> GetProcedureByWorker(string id)
        {
            var procedure = await _databaseContext.Procedures.FindAsync(id);
            return procedure;
        }

        public async Task<string> UpdateProcedure(Procedure data)
        {
            _databaseContext.Procedures.Update(data);
            await _databaseContext.SaveChangesAsync();
            return data.Id;
        }
    }
}
