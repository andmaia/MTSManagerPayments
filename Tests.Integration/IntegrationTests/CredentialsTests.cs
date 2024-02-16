using Domain.Entities;
using Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Integration.Configurations;

namespace Tests.Integration.IntegrationTests
{
    [Collection("Database collection")]
    public class CredentialsTests
    {
        private readonly IntegrationFixture _fixture;

        public CredentialsTests(IntegrationFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public async Task Create_Should_id_When_SucessufulAsync()
        {
            var credentials = new Credentials()
            {
            };

            var resultId = await _fixture.serviceProvider.GetRequiredService<ICredentialsRepository>().CreateCredentials(credentials);

            Assert.Equal(credentials.Id,resultId);
        }

        [Fact]
        public async Task Update_Should_ReturnUpdatedCredentials_When_SuccessfulAsync()
        {
            var credentials = new Credentials()
            {
                Id = Guid.NewGuid().ToString(),
                Email = "duas vezes",
                Password = "password",
                Permission = CrossCutting.Enums.Permission.MANAGER
            };

            await _fixture.serviceProvider.GetRequiredService<ICredentialsRepository>().CreateCredentials(credentials);

            var retrievedCredentials = await _fixture.serviceProvider.GetRequiredService<ICredentialsRepository>().GetOneCredentialsById(credentials.Id);

            retrievedCredentials.Email = "a@aAtualizado";
            await _fixture.serviceProvider.GetRequiredService<ICredentialsRepository>().UpdateCredentials(retrievedCredentials);
            var updatedCredentials = await _fixture.serviceProvider.GetRequiredService<ICredentialsRepository>().GetOneCredentialsById(credentials.Id);

            Assert.Equal("a@aAtualizado", updatedCredentials.Email);
            Assert.Equal(credentials.Id, updatedCredentials.Id);
        }


    }


}
