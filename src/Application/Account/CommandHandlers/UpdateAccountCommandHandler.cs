using Application.Abstractions;
using Application.Account.Commands;
using MediatR;

namespace Application.Account.CommandHandlers;

public class UpdateAccountCommandHandler : IRequestHandler<UpdateAccount, Domain.Entities.Account>
{
    private readonly IAccountRepository _accountRepository;

    public UpdateAccountCommandHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Domain.Entities.Account> Handle(UpdateAccount request, CancellationToken cancellationToken)
    {
        return await _accountRepository.UpdateAccountAsync(
            request.Id, 
            request.FirstName, 
            request.LastName, 
            request.IsBot, 
            request.TradingMethod);
    }
}