using API.Contracts.Responses.Users;

namespace API.Contracts.Views.Users;

/// <summary>
/// User data response view
/// </summary>
public class UserDataResponseView : BaseResponseView
{
    /// <summary>
    /// user data response
    /// </summary>
    public UserDataResponse Data { get; set; } = new();
}