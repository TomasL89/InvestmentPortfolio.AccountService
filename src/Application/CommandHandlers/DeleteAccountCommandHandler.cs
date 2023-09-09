using Application.Abstractions;
using Application.Commands;
using MediatR;

namespace Application.CommandHandlers;

public class DeleteAccountCommandHandler : IRequestHandler<DeleteAccount>
{
    private readonly IAccountRepository _accountRepository;

    public DeleteAccountCommandHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task Handle(DeleteAccount request, CancellationToken cancellationToken)
    {
        await _accountRepository.DeleteAccountAsync(request.Id);
    }
}