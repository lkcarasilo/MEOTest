using System;

namespace Divisible
{
    /// <summary>
    /// Class to execute the console app
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main function of the app
        /// </summary>
        /// <param name="args">Args passed by the caller</param>
        static void Main(string[] args)
        {
            var programInterface = new Interface();
            programInterface.Test();
            Console.ReadLine();
        }
    }
}
