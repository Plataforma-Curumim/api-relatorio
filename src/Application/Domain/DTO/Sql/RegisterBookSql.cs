using api_relatorio.Application.Domain.Entities;

namespace api_relatorio.Application.Domain.DTO.Sql
{
    public record RegisterBookSql
    {
        public string BookId { get; set; }
        public string DateOfRegister { get; set; }
        public string UserId { get; set; }
        public Book Book { get; set; }
    }
}
