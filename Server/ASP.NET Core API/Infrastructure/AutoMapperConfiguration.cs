using ASP.NET_Core_API.RequestModelsDTO;
using AutoMapper;
using Iss.AvanMagazinOnline.DB.Models;

//private readonly Mapper _mapper = new(new MapperConfiguration(cfg => cfg.CreateMap<ProducatorDTO, Producator>()));
namespace ASP.NET_Core_API.Infrastructure
{
    public class AutoMapperConfiguration:Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<ProducatorDTO, Producator>();
            CreateMap<CategorieProdusDTO, CategorieProdus>();
            CreateMap<ProdusDTO, Produs>();
            CreateMap<CumparatorDTO, Cumparator>();
            CreateMap<ProdusStocDTO, ProdusStoc>();
            CreateMap<ComandaDTO, Comanda>();
        }
    }
}
