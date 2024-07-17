using api_relatorio.Application.Domain.Dto.Base;
using api_relatorio.Application.Domain.DTO.Command;
using api_relatorio.Application.Domain.Enums;
using api_relatorio.Application.Domain.Mappers;
using api_relatorio.Application.Ports.Inbound.UseCases;
using api_relatorio.Application.Ports.Outbound.DB.Repository;

namespace api_relatorio.Application.Core.UseCases
{
    public class UseCaseReportGeneratorBook : IUseCaseReportGeneratorBook
    {
        private readonly IReportGeneratorBookRepository? _repository;
        public UseCaseReportGeneratorBook(IServiceProvider provider)
        {
            _repository = provider.GetService<IReportGeneratorBookRepository>();
        }

        public async Task<BaseReturn<CommandRegisterBook>> Execute(CommandRegisterBook command)
        {
            try
            {
                var repositoryModel = MapBookRepository.ToRepository(command);
                var responseRepository = await _repository!.RegisterBook(repositoryModel);

                if (responseRepository.BookId == "")
                {
                    var error = new BaseError
                    {
                        code = "400",
                        message = "Erro ao cadastrar livro.",
                    };

                    return new BaseReturn<CommandRegisterBook>().Error(EnumState.BUSINESS, error);

                }

                var response = MapBookRepository.ToCommand(responseRepository);
                return new BaseReturn<CommandRegisterBook>().Success(response);

            } catch (Exception ex)
            {
                var error = new BaseError("500", ex.Message);
                return new BaseReturn<CommandRegisterBook>().Error(EnumState.SYSTEM, error);

            }

        }
    }
}
