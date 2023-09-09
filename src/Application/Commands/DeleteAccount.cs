using Domain.Entities;
using MediatR;

namespace Application.Commands;

public record DeleteAccount(Guid Id) : IRequest;
