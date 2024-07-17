using api_relatorio.Adapters.Inbound.HTTP.DTO.Requests;
using api_relatorio.Adapters.Inbound.HTTP.DTO.Responses;
using api_relatorio.Application.Domain.Dto.Command;
using api_relatorio.Application.Domain.DTO.Command;

namespace api_relatorio.Adapters.Inbound.HTTP.Mappers
{
    public static class MapReportGeneratorUser
    {
        public static CommandReportGeneratorUser ToCommand(ReportGeneratorUserResponse request)
        {
            return new CommandReportGeneratorUser
            {
                //User = request.User,
                //Config = request.Config
            };
        }
        public static ReportGeneratorUserResponse ToResponse(CommandReportGeneratorUser response)
        {
            return new ReportGeneratorUserResponse
            {
                DateRegister = response.DateRegister,
                UserId = response.UserId,
            };
        }
    }
}
