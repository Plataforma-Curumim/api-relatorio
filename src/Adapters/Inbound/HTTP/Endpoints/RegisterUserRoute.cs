using api_relatorio.Application.Ports.Inbound.UseCases;
using api_relatorio.Adapters.Inbound.HTTP.DTO.Requests;
using api_relatorio.Adapters.Inbound.HTTP.DTO.Responses;
using api_relatorio.Application.Domain.Dto.Base;
using api_relatorio.Adapters.Inbound.HTTP.Mappers;
using api_relatorio.Application.Domain.Enums;

namespace api_relatorio.Adapters.Inbound.HTTP.Routes
{
    public static class RegisterUserRoute
    {
        public static void AddRegisterUser(this WebApplication app)
        {
            app.MapPost("/registerUser", RegisterUser)
                .Accepts<RegisterUserRequest>("application/json")
                .Produces<RegisterUserResponse>(201)
                .Produces<BaseError>(400)
                .Produces<BaseError>(422)
                .Produces<BaseError>(500);


        }
        private static async Task<IResult> RegisterUser(IUseCaseRegisterUser useCase, HttpContext context, RegisterUserRequest request)
        {
            try
            {

                var response = await useCase.Execute(MapRegisterUser.ToCommand(request));

                if (response.State != EnumState.SUCCESS) return MapErrorEndpoint.ToEndpointError(response.ErrorObject);

                var responseMap = MapRegisterUser.ToResponse(response.SucessObject!);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.BadRequest(ex);
            }
        }
    }
}
