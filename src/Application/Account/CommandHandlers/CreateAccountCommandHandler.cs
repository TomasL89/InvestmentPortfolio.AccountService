using Application.Abstractions;
using Application.Account.Commands;
using MediatR;

namespace Application.Account.CommandHandlers;

public class CreateAccountCommandHandler : IRequestHandler<CreateAccount, Domain.Entities.Account>
{
    private readonly IAccountRepository _accountRepository;

    public CreateAccountCommandHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Domain.Entities.Account> Handle(CreateAccount request, CancellationToken cancellationToken)
    {
      var account = new Domain.Entities.Account
      {
        FirstName = request.FirstName,
        LastName = request.LastName,
        IsBot = request.IsBot,
        TradingMethod = request.TradingMethod
      };
      
        return await _accountRepository.CreateAccountAsync(account);
    }
}