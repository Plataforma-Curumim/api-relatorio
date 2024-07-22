using api_relatorio.Application.Domain.Dto.Command;
    
namespace api_relatorio.Application.Ports.Inbound.UseCases
{
    public interface IUseCaseReportGeneratorUser
    {
        public Task<BaseReturn<CommandReportGeneratorUser>> Execute(CommandReportGeneratorUser command);
    }
}
