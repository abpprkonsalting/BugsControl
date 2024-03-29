using API.Contracts.Responses.Projects;

namespace API.Contracts.Responses.Bugs;

/// <summary>
/// Bug Data Response
/// </summary>
public class BugDataResponse : BugResponse
{
    /// <summary>
    /// user of this bug
    /// </summary>
    //public UserResponse User { get; set; }

    /// <summary>
    /// project of this bug
    /// </summary>
    public ProjectResponse Project { get; set; }
}