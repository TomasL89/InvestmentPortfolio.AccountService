using Application.Abstractions;
using Application.Account.Queries;
using MediatR;

namespace Application.Account.QueryHandlers;

public class GetAllAccountsQueryHandler : IRequestHandler<GetAllAccounts, List<Domain.Entities.Account>>
{
    private readonly IAccountRepository _accountRepository;

    public GetAllAccountsQueryHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<List<Domain.Entities.Account>> Handle(GetAllAccounts request, CancellationToken cancellationToken)
    {
        return await _accountRepository.GetAllAccountsAsync();
    }
}