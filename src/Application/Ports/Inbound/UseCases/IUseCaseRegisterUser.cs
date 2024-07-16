using api_relatorio.Application.Domain.Dto.Command;
    
namespace api_relatorio.Application.Ports.Inbound.UseCases
{
    public interface IUseCaseRegisterUser
    {
        public Task<BaseReturn<CommandRegisterUser>> Execute(CommandRegisterUser command);
    }
}
