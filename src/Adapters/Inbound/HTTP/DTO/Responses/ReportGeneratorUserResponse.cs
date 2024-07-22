using api_relatorio.Application.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace api_relatorio.Adapters.Inbound.HTTP.DTO.Responses
{
    // RegisterUserResponse = ReportGeneratorUserResponse
    public record ReportGeneratorUserResponse
    {
        //public string? UserId { get; set; }
       // public DateTime DateRegister { get; set; }
       // [Required(ErrorMessage = "As informações do usuario são obrigatórias")]
        public User? User{ get; set; }
    }
}
