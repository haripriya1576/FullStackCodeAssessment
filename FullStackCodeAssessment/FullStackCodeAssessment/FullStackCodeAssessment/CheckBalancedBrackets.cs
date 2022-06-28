using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackCodeAssessment
{
    public class CheckBalancedBrackets
    {
        public static bool IsValidInput(string input)
        {
            int counter = 0;
            if (input.Length == 0)
                return true;


            if (input.Length % 2 != 0)
                return false;


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ')' || input[i] == ']' || input[i] == '}')
                {
                    if (counter == 0)
                        return false;
                    counter--;
                }
                else
                    counter++;
            }
            return counter == 0;
        }
    }
}
