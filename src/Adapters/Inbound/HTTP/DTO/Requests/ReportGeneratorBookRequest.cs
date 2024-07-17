using api_relatorio.Application.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace api_relatorio.Adapters.Inbound.HTTP.DTO.Requests
{
    //RegisterBookRequest = ReportGeneratorBookRequest
    public record ReportGeneratorBookRequest
    {
        //[Required(ErrorMessage = "As informações do livro são obrigatórias")]
        //public Book? Book { get; set; }
        //public ConfigLibrary Config { get; set; }


        [Required(ErrorMessage = "As informações do livro são obrigatórias")]
        public ReportGeneratorBook? ReportGeneratorBook { get; set; }

        // fazer para selecionar so uma 

        // gerar relatorio de livros
        //selecionar por data//
        //selecionar por genero
        //selecionar por autor
        //


    }
}
