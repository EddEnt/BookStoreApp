using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models;

namespace BookStoreApp.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // CreateMap<Source, Destination>().TwoWayMapping
            //A Map is a function that takes a source object and returns a destination object.
            CreateMap<ModelsAuthor, Author>().ReverseMap();
            
        }
    }
}
