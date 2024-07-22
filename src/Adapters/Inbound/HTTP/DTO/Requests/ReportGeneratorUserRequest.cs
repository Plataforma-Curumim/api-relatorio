using api_relatorio.Application.Domain.Entities;

namespace api_relatorio.Adapters.Inbound.HTTP.DTO.Requests
{
    //RegisterUserRequest= ReportGeneratorUserRequest
    public record ReportGeneratorUserRequest
    {
        //[Required(ErrorMessage = "As informações do usuario são obrigatórias")]
        //public User? User { get; set; }
        //public ConfigLibrary Config { get; set; }
        public User? User { get; set; }

    }
}
