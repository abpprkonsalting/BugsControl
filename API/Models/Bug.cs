using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace API.Models
{
    /// <summary>
    /// Bug Class
    /// </summary>
    public class Bug
    {
        /// <summary>
        /// Bug Id
        /// </summary>
        [Key]
        [JsonPropertyName("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Bug Description
        /// </summary>
        [MaxLength(100)]
        [JsonPropertyName("description")]
        public string Description { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Bug creation date
        /// </summary>
        [JsonPropertyName("creationDate")]
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// FK relation Id to User
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// user of this bug
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// FK relation Id to Project
        /// </summary>
        public string ProjectId { get; set; }

        /// <summary>
        /// project of this bug
        /// </summary>
        public Project Project { get; set; }

    }
}
