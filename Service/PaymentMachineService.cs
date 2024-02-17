using AutoMapper;
using CrossCutting.Helpers;
using Domain.DTO.PaymentMachine;
using Domain.Entities;
using Domain.Repositories;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PaymentMachineService : IPaymentMachineService
    {

        private readonly IPaymentMachinesRepository _paymentMachineRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public PaymentMachineService(IPaymentMachinesRepository paymentMachineRepository, ICompanyRepository companyRepository, IMapper mapper)
        {
            _paymentMachineRepository = paymentMachineRepository;
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<ResultService<string>> CreatePaymentMachine(PaymentMachineRequestDTO data)
        {
            var company =await _companyRepository.GetOneCompanyById(data.CompanyId);
            if (company == null)
            {
                return new()
                {
                    Message = "Company not exists",
                    Success =false

                };
            }
                var paymentMachine = _mapper.Map<PaymentMachine>(data);
                paymentMachine.Id = Guid.NewGuid().ToString();
                paymentMachine.CreatedDate = DateTime.Now;
                paymentMachine.LastUpdated = DateTime.MinValue;
                paymentMachine.FinishedDate = DateTime.MinValue;
                paymentMachine.IsActive = true;
                paymentMachine.Company = company;

                var result = await _paymentMachineRepository.CreatePaymentMachine(paymentMachine);

            return new()
            {
                Data = result,
                Success = result != null

            };

        }

        public async Task<ResultService<string>> Disable(string id)
        {
            var paymentMachine = await GetPaymentMachineIfExists(id);
            if (paymentMachine == null)
            {
                return new()
                {
                    Success = false,
                    Message = "Payment machine not exists"
                };
            }

            if (paymentMachine.IsActive == false)
            {
                return new()
                {
                    Success = false,
                    Message = "Payment machine already is disabled"
                };
            }

            paymentMachine.FinishedDate = DateTime.Now;
            paymentMachine.IsActive = false;

            var result = await _paymentMachineRepository.UpdatePaymentMachine(paymentMachine);

            return new()
            {
                Data = result,
                Success = result != null
            };

        }

        public async Task<ResultService<string>> Enable(string id)
        {
            var paymentMachine = await GetPaymentMachineIfExists(id);

            if (paymentMachine == null)
            {
                return new()
                {
                    Success = false,
                    Message = "Payment machine not exists"
                };
            }

            if (paymentMachine.IsActive == true)
            {
                return new()
                {
                    Success = false,
                    Message = "Payment machine already is enable"
                };
            }

            paymentMachine.FinishedDate = DateTime.MinValue;
            paymentMachine.IsActive = true;

            var result = await _paymentMachineRepository.UpdatePaymentMachine(paymentMachine);

            return new()
            {
                Data = result,
                Success = result != null
            };
        }

        public async Task<ResultService<IEnumerable<PaymentMachineResponseDTO>>> GetAllPaymentMachineByCompany(string id)
        {
            var paymentMachines = await _paymentMachineRepository.GetAllPaymentMachineByCompany(id);

            if (paymentMachines == null || !paymentMachines.Any())
            {
                return new ResultService<IEnumerable<PaymentMachineResponseDTO>>
                {
                    Success = false,
                    Message = "The company does not have any payment machines yet"
                };
            }

            var paymentMachineMappeds = paymentMachines.Select(paymentMachine => _mapper.Map<PaymentMachineResponseDTO>(paymentMachine)).ToList();

            return new()
            {
                Success = true,
                Data = paymentMachineMappeds
            };
        }

        public Task<ResultService<PaymentMachineResponseDTO>> GetPaymentMachine(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultService<string>> UpdatePaymentMachine(PaymentMachineRequestDTO data)
        {
            var paymentMachine = await GetPaymentMachineIfExists(data.Id);

            if (paymentMachine == null)
            {
                return new()
                {
                    Success = false,
                    Message = "Payment machine not exists"
                };
            }

            _mapper.Map(data, paymentMachine);

            var result =await _paymentMachineRepository.UpdatePaymentMachine(paymentMachine);
            return new()

            {
                Data = result,
                Success = result != null
            };
        }

     

        private async Task<PaymentMachine?> GetPaymentMachineIfExists(string id)
        {
            var paymentMachine =await _paymentMachineRepository.GetPaymentMachineById(id);
            if(paymentMachine != null)
            {
                return paymentMachine;
            }
            return null;
        }

    }
}
