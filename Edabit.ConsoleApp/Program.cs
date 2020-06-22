using Edabit.ConsoleApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabit.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Check if the Same Case
        /// 
        /// LINK : https://edabit.com/challenge/ivaEWKZbFMcR8emJ8
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool SameCase(string str)
        {
            bool firstCharUpperCase = char.IsUpper(str[0]);

            for (int i = 1; i < str.Length; i++)
            {
                if (firstCharUpperCase && char.IsLower(str[i])
                || !firstCharUpperCase && char.IsUpper(str[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
