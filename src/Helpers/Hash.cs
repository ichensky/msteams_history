using System.Text;

namespace MSTeamsHistory.Helpers
{
    public static class Hash
    {
        public static string SHA1(this string input)
        {
            using (var hash = System.Security.Cryptography.SHA1.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var hashBytes = hash.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                for (var i = 0; i < hashBytes.Length; i++) sb.Append(hashBytes[i].ToString("X2"));
                return sb.ToString();
            }
        }

        public static string MD5(this string input)
        {
            using (var hash = System.Security.Cryptography.MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(input);
                var hashBytes = hash.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                for (var i = 0; i < hashBytes.Length; i++) sb.Append(hashBytes[i].ToString("X2"));
                return sb.ToString();
            }
        }
    }
}