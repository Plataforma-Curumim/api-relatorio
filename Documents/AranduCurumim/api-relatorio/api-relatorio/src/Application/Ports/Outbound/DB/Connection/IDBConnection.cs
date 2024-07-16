using api_relatorio.Application.Domain.Dto.Base;
using Npgsql;

namespace api_relatorio.Application.Ports.Outbound.DB.Connection
{
    public interface IDBConnection
    {
        public NpgsqlConnection GetConnection();
    }
}
