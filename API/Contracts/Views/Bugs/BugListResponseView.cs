using API.Contracts.Responses.Bugs;

namespace API.Contracts.Views.Bugs;

/// <summary>
/// Bug list response view
/// </summary>
public class BugListResponseView : BaseResponseView
{
    /// <summary>
    /// List of users
    /// </summary>
    public List<BugDataResponse> Data { get; set; } = new();
}