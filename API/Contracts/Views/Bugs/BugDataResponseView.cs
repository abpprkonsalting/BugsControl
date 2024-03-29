using API.Contracts.Responses.Bugs;

namespace API.Contracts.Views.Bugs;

/// <summary>
/// Bug data response view
/// </summary>
public class BugDataResponseView : BaseResponseView
{
    /// <summary>
    /// user data response
    /// </summary>
    public BugDataResponse Data { get; set; } = new();
}