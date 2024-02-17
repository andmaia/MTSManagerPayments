using AutoMapper;
using Domain.DTO.PaymentMachine;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AutoMapperProfiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<PaymentMachineRequestDTO, PaymentMachine>();
            CreateMap<PaymentMachine, PaymentMachineResponseDTO>();
        }
    }
}
