﻿using api_relatorio.Application.Domain.DTO.Sql;

namespace api_relatorio.Application.Ports.Outbound.DB.Repository
{
    public interface IReportGeneratorBookRepository
    {
        public Task<ReportGeneratorBookSql> ReportGeneratorBook(ReportGeneratorBookSql msgIn);
    }
}
