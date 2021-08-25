using AutoMapper;
using CapstoneBackend.DataTransferObjects;
using CapstoneBackend.Models;

namespace CapstoneBackend.Managers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
