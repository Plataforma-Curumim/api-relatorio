using api_relatorio.Application.Domain.Dto.Base;

namespace api_relatorio.Adapters.Inbound.HTTP.Mappers
{
    public static class MapErrorEndpoint
    {
        public static IResult ToEndpointError(BaseError? error)
        {
            return error!.code == "500" ? Results.Json(error, statusCode: StatusCodes.Status500InternalServerError) : Results.BadRequest(error);
        }

    }
}
