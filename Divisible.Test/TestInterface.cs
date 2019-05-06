using Divisible.Service;
using System;
using System.Collections.Generic;

namespace Divisible.Test
{
    /// <summary>
    /// Interface to unit test asserts
    /// </summary>
    public class TestInterface : IDisplayer
    {

        #region .: Attributes :.

        private List<string> _resultList;

        #endregion .: Attributes :.

        #region .: Constructor :.

        /// <summary>
        /// Creates a test interface
        /// </summary>
        public TestInterface()
        {
            _resultList = new List<string>();
        }

        #endregion .: Constructor :.

        #region .: Public Methods :.

        /// <summary>
        /// "Shows" a text
        /// </summary>
        /// <param name="text">The text to add to the result list</param>
        public void Show(string text) => _resultList.Add(text);

        /// <summary>
        /// Get the "displayed" strings
        /// </summary>
        /// <returns>The result strings to check</returns>
        public List<String> GetResults() => _resultList;

        /// <summary>
        /// Clear the results of the test
        /// </summary>
        public void ClearResults() => _resultList.Clear();

        #endregion .: Public Methods :.

    }
}
