

using api_relatorio.Adapters.Inbound.HTTP.DTO.Requests;
using api_relatorio.Adapters.Inbound.HTTP.DTO.Responses;
using api_relatorio.Application.Domain.Dto.Command;

namespace api_relatorio.Adapters.Inbound.HTTP.Mappers
{
    public static class MapReportGeneratorUser
    {
        public static CommandReportGeneratorUser ToCommand(ReportGeneratorUserRequest request)
        {
            return new CommandReportGeneratorUser
            {
                User = request.User,
              
                //Config = request.Config
            };
        }
        public static ReportGeneratorUserResponse ToResponse(CommandReportGeneratorUser response)
        {
            return new ReportGeneratorUserResponse
            {
               User = response.User
              // DateRegister = response.DateRegister,
              //  UserId = response.UserId,
              //  UserId = response.UserId,
            };
        }
    }
}
