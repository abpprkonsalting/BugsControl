namespace API.Contracts.Responses.Projects;

/// <summary>
/// Project list response
/// </summary>
public class ProjectListResponse
{
    /// <summary>
    /// List of projects
    /// </summary>
    public List<ProjectDataResponse> Projects { get; set; } = new();
}