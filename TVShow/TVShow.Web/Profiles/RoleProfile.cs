using AutoMapper;
using TVShow.Domain;
using TVShow.Web.Dto;

namespace TVShow.Web.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>();
        }
    }
}
