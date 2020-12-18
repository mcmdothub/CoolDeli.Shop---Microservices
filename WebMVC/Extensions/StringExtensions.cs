namespace WebMVC.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmpty(this string str)
            => string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
    }
}
