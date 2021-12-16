using AutoMapper;
using TVShows.Domain;
using TVShows.Web.Dto;

namespace TVShows.Web.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>();
        }
    }
}
