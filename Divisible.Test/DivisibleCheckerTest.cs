using Divisible.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Divisible.Test
{
    /// <summary>
    /// Class to test the divisible checker
    /// </summary>
    [TestClass]
    public class DivisibleCheckerTest
    {

        #region .: Attributes :.

        private readonly TestInterface _interface;

        #endregion .: Attributes :.

        #region .: Constructor :.

        /// <summary>
        /// Creates a tester to the <see cref="DivisorChecker"/>
        /// </summary>
        public DivisibleCheckerTest()
        {
            _interface = new TestInterface();
        }

        #endregion .: Constructor :.

        #region .: Test Methods :.

        /// <summary>
        /// Tests a null array
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullArray()
        {
            _interface.ClearResults();
            int[] options = null;
            var divisorChecker = new DivisorChecker(options, _interface);
        }

        /// <summary>
        /// Tests a null displayer
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullInterface()
        {
            _interface.ClearResults();
            int[] options = new int[] { 1, 2, 3 };
            var divisorChecker = new DivisorChecker(options, null);
        }

        /// <summary>
        /// Tests the step 1 with duplicated items
        /// </summary>
        [TestMethod]
        public void TestStep1()
        {
            _interface.ClearResults();
            int[] options = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };
            var divisorChecker = new DivisorChecker(options, _interface);
            var expectedResult = new List<string>() {   "1 div 1",
                                                        "9 div 1",
                                                        "9 div 9",
                                                        "9 div 3",
                                                        "9 div 9",
                                                        "3 div 1",
                                                        "3 div 3",
                                                        "4 div 1",
                                                        "4 div 4",
                                                        "4 div 2",
                                                        "5 div 1",
                                                        "5 div 5",
                                                        "6 div 1",
                                                        "6 div 3",
                                                        "6 div 6",
                                                        "6 div 2",
                                                        "2 div 1",
                                                        "2 div 2",
                                                        "9 div 1",
                                                        "9 div 9",
                                                        "9 div 3",
                                                        "9 div 9" };
            divisorChecker.FindAllDivisors(true);
            CollectionAssert.AreEqual(expectedResult, _interface.GetResults());
        }

        /// <summary>
        /// Test step2 without duplicated items
        /// </summary>
        [TestMethod]
        public void TestStep2()
        {
            _interface.ClearResults();
            int[] options = new int[] { 1, 9, 3, 4, 5, 6, 2, 9 };
            var divisorChecker = new DivisorChecker(options, _interface);
            var expectedResult = new List<string>() {   "1 div 1",
                                                        "9 div 1",
                                                        "9 div 9",
                                                        "9 div 3",
                                                        "3 div 1",
                                                        "3 div 3",
                                                        "4 div 1",
                                                        "4 div 4",
                                                        "4 div 2",
                                                        "5 div 1",
                                                        "5 div 5",
                                                        "6 div 1",
                                                        "6 div 3",
                                                        "6 div 6",
                                                        "6 div 2",
                                                        "2 div 1",
                                                        "2 div 2" };
            divisorChecker.FindAllDivisors(false);
            CollectionAssert.AreEqual(expectedResult, _interface.GetResults());
        }

        #endregion .: Test Methods :.
    }
}
