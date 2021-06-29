using AutoMapper;
using thegame.MapConstructor;
using thegame.Models;

namespace thegame.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Vector, VectorDto>();
            CreateMap<VectorDto, Vector>();
            CreateMap<Cell, CellDto>();
            CreateMap<CellDto, Cell>();
        }
    }
}