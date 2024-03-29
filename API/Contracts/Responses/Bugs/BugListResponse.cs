namespace API.Contracts.Responses.Bugs;

/// <summary>
/// Bug list response
/// </summary>
public class BugListResponse
{
    /// <summary>
    /// List of bugs
    /// </summary>
    public List<BugDataResponse> Bugs { get; set; } = new List<BugDataResponse>();
}