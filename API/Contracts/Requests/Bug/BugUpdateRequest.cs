namespace API.Contracts.Requests.Bugs;

/// <summary>
/// Bug update request
/// </summary>
public class BugUpdateRequest
{
    /// <summary>
    /// Bug Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Bug creation date
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// User Id
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Project Id
    /// </summary>
    public string ProjectId { get; set; }

}