﻿using api_relatorio.Application.Domain.DTO.Command;

namespace api_relatorio.Application.Ports.Inbound.UseCases
{
    public interface IUseCaseReportGeneratorBook
    {
        public Task<BaseReturn<CommandReportGeneratorBook>> Execute(CommandReportGeneratorBook command);
    }
}
