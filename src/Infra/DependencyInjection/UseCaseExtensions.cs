using api_relatorio.Application.Core.UseCases;
using api_relatorio.Application.Ports.Inbound.UseCases;

namespace api_relatorio.Infra.DependencyInjection
{
    public static class UseCaseExtensions
    {
        public static void AddUseCaseExtensions(this IServiceCollection services)
        {
            services.AddScoped<IUseCaseReportGeneratorUser, UseCaseReportGeneratorUser>();
            services.AddScoped<IUseCaseReportGeneratorBook, UseCaseReportGeneratorBook>();
        }
    }
}
