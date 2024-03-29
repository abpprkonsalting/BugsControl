using API.Models;
using API.Contracts.Responses.Users;
using API.Contracts.Requests.Users;

namespace API
{
    public class AutoMapping : AutoMapper.Profile
    {
        public AutoMapping()
        {
            // requests
            CreateMap<UserCreateRequest, User>();

            // responses
            CreateMap<User, UserResponse>().ReverseMap();
            CreateMap<User, UserDataResponse>();
        }
    }
}
