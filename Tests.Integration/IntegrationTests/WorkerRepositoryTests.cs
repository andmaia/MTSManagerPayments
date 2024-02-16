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

    public class WorkerRepositoryTests
    {
        private readonly IntegrationFixture _fixture;

        public WorkerRepositoryTests(IntegrationFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact] 
        public async void GetUnavaliableWorkersByCompany_should_Return_expected_workers()
        {
            int expected = 1;
            string companyId = "d47c04d8-7fca-4b38-a9f8-378ea1a20222";
            var result = await _fixture.serviceProvider.GetRequiredService<IWorkerRepository>().GetUnavailableWorkersByCompany(companyId);

            Assert.Equal(expected, result.Count());
        }


        [Fact]
        public async void GetAvaliableWorkersByCompany_should_Return_expected_workers()
        {
            int expected = 3;
            string companyId = "d47c04d8-7fca-4b38-a9f8-378ea1a20222";
            var result = await _fixture.serviceProvider.GetRequiredService<IWorkerRepository>().GetAvailableWorkersByCompany(companyId);

            Assert.Equal(expected, result.Count());
        }

        [Fact]
        public async void GetAllWorkersByCompany_should_Return_expected_workers()
        {
            int expected = 4;
            string companyId = "d47c04d8-7fca-4b38-a9f8-378ea1a20222";
            var result = await _fixture.serviceProvider.GetRequiredService<IWorkerRepository>().GetAllWorkersByCompany(companyId);

            Assert.Equal(expected, result.Count());
        }

        [Fact]
        public async void GetWorkByCPF_should_Return_expected_work()
        {
            string cpf = "44455566677";
            var result = await _fixture.serviceProvider.GetRequiredService<IWorkerRepository>().GetWorkersByCPF(cpf);

            Assert.Equal(cpf, result.Cpf);
        }
        [Fact]
        public async Task GetWorkById_should_Return_expected_work()
        {
            string id = "2cb9e432-001e-4f05-98a5-dfaae11bda0a";
            var result = await _fixture.serviceProvider.GetRequiredService<IWorkerRepository>().GetWorkerById(id);

            Assert.Equal(id, result.Id);
        }


            [Fact]
            public async Task CreateWorker_Should_Return_Expected_Id()
            {
                // Arrange
                string companyID = "d47c04d8-7fca-4b38-a9f8-378ea1a20222";

                var credentials = new Credentials
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = "worker_teste_isolado@example.com",
                    Password = "password_test",
                    Permission = CrossCutting.Enums.Permission.ARTIST
                };

                _fixture.DbContext.Add(credentials);

                var worker = new Worker()
                {
                    Id = Guid.NewGuid().ToString(),
                    CompanyId = companyID,
                    CredentialsId = credentials.Id,
                    Name = "Worker_teste_usolado",
                    Cpf = "11122233344",
                    CreatedDate = DateTime.Now,
                    LastUpdated = DateTime.Now,
                    FinishedDate = DateTime.MinValue,
                    IsActive = true,
                    Comission = 0.1f
                };

                worker.Credentials = credentials;

                var result = await _fixture.serviceProvider.GetRequiredService<IWorkerRepository>().CreateWorker(worker);

                Assert.Equal(worker.Id, result);
            }

        [Fact]
        public async Task UpdateWorker_should_return_string_when_sucessfull()
        {

            string id = "2cb9e432-001e-4f05-98a5-dfaae11bda0a";
            var worker = await _fixture.serviceProvider.GetRequiredService<IWorkerRepository>().GetWorkerById(id);
            worker.Name = "Atualizado";
            worker.IsActive = false;

            var result = await _fixture.serviceProvider.GetRequiredService<IWorkerRepository>().UpdateWorker(worker);

            Assert.Equal(id, result);
        }


    }
}
