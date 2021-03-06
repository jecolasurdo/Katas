﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
        /// <param name="nTh">
        /// The ordinal you are seeking where 1 is the longest word in the list.
        /// <para>This is not zero based.</para>
        /// <para>This must be a positive integer.</para>
        /// <para>If the given number is greater than the list length, the shortest word in the list is returned.</para>
        /// <para>If multiple words in the list are the same length, the word that appears first in the list is returned.</para>
        /// </param>
        /// <param name="inputs">The list of strings to search.
        /// <para>Null or empty list throws exception.</para>
        /// </param>
        /// <returns>
        /// Returns the nTh longest string from the supplied list of strings.
        /// </returns>
        /// <example>
        /// Example: 		
        /// Given the following list: {Yuri, Interview, Nordstrom, Cat, Dog, Telephone, AVeryLongString, This code puzzle is easy}
        /// <para>nTh = 1 > would return "This code puzzle is easy"</para>
        /// </example>
        /// <remarks>
        /// <para>I renamed the method from GetLongestString to GetNthLongestString so that the method's intent is more clear.</para>
        /// <para>In the original spec the stubbed method is declared with private scope. To ease testing, I exposed the method as public, but this can be changed if desired.</para>
        /// <para>I camal cased the method name here, but that's stylistic and can be changed to conform to other standards.</para>
        /// <para>I took some liberties with the specifications on this. These would normally be nailed down more concretely with just some BA work.</para>
        /// </remarks>
        public string GetNthLongestString(int nTh, List<string> inputs) {
            if (nTh <= 0)
            {
                throw new ArgumentException("The value supplied for nTh must be greater than or equal to one.","nTh");
            }

            if (inputs.Count == 0)
            {
                throw new ArgumentException("The input list must not be empty.","inputs");
            }

            if (nTh > inputs.Count)
            {
                nTh = inputs.Count;
            }

            var sortedList = inputs;
            sortedList.Sort((a,b)=>b.Length-a.Length);
            var lengthOfNthItem = sortedList.ElementAt(nTh - 1).Length;
            var distinct = inputs.Distinct().ToList();
            var itemsOfSameLength = distinct.FindAll((i) => i.Length == lengthOfNthItem);
            return itemsOfSameLength.First();
        }
    }
}
