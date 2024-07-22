using api_relatorio.Application.Domain.DTO.Sql;
using api_relatorio.Application.Ports.Outbound.DB.Connection;
using api_relatorio.Application.Ports.Outbound.DB.Repository;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace api_relatorio.Adapters.Outbound.DB.Postgres.Repository
{
    // RegisterBookRepository = ReportGeneratorBookRepository
    public class ReportGeneratorBookRepository : IReportGeneratorBookRepository
    {
        private readonly IDBConnection _dbConnection;
        private readonly NpgsqlConnection _connection;

        public ReportGeneratorBookRepository(IServiceProvider provider)
        {
            _dbConnection = provider.GetRequiredService<IDBConnection>();
            _connection = _dbConnection.GetConnection();
        }

        public async Task<ReportGeneratorBookSql> ReportGeneratorBook(ReportGeneratorBookSql msgIn)
        {
            using (NpgsqlTransaction transaction = _connection.BeginTransaction())
            {
                NpgsqlCommand cmd = new NpgsqlCommand("sps_ReportGeneratorBook", _connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchUserId", msgIn.UserId!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchBookId", msgIn.Book!.BookId!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchIsbn", msgIn.Book!.Isbn!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchTitle", msgIn.Book!.Title!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchAuthor", msgIn.Book!.Author!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchPublishers", msgIn.Book!.Publishers!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("psmlPublishDate", msgIn.Book!.PublishDate!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchSinopse", msgIn.Book!.Sinopse!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchGender", msgIn.Book!.Gender!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchLanguage", msgIn.Book!.Language!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchUrlImage", msgIn.Book!.UrlImage!));
                //cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchRfidId", msgIn.Book!.RfidId!));


                //Adicionando datas
                cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchQuantBookGeral", msgIn.Book!.QuantidadeLivroBiblioteca!));
                cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchQuantBookEmpres", msgIn.Book!.QuantidadeLivroEmprestado!));
                cmd.Parameters.AddWithValue(new NpgsqlParameter("pvchQuantBookDisp", msgIn.Book!.QuantidadeLivroDisponivel!));

             //   NpgsqlParameter pvchBookId = new NpgsqlParameter("pvchBookId", NpgsqlDbType.Varchar, 1000, "", ParameterDirection.Output, false, new byte(), new byte(), new DataRowVersion(), msgIn.Book!.BookId!);
                NpgsqlParameter pdatDateOfRegister = new NpgsqlParameter("pdatDateOfRegister", NpgsqlDbType.Date, 1000, "", ParameterDirection.Output, false, new byte(), new byte(), new DataRowVersion(), msgIn.DateOfRegister!);

                //cmd.Parameters.AddWithValue(pvchBookId);
                cmd.Parameters.AddWithValue(pdatDateOfRegister);
                cmd.Prepare();

                var response = cmd.ExecuteReader();
                transaction.Commit();

            //    msgIn.BookId = cmd.Parameters.FirstOrDefault(pvchBookId).Value.ToString() ?? "";
                msgIn.DateOfRegister = cmd.Parameters.FirstOrDefault(pdatDateOfRegister).Value.ToString() ?? "";
                return msgIn;
            }
        }
    }
}
