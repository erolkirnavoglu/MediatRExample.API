using AutoMapper;
using MediatRExample.API.Entity;
using MediatRExample.API.MediatRPatern.Queries.GetAll;

namespace MediatRExample.API.Map
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, GetAllQueryResponse>().ReverseMap();
        }
    }
}
