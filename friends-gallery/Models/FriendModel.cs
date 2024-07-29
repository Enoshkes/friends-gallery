using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace friends_gallery.Models
{
    public class FriendModel
    {
        public long Id {  get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public required string FirstName { get; set; }
        [Required]
        [StringLength (100, MinimumLength = 3)]
        public required string LastName { get; set; }
        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public List<ImageModel> Images { get; set; } = [];

    }
}
