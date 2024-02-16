using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICredentialsRepository
    {
        Task <string> CreateCredentials(Credentials data);
        Task<string> UpdateCredentials(Credentials data);
        Task<Credentials> GetOneCredentialsById(string id);
    }
}
