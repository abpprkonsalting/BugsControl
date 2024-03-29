namespace API.Contracts.Requests.Users
{
    /// <summary>
    /// User create request
    /// </summary>
    public class UserCreateRequest
    {
        /// <summary>
        /// User Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User Surname
        /// </summary>
        public string Surname { get; set; }

    }
}
