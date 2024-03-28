using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.Models
{
    /// <summary>
    /// User Class
    /// </summary>
    public class User
    {
        /// <summary>
        /// User Id
        /// </summary>
        [Key]
        [JsonPropertyName("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// User Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// User Surname
        /// </summary>
        [JsonPropertyName("surname")]
        public string Surname { get; set; } = string.Empty;

        /// <summary>
        /// list of bugs of this particular user
        /// </summary>
        public ICollection<Bug> Bugs { get; set; } = new List<Bug>();
    }
}
