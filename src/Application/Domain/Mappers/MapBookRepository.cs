using api_relatorio.Application.Domain.DTO.Command;
using api_relatorio.Application.Domain.DTO.Sql;

namespace api_relatorio.Application.Domain.Mappers
{
    public static class MapBookRepository
    {
        public static ReportGeneratorBookSql ToRepository(CommandReportGeneratorBook command)
        {
            return new ReportGeneratorBookSql
            {
              //  UserId = command.UserId,
                Book = command.Book!

                //inserir
            };
        }
        public static CommandReportGeneratorBook ToCommand(ReportGeneratorBookSql model)
        {
            return new CommandReportGeneratorBook
            {
                Book = model.Book
                //UserId = model.UserId,
                //BookId = model.BookId,
              // DateRegister = DateTime.Parse(model.DateOfRegister)

                //retornar
            };
        }
    }
}
