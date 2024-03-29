using MediatRExample.API.MediatRPatern.Queries.GetAll;

namespace MediatRExample.API.Repository
{
    public interface IProductRepository
    {
        Task<List<GetAllQueryResponse>> GetAllAsync();
    }
}
