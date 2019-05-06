using System;
using System.Collections.Generic;

namespace Divisible.Service
{
    /// <summary>
    /// Class to check divisors routine
    /// </summary>
    public class DivisorChecker
    {

        #region .: Attributes :.

        private readonly int[] _divisorOptions;
        private readonly IDisplayer _displayer;
        private readonly HashSet<string> _resultList;

        #endregion .: Attributes :.

        #region .: Constructor :.

        /// <summary>
        /// Creates a divisor checker object
        /// </summary>
        /// <param name="divisorOptions">Array with the divisor options</param>
        /// <param name="displayer">Displayer to show the results</param>
        /// <exception cref="ArgumentNullException">When any of the arguments is null</exception>
        public DivisorChecker(int[] divisorOptions, IDisplayer displayer)
        {
            _divisorOptions = divisorOptions ?? throw new ArgumentNullException("You should provide a non-null array");
            _displayer = displayer ?? throw new ArgumentNullException("You should provide a non-null displayer");
            _resultList = new HashSet<string>();
        }

        #endregion .: Constructor :.

        #region .: Public Methods :.

        /// <summary>
        /// Finds all divisor of all number in divisor options array
        /// </summary>
        /// <param name="canRepeatNumbers">If can repeat numbers</param>
        public void FindAllDivisors(bool canRepeatNumbers)
        {
            foreach (var number in _divisorOptions)
                CheckDivisor(number, canRepeatNumbers);
        }

        #endregion .: Public Methods :.

        #region .: Private Methods :.

        /// <summary>
        /// Finds all divisor of a given number
        /// </summary>
        /// <param name="multiple">Multiple to find the divisors of</param>
        /// <param name="canRepeatNumbers">If can repeat numbers or not</param>
        private void CheckDivisor(int multiple, bool canRepeatNumbers)
        {
            foreach (var number in _divisorOptions)
            {
                if (multiple % number == 0)
                {
                    var resultText = $"{multiple} div {number}";
                    var isDuplicated = _resultList.Contains(resultText);
                    if ((isDuplicated && canRepeatNumbers) || !isDuplicated)
                        _displayer.Show($"{multiple} div {number}");
                    if (!isDuplicated)
                        _resultList.Add(resultText);
                }
            }
        }

        #endregion .: Private Methods :.

    }
}
