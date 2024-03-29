using MediatR;
using MediatRExample.API.Repository;

namespace MediatRExample.API.MediatRPatern.Queries.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQueryRequest, List<GetAllQueryResponse>>
    {
        private readonly IProductRepository _productRepository;

        public GetAllQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<List<GetAllQueryResponse>> Handle(GetAllQueryRequest request, CancellationToken cancellationToken)
        {
            return _productRepository.GetAllAsync();
        }
    }
}
