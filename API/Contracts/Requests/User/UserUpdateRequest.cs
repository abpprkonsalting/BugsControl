namespace API.Contracts.Requests.Users;

/// <summary>
/// User update request
/// </summary>
public class UserUpdateRequest
{
    /// <summary>
    /// User Id
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    /// name
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Surname
    /// </summary>
    public string Surname { get; set; }

    
}