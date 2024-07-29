using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace friends_gallery.ViewModel
{
    public class FriendVM
    {
        public long Id { get; set; }
        
        [StringLength(
            100, 
            MinimumLength = 3, 
            ErrorMessage = "First name should be in a range of 3 - 100")
        ]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(
            100,
            MinimumLength = 3,
            ErrorMessage = "Last name should be in a range of 3 - 100")
        ]
        public string LastName { get; set; } = string.Empty;

        public IFormFile? UploadedImage { get; set; }

        public byte[]? FriendImage { get; set; }

    }
}
