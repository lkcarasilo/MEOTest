using Divisible.Service;
using System;
using System.Linq;

namespace Divisible
{
    /// <summary>
    /// Interface to interact with the user
    /// </summary>
    public class Interface : IDisplayer
    {
        /// <summary>
        /// Test a basic routine
        /// </summary>
        public void Test()
        {
            var testArrayString = Console.ReadLine();
            var testArray = testArrayString.Split(',');
            var numbers = testArray.Select(x => Convert.ToInt32(x.Trim())).ToArray();
            var divisorChecker = new DivisorChecker(numbers, this);
            divisorChecker.FindAllDivisors(false);
        }

        /// <summary>
        /// Show a result in the screen
        /// </summary>
        /// <param name="text">Text to show</param>
        public void Show(string text) => Console.WriteLine(text);
    }
}
