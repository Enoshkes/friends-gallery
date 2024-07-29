using System.ComponentModel.DataAnnotations;

namespace friends_gallery.Models
{
    public class ImageModel
    {
        public long Id { get; set; }
        [Required]
        public required byte[] Data { get; set; }
        public FriendModel Friend { get; set; }
        public long FriendId { get; set; }
    }
}