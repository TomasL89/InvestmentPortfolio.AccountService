using MediatR;

namespace Application.Account.Queries;

public class GetAllAccounts : IRequest<List<Domain.Entities.Account>>
{
    
}