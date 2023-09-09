using Application.Abstractions;
using Application.Commands;
using Domain.Entities;
using MediatR;

namespace Application.CommandHandlers;

public class UpdateAccountCommandHandler : IRequestHandler<UpdateAccount, Account>
{
    private readonly IAccountRepository _accountRepository;

    public UpdateAccountCommandHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Account> Handle(UpdateAccount request, CancellationToken cancellationToken)
    {
        return await _accountRepository.UpdateAccountAsync(
            request.Id, 
            request.FirstName, 
            request.LastName, 
            request.AccountBalance,
            request.FeesPaid,
            request.TaxesPaid,
            request.IsBot, 
            request.TradingMethod);
    }
}