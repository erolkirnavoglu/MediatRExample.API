using AutoMapper;
using MediatRExample.API.MediatRPatern.Queries.GetAll;
using Microsoft.EntityFrameworkCore;

namespace MediatRExample.API.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _contex;
        private readonly IMapper _mapper;

        public ProductRepository(AppDbContext contex, IMapper mapper)
        {
            _contex = contex;
            _mapper = mapper;
        }

        public async Task<List<GetAllQueryResponse>> GetAllAsync()
        {
            using (var ctx = _contex)
            {
                var datalist = await ctx.Products.ToListAsync();
                var dx = _mapper.Map<List<GetAllQueryResponse>>(datalist);
                return dx;

            }
        }
    }
}
