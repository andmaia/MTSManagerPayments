using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IWorkerRepository
    {
        Task<Worker> GetWorkerById(string id);
        Task<string> CreateWorker(Worker data);
        Task<string> UpdateWorker(Worker data);
        Task<IEnumerable<Worker>> GetAvailableWorkersByCompany(string id);
        Task<IEnumerable<Worker>> GetUnavailableWorkersByCompany(string id);
        Task<IEnumerable<Worker>> GetAllWorkersByCompany(string id);

        Task<IEnumerable<Worker>> GetWorkersOrderedByName(string companyId, bool descending = false);
        Task<IEnumerable<Worker>> GetWorkersOrderedByCreationDate(string companyId, bool descending = false);
        Task<Worker> GetWorkersByCPF( string cpf);

    }
}
