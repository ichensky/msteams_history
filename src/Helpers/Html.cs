using System.Text.RegularExpressions;

namespace MSTeamsHistory.Helpers
{
    public static class Html
    {
        public static string StripHTML(this string input)
        {
            return Regex.Replace(input, "<.*?>", string.Empty);
        }
    }
}