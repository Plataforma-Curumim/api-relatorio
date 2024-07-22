using api_relatorio.Application.Ports.Inbound.UseCases;
using api_relatorio.Adapters.Inbound.HTTP.DTO.Requests;
using api_relatorio.Adapters.Inbound.HTTP.DTO.Responses;
using api_relatorio.Application.Domain.Dto.Base;
using api_relatorio.Adapters.Inbound.HTTP.Mappers;
using api_relatorio.Application.Domain.Enums;

namespace api_relatorio.Adapters.Inbound.HTTP.Routes
{
    // RegisterUserRoute =  ReportGeneratorUserRoute
    public static class ReportGeneratorUserRoute
    {
        public static void AddReportGeneratorUser(this WebApplication app)
        {
            app.MapPost("/ReportGeneratorUser", ReportGeneratorUser)
                .Accepts<ReportGeneratorUserRequest>("application/json")
                .Produces<ReportGeneratorUserResponse>(201)
                .Produces<BaseError>(400)
                .Produces<BaseError>(422)
                .Produces<BaseError>(500);


        }
        private static async Task<IResult> ReportGeneratorUser(IUseCaseReportGeneratorUser useCase, HttpContext context, ReportGeneratorUserRequest request)
        {
            try
            {

                var response = await useCase.Execute(MapReportGeneratorUser.ToCommand(request));

                if (response.State != EnumState.SUCCESS) return MapErrorEndpoint.ToEndpointError(response.ErrorObject);

                var responseMap = MapReportGeneratorUser.ToResponse(response.SucessObject!);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }
    }
}
