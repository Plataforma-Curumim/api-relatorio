using api_relatorio.Adapters.Inbound.HTTP.DTO.Responses;
using api_relatorio.Application.Domain.DTO.Command;

namespace api_relatorio.Adapters.Inbound.HTTP.Mappers
{
    public static class MapRegisterBook
    {
        public static CommandRegisterBook ToCommand(RegisterBookResponse request)
        {
            return new CommandRegisterBook
            {
                //Book = request.Book,
                //config = request.Config,
                //BookId = request.BookId

                //chama
            };
        }

        public static RegisterBookResponse ToResponse(CommandRegisterBook response)
        {
            return new RegisterBookResponse
            {
                BookId = response.BookId,
                DateRegister = response.DateRegister,
                Book = response.Book

                //volta
            };
        }
    }
}
