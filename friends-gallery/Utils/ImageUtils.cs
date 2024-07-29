namespace friends_gallery.Utils
{
    public static class ImageUtils
    {
        public static byte[]? ConvertFromIFormFile(IFormFile image)
        {
            try
            {
                using MemoryStream stream = new();
                image.CopyTo(stream);
                return stream.ToArray();
            }
            catch
            {
                return null;
            }
        }
    }
}
