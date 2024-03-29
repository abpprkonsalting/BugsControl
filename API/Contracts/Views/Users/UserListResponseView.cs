using API.Contracts.Responses;
using API.Contracts.Responses.Users;

namespace API.Contracts.Views.Users;

/// <summary>
/// User list response view
/// </summary>
public class UserListResponseView : BaseResponseView
{
    /// <summary>
    /// List of users
    /// </summary>
    public List<UserDataResponse> Data { get; set; } = new();
}