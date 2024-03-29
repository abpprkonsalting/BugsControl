namespace API.Contracts.Responses.Projects;

/// <summary>
/// Project reponse
/// </summary>
public class ProjectResponse
{
    /// <summary>
    /// Project Id
    /// </summary>
    public string Id { get; set; }
    
    /// <summary>
    /// name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// description
    /// </summary>
    public string? Description { get; set; }

}