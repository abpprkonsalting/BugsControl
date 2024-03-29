namespace API.Contracts.Responses.Users;

/// <summary>
/// User list response
/// </summary>
public class UserListResponse
{
    /// <summary>
    /// List of users
    /// </summary>
    public List<UserDataResponse> Users { get; set; } = new();
}