namespace friends_gallery.Utils
{
    public static class NullUtils
    {
        public static bool IsAnyNull(params object?[] nullables) =>
            nullables.Any(x => x == null);
    }
}
