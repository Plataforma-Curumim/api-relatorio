using api_relatorio.Application.Domain.Dto.Command;
using api_relatorio.Application.Domain.DTO.Sql;

namespace api_relatorio.Application.Domain.Mappers
{
    public static class MapUserRepository
    {
        public static ReportGeneratorUserSql ToRepository(CommandReportGeneratorUser command)
        {
            return new ReportGeneratorUserSql
            {
                User = command.User!
            };
        }
        public static CommandReportGeneratorUser ToCommand(ReportGeneratorUserSql model)
        {
            return new CommandReportGeneratorUser
            {
                User = model.User,
               // UserId = model.UserId,
                //DateRegister = DateTime.Parse(model.DateOfRegister)
            };
        }
    }
}
