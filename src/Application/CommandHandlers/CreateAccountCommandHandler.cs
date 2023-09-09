using Application.Abstractions;
using Application.Commands;
using Domain.Entities;
using MediatR;

namespace Application.CommandHandlers;

public class CreateAccountCommandHandler : IRequestHandler<CreateAccount, Account>
{
    private readonly IAccountRepository _accountRepository;

    public CreateAccountCommandHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Account> Handle(CreateAccount request, CancellationToken cancellationToken)
    {
      var account = new Account
      {
        FirstName = request.FirstName,
        LastName = request.LastName,
        IsBot = request.IsBot,
        TradingMethod = request.TradingMethod
      };
      
        return await _accountRepository.CreateAccountAsync(account);
    }
}