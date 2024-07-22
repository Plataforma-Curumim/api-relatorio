﻿using api_relatorio.Application.Domain.Dto.Base;
using api_relatorio.Application.Domain.Dto.Command;
using api_relatorio.Application.Domain.DTO.Command;
using api_relatorio.Application.Domain.Enums;
using api_relatorio.Application.Domain.Mappers;
using api_relatorio.Application.Ports.Inbound.UseCases;
using api_relatorio.Application.Ports.Outbound.DB.Repository;

namespace api_relatorio.Application.Core.UseCases
{
    public class UseCaseReportGeneratorUser : IUseCaseReportGeneratorUser
    {
        private readonly IReportGeneratorUserRepository ?_repository;

        public UseCaseReportGeneratorUser(IServiceProvider provider)
        {
            _repository = provider.GetService<IReportGeneratorUserRepository>();
        }
        public async Task<BaseReturn<CommandReportGeneratorUser>> Execute(CommandReportGeneratorUser command)
        {
            try
            {
                var repositoryModel = MapUserRepository.ToRepository(command);
                var responseRepository = await _repository!.ReportGeneratorUser(repositoryModel);

                if (responseRepository.UserId == "")
                {
                    var error = new BaseError
                    {
                        code = "400",
                        message = "Erro ao cadastrar usuario.",
                    };

                    return new BaseReturn<CommandReportGeneratorUser>().Error(EnumState.BUSINESS, error);
                }

                var response = MapUserRepository.ToCommand(responseRepository);

                return new BaseReturn<CommandReportGeneratorUser>().Success(response);

            }catch (Exception ex)
            {
                var error = new BaseError("500", ex.Message);
                return new BaseReturn<CommandReportGeneratorUser>().Error(EnumState.SYSTEM, error);
            }
        }
    }
}
