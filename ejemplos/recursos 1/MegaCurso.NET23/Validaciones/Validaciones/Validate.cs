using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{

    public static class ValidateT
    {


        public static void NotNullEmpty(string input, string message)
        {
            if (string.IsNullOrEmpty(input))
                throw new InvalidOperationException(message);
        }


        public static void Regex(string input, string pattern, string message)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(input, pattern))
            {
                throw new InvalidOperationException(message);
            }
        }

    }

}
