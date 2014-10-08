﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    /// <summary>
    /// Contains methods that find the longest string given some collection of strings.
    /// </summary>
    public class LongestString
    {

        /// <summary>
        /// Given a collection of strings, determines the nTh longest string in the list.
        /// </summary>
        /// <param name="nTh">The ordinal you are seeking.</param>
        /// <param name="inputs">The list of strings to search.</param>
        /// <returns>
        /// Returns the nTh longest string from the supplied list of strings.
        /// </returns>
        /// <example>
        /// Example: 		
        ///   {Yuri, Interview, Nordstrom, Cat, Dog, Telephone, AVeryLongString, This code puzzle is easy}
        ///    nTh = 1 > would return "This code puzzle is easy"
        /// </example>
        /// <remarks>
        /// In the original spec the stubbed method is declared with private scope. To ease testing, I exposed the method as public, but this can be changed if desired.
        /// I camal cased the method name here, but that's stylistic and can be changed to conform to other standards.
        /// </remarks>
        public string GetLongestString(int nTh, List<string> inputs) {
            throw new NotImplementedException();
        }
    }
}
