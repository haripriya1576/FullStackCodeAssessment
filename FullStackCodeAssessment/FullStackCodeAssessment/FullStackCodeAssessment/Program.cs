using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackCodeAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task -1
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine(minStack.GetMin()); // return -3
            minStack.Pop();
            Console.WriteLine(minStack.Top());    // return 0
            Console.WriteLine(minStack.GetMin()); // return -2

            //Task -2
            Console.WriteLine("Enter string containing (,),[,],{,}");
            string input = Console.ReadLine();
            Console.WriteLine(CheckBalancedBrackets.IsValidInput(input));

            Console.ReadLine();
        }
    }
}
