namespace api_relatorio.Application.Domain.Entities
{
    public class ReportGeneratorBook
    {
        public string DataInicial { get; set; } //ver como fazer para selecioanr dois periodos
        public string DataFinal { get; set; }
        public int QuantidadeLivroBiblioteca { get; set; }
        public int QuantidadeLivroEmprestado { get; set; }
        public int QuantidadeLivroDisponivel { get; set; }

    }
}
