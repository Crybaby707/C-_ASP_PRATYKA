using AutoMapper;
using System.Linq;
using TVShow.Domain;
using TVShow.Web.Dto;

namespace TVShow.Web.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(p => p.Roles, opt => opt.MapFrom(r => r.UserRoles.Select(ur => ur.Role.Code)));
        }
    }
}
