using api_relatorio.Adapters.Outbound.DB.Postgres.Connection;
using api_relatorio.Adapters.Outbound.DB.Postgres.Repository;
using api_relatorio.Application.Ports.Outbound.DB.Connection;
using api_relatorio.Application.Ports.Outbound.DB.Repository;

namespace api_relatorio.Infra.DependencyInjection
{
    public static class RespositoryExtensions
    {
        public static void AddRepositoryExtension(this IServiceCollection service)
        {
            service.AddSingleton<IDBConnection, PostgresConnection>();
            service.AddScoped<IRegisterUserRepository, RegisterUserRepository>();
            service.AddScoped<IRegisterBookRepository, RegisterBookRepository>();   
        }
    }
}
