using api_relatorio.Application.Domain.DTO.Command;
using api_relatorio.Application.Domain.DTO.Sql;

namespace api_relatorio.Application.Domain.Mappers
{
    public static class MapBookRepository
    {
        public static RegisterBookSql ToRepository(CommandReportGeneratorBook command)
        {
            return new RegisterBookSql
            {
                UserId = command.UserId,
                Book = command.Book!

                //inserir
            };
        }
        public static CommandReportGeneratorBook ToCommand(RegisterBookSql model)
        {
            return new CommandReportGeneratorBook
            {
                //Book = model.Book,
                //UserId = model.UserId,
                //BookId = model.BookId,
                DateRegister = DateTime.Parse(model.DateOfRegister)

                //retornar
            };
        }
    }
}
