namespace API.Contracts.Views.Bugs
{
    /// <summary>
    /// Bug create response view
    /// </summary>
    public class BugCreateResponseView : BaseResponseView
    {
        /// <summary>
        /// newly created Bug Id
        /// </summary>
        public string Id { get; set; }
    }
}
