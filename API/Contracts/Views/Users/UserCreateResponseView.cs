namespace API.Contracts.Views.Users
{
    /// <summary>
    /// User create response view
    /// </summary>
    public class UserCreateResponseView : BaseResponseView
    {
        /// <summary>
        /// newly created User Id
        /// </summary>
        public string Id { get; set; }
    }
}
