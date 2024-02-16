using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Tests.Integration.Configurations
{
    public class IntegrationFixture : IDisposable
    {
        public HttpClient httpClient { get; }
        public DbContext DbContext { get; }
        public IServiceProvider serviceProvider { get; }
        private readonly IServiceScope _scope;

        public IntegrationFixture()
        {
            var api = new WebApiApplicationFactory();
            httpClient = api.CreateClient();
            _scope = api.Services.CreateScope();
            serviceProvider = _scope.ServiceProvider;
            DbContext = serviceProvider.GetRequiredService<DatabaseContext>();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _scope?.Dispose();
            httpClient.Dispose();
            DbContext?.Dispose();
        }
    }
}
