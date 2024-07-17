using api_relatorio.Adapters.Inbound.HTTP.DTO.Responses;
using api_relatorio.Application.Domain.DTO.Command;

namespace api_relatorio.Adapters.Inbound.HTTP.Mappers
{
    //  MapRegisterBook =  MapReporteGeneratorBook
    public static class MapReportGeneratorBook
    {
      //  CommandRegisterBook =  CommandReportGeneratorBook
        public static CommandReportGeneratorBook ToCommand(ReportGeneratorBookResponse request)
        {
            return new CommandReportGeneratorBook
            {
                Book = request.Book,
                //config = request.Config,
                BookId = request.BookId

                //chama
            };
        }

        public static ReportGeneratorBookResponse ToResponse(CommandReportGeneratorBook response)
        {
            return new ReportGeneratorBookResponse
            {
                BookId = response.BookId,
                DateRegister = response.DateRegister,
                Book = response.Book

                //volta
            };
        }
    }
}
