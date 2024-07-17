using api_relatorio.Adapters.Inbound.HTTP.DTO.Requests;
using api_relatorio.Adapters.Inbound.HTTP.DTO.Responses;
using api_relatorio.Adapters.Inbound.HTTP.Mappers;
using api_relatorio.Application.Domain.Dto.Base;
using api_relatorio.Application.Domain.Enums;
using api_relatorio.Application.Ports.Inbound.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace api_relatorio.Adapters.Inbound.HTTP.Routes
{
    // RegisterBookRoute = ReportGeneratorBookRoute
    public static class ReportGeneratorBookRoute
    {
        public static void AddReportGeneratorBook(this WebApplication app)
        {
            app.MapPost("/registerBook", RegisterBook)
                .Accepts<ReportGeneratorBookRequest>("application/json")// comando para gearr relatorio
                .Produces<ReportGeneratorBookResponse>(201) // envia a mensagem do relatorio
                .Produces<BaseError>(400)
                .Produces<BaseError>(422)
                .Produces<BaseError>(500);


        }
        private static async Task<IResult> RegisterBook([FromServices]IUseCaseReportGeneratorBook useCase,
                                                        [FromBody] ReportGeneratorBookRequest request,
                                                        HttpContext context)
        {
            try
            {
                var response = await useCase.Execute(CommandReporteGeneratorBook.ToCommand(request));

                if (response.State != EnumState.SUCCESS) return MapErrorEndpoint.ToEndpointError(response.ErrorObject);

                var responseMap = CommandReporteGeneratorBook.ToResponse(response.SucessObject!);
                return Results.Ok(response);
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }
    }
}
