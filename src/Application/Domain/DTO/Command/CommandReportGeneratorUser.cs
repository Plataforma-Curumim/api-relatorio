using api_relatorio.Application.Domain.Enums;
using api_relatorio.Application.Domain.Entities;

namespace api_relatorio.Application.Domain.Dto.Command
{
    public record CommandReportGeneratorUser
    {
        public User? User { get; set; }
        //public string? UserId { get; set; }
       // public DateTime DateRegister { get; set; }
        //public ConfigLibrary Config { get; set; }

    }
}
