using api_relatorio.Application.Domain.Entities;

namespace api_relatorio.Adapters.Inbound.HTTP.DTO.Responses
{
   // RegisterBookResponse = ReportGeneratorBookResponse
    public record ReportGeneratorBookResponse
    {
        // aqui sao as mesmas informaçoes do cadastro de livro ja que 
        //public string? BookId { get; set; }
        //public DateTime DateRegister { get; set; }
        public Book? Book { get; set; }
    }
}
