using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Models
{
    /// <summary>
    /// Project Class
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Project Id
        /// </summary>
        [Key]
        [JsonPropertyName("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Project Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Project Description
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; } = string.Empty;

        /// <summary>
        /// list of bugs of this particular project
        /// </summary>
        public ICollection<Bug> Bugs { get; set; } = new List<Bug>();

    }
}
