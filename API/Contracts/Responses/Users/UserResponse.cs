namespace API.Contracts.Responses.Users;

/// <summary>
/// User reponse
/// </summary>
public class UserResponse
{
    /// <summary>
    /// User Id
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// name
    /// </summary>
    public string? Name { get; set; }
    
    /// <summary>
    /// surname
    /// </summary>
    public string? Surname { get; set; }

}