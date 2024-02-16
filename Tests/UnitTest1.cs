using Domain.Entities;
using Domain.Repositories;
using Infra.Repositories;

namespace Tests
{
    public class UnitTest1
    {


        
        [Fact]
        public void CreateCredentialsShouldReturnTrueWhenCreated()
        {

            Credentials credentials = new Credentials()
            {
                Id = Guid.NewGuid().ToString(),
                Email = "TESTE@gmail",  
                Password = "1234567",
                Permission = CrossCutting.Enums.Permission.MANAGER
            };

            var _credentialsRepository = new CredentialsRepository(new Infra.DatabaseContext())
            _credentialsRepository.CreateCredentials(credentials);
        }
    }
}