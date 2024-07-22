using api_relatorio.Adapters.Inbound.HTTP.Routes;

namespace api_relatorio.Infra.DependencyInjection
{
    public static class EndpointExtensions
    {
        public static void UseEndpointExtentions(this WebApplication app)
        {
            app.AddReportGeneratorUser();
            app.AddReportGeneratorBook();
        }
    }
}
