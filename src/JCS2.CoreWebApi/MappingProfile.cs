using AutoMapper;
using JCS2.CoreWebApi.Dtos;
using JCS2.CoreWebApi.Entities;

namespace JCS2.CoreWebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            ApplyMappings();
        }

        private void ApplyMappings()
        {
            CreateMap<User, UserDto>();
            CreateMap<User, UserBasicDto>();
            CreateMap<CreateUserDto, User>();
        }
    }
}
