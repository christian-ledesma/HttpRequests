using AutoMapper;
using WebApplication1.DTO;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<MangaDto, Manga>();
                config.CreateMap<Manga, MangaDto>();
            });
            return mappingConfig;
        }
    }
}
