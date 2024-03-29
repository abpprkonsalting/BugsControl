namespace API.Contracts.Responses.Bugs;

/// <summary>
/// Bug reponse
/// </summary>
public class BugResponse
{
    /// <summary>
    /// Bug Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    // <summary>
    // Bug creation date
    // </summary>
    public DateTime CreationDate { get; set; }

    public string UserName { get; set; }

}