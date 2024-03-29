using MediatR;

namespace MediatRExample.API.MediatRPatern.Queries.GetAll
{
    public class GetAllQueryRequest:IRequest<List<GetAllQueryResponse>>
    {
    }
}
