using Application.Abstractions;
using Application.Queries;
using Domain.Entities;
using MediatR;

namespace Application.QueryHandlers;

public class GetAccountByIdQueryHandler : IRequestHandler<GetAccountById, Account?>
{
    private readonly IAccountRepository _accountRepository;

    public GetAccountByIdQueryHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Account?> Handle(GetAccountById request, CancellationToken cancellationToken)
    {
        return await _accountRepository.GetAccountByIdAsync(request.Id);
    }   
}