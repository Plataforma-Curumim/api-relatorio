using api_relatorio.Application.Domain.Entities;

namespace api_relatorio.Adapters.Inbound.HTTP.DTO.Responses
{
    // RegisterUserResponse = ReportGeneratorUserResponse
    public record ReportGeneratorUserResponse
    {
        public string? UserId { get; set; }
        public DateTime DateRegister { get; set; }
        public User? User{ get; set; }
    }
}
