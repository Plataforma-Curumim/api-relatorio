using api_relatorio.Adapters.Inbound.HTTP.DTO.Requests;
using api_relatorio.Adapters.Inbound.HTTP.DTO.Responses;
using api_relatorio.Application.Domain.Dto.Command;
using api_relatorio.Application.Domain.DTO.Command;

namespace api_relatorio.Adapters.Inbound.HTTP.Mappers
{
    public static class MapRegisterUser
    {
        public static CommandRegisterUser ToCommand(RegisterUserResponse request)
        {
            return new CommandRegisterUser
            {
                //User = request.User,
                //Config = request.Config
            };
        }
        public static RegisterUserResponse ToResponse(CommandRegisterUser response)
        {
            return new RegisterUserResponse
            {
                DateRegister = response.DateRegister,
                UserId = response.UserId,
            };
        }
    }
}
