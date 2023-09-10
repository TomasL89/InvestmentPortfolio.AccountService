using MediatR;

namespace Application.Account.Commands;

public record DeleteAccount(Guid Id) : IRequest;
