using System.ComponentModel.DataAnnotations;

namespace API.Contracts.Requests.Bugs
{
    /// <summary>
    /// Bug create request
    /// </summary>
    public class BugCreateRequest
    {
        /// <summary>
        /// Bug Description
        /// </summary>
        [MaxLength(100)]
        public string Description { get; set; }

        /// <summary>
        /// User Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Project Id
        /// </summary>
        public string ProjectId { get; set; }

    }
}
