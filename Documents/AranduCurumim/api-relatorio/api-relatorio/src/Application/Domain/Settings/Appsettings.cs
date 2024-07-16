namespace api_relatorio.Application.Domain.Settings
{   
    public record Appsettings
    {
        public DatabaseSettings Database { get; set; }


        public Appsettings()
        {
            
        }
    }
}
