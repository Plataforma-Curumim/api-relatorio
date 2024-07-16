using api_relatorio.Application.Domain.Entities;

namespace api_relatorio.Adapters.Inbound.HTTP.DTO.Responses
{
    public record RegisterUserResponse
    {
        public string? UserId { get; set; }
        public DateTime DateRegister { get; set; }
        public User? User{ get; set; }
    }
}
