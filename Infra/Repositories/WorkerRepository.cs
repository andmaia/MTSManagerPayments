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
    public class WorkerRepository : IWorkerRepository
    {

        private readonly DatabaseContext _dbContext;
        public WorkerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> CreateWorker(Worker data)
        {
            await _dbContext.Workers.AddAsync(data);
            await _dbContext.SaveChangesAsync();
            return data.Id;
        }

        public async Task<IEnumerable<Worker>> GetAllWorkersByCompany(string id)
        {
            var workers = await _dbContext.Workers.AsNoTracking()
                .Where(x => x.CompanyId == id).ToListAsync();

            return workers;
        }

        public async Task<IEnumerable<Worker>> GetAvailableWorkersByCompany(string id)
        {
            var availableWorkers = await _dbContext.Workers
                    .AsNoTracking()
                    .Where(w => w.CompanyId == id && w.IsActive)
                    .ToListAsync();

            return availableWorkers;
        }

        public async Task<IEnumerable<Worker>> GetUnavailableWorkersByCompany(string id)
        {
            var UnavailableWorkers = await _dbContext.Workers
                  .AsNoTracking()
                  .Where(w => w.CompanyId == id && w.IsActive==false)
                  .ToListAsync();

            return UnavailableWorkers;
        }

        public async Task<Worker> GetWorkerById(string id)
        {
            Worker result = await _dbContext.Workers.FindAsync(id);
            return result;
        }

        public async Task<Worker> GetWorkersByCPF(string cpf)
        {
            Worker result = await _dbContext.Workers.FirstOrDefaultAsync(c=>c.Cpf==cpf);
            return result;
        }

        public async Task<IEnumerable<Worker>> GetWorkersOrderedByCreationDate(string companyId, bool descending = false)
        {
            var query = _dbContext.Workers
                     .AsNoTracking()
                     .Where(w => w.CompanyId == companyId)
                     .OrderBy(w => w.CreatedDate); 

            if (descending)
            {
                query = query.OrderByDescending(w => w.CreatedDate);
            }

            var workers = await query.ToListAsync();
            return workers;
        }

        public async Task<IEnumerable<Worker>> GetWorkersOrderedByName(string companyId, bool descending = false)
        {
            var query = _dbContext.Workers
                .AsNoTracking()
                .Where(w=>w.CompanyId == companyId)
                .OrderBy(nam => nam.Name);

            if (descending)
            {
                query = query.OrderByDescending(w => w.Name);
            }
            var workers = await query.ToListAsync();
            return workers;
        }

        public async Task<string> UpdateWorker(Worker data)
        {
            try
            {
                _dbContext.Workers.Update(data);
                await _dbContext.SaveChangesAsync();
                return data.Id;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
