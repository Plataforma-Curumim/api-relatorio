using api_relatorio.Application.Domain.DTO.Command;
using api_relatorio.Application.Domain.DTO.Sql;

namespace api_relatorio.Application.Domain.Mappers
{
    public static class MapBookRepository
    {
        public static RegisterBookSql ToRepository(CommandRegisterBook command)
        {
            return new RegisterBookSql
            {
                UserId = command.UserId,
                Book = command.Book!

                //inserir
            };
        }
        public static CommandRegisterBook ToCommand(RegisterBookSql model)
        {
            return new CommandRegisterBook
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
