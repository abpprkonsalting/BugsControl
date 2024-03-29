using API.Contracts.Responses.Bugs;
namespace API.Contracts.Responses.Projects;

/// <summary>
/// Project Data Response
/// </summary>
public class ProjectDataResponse : ProjectResponse
{
    /// <summary>
    /// List of bugs of this project
    /// </summary>
    public List<BugResponse> Bugs { get; set; } = new();
}