using api_relatorio.Application.Domain.Dto.Command;
using api_relatorio.Application.Domain.DTO.Sql;

namespace api_relatorio.Application.Domain.Mappers
{
    public static class MapUserRepository
    {
        public static RegisterUserSql ToRepository(CommandReportGeneratorUser command)
        {
            return new RegisterUserSql
            {
                User = command.User!
            };
        }
        public static CommandReportGeneratorUser ToCommand(RegisterUserSql model)
        {
            return new CommandReportGeneratorUser
            {
                User = model.User,
                UserId = model.UserId,
                DateRegister = DateTime.Parse(model.DateOfRegister)
            };
        }
    }
}
