using AutoMapper;
using System.Linq;
using TVShows.Domain;
using TVShows.Web.Dto;

namespace TVShows.Web.Profiles
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
