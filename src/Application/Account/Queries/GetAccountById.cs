using MediatR;

namespace Application.Account.Queries;

public record GetAccountById(Guid Id) : IRequest<Domain.Entities.Account>;
