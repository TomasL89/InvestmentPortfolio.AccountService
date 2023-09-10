using Application.Abstractions;
using Application.Account.Queries;
using MediatR;

namespace Application.Account.QueryHandlers;

public class GetAccountByIdQueryHandler : IRequestHandler<GetAccountById, Domain.Entities.Account?>
{
    private readonly IAccountRepository _accountRepository;

    public GetAccountByIdQueryHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Domain.Entities.Account?> Handle(GetAccountById request, CancellationToken cancellationToken)
    {
        return await _accountRepository.GetAccountByIdAsync(request.Id);
    }   
}