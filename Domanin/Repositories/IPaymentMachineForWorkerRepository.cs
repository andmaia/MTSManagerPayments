using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IPaymentMachineForWorkerRepository
    {
        Task<PaymentMachineForWorker> GetPaymentMachineForWorkerById(string id);
        Task<IEnumerable<PaymentMachineForWorker>> GetPaymentMachineForWorkersByMachine (string machineId,bool isActive=true);
        Task<IEnumerable<PaymentMachineForWorker>> GetPaymentMachineForWorkersByMWorker(string workId, bool isActive = true);

        Task<IEnumerable<PaymentMachineForWorker>> GetAllPaymentMachineForWorkersByCompany(string companyId);

        Task<string> CreatePaymentMachineForWorker(PaymentMachineForWorker paymentMachineForWorker);
        Task<string> UpdatePaymentMachineForWorker (PaymentMachineForWorker paymentMachineForWorker);

    }
}
