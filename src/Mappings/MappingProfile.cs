using AutoMapper;
using thegame.MapConstructor;
using thegame.MapPrimitives;
using thegame.Models;

namespace thegame.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Vector, VectorDto>();
            CreateMap<VectorDto, Vector>();
            
            CreateMap<Cell, CellDto>()
                .ForMember(x=>x.Pos, 
                    opt => opt.MapFrom(c=> new VectorDto(c.Pos.X,c.Pos.Y)));
            CreateMap<CellDto, Cell>()
                .ForMember(x=>x.Pos, 
                    opt => opt.MapFrom(c=> new Vector(c.Pos.X,c.Pos.Y))); ;
        }
    }
}