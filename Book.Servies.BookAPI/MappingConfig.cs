using AutoMapper;
using Book.Servies.BookAPI.Models;
using Book.Servies.BookAPI.Models.Dto;

namespace Book.Services.BookAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<BookDto, BookModel>();
                config.CreateMap<BookModel, BookDto>();
            });
            return mappingConfig;
        }
    }
}
