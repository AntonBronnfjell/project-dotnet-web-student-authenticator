using AuthenticationSystem.Entities;
using AuthenticationSystem.Models;
using AutoMapper;

namespace AuthenticationSystem.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterViewModel, ApplicationUser>();
    }
}