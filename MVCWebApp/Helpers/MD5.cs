using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class MD5
    {
        public static string Encode(string value)
        {
            var hash = System.Security.Cryptography.MD5.Create();
            var encoder = new System.Text.ASCIIEncoding();
            var combined = encoder.GetBytes(value ?? string.Empty);
            return BitConverter.ToString(hash.ComputeHash(combined)).ToLower().Replace("-", string.Empty);
        }
    }
}
