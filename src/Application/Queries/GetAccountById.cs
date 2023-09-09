using Domain.Entities;
using MediatR;

namespace Application.Queries;

public record GetAccountById(Guid Id) : IRequest<Account>;
