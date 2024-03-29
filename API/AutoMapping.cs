using API.Models;
using API.Contracts.Responses.Users;
using API.Contracts.Responses.Bugs;
using API.Contracts.Requests.Users;
using API.Contracts.Requests.Bugs;

namespace API
{
    public class AutoMapping : AutoMapper.Profile
    {
        public AutoMapping()
        {
            // requests
            CreateMap<UserCreateRequest, User>();
            CreateMap<BugCreateRequest, Bug>();

            // responses
            CreateMap<User, UserResponse>().ReverseMap();
            CreateMap<User, UserDataResponse>();
            CreateMap<Bug, BugResponse>().ReverseMap();
            CreateMap<Bug, BugDataResponse>();
        }
    }
}
