﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    /// <remarks>
    /// I've renamed this class from IsHappyPrime to HappyPrimes to be a bit more idiomatic.
    /// </remarks>>
    public class HappyPrimes
    {
        public delegate bool IsPrimeDelegate(int value);

        /// <summary>
        /// A delegate that takes an int and returns a boolean stating whether or not 
        /// the supplied integer is prime.
        /// </summary>
        public IsPrimeDelegate IsPrimeFunction { get; private set; }

        /// <summary>
        /// Implements the HappyPrimes class with the default prime checking function.
        /// </summary>
        public HappyPrimes() {
            IsPrimeFunction = IsPrime;
        }

        /// <summary>
        /// Implemnts the HappyPrimes class with the supplied prime checking delegate.
        /// </summary>
        /// <param name="isPrimeDelegate">
        /// Expects a function that takes an int and returns a boolean.
        /// </param>
        /// <remarks>
        /// This overloaded method is supplied to enable testing of the IsHappyPrime function independant
        /// of the prime tester. (essentially allowing for the testing of happy numbers, not just primes).
        /// The inversion of control here also reduces refactoring overhead if better prime algorthms are implemented.
        /// </remarks>
        public HappyPrimes(IsPrimeDelegate isPrimeDelegate)
        {
            IsPrimeFunction = isPrimeDelegate;
        }

        /// <summary>
        /// Determines whether the input value is a prime number.
        /// </summary>
        /// <param name="input">
        /// An integer to determine the primality of.
        /// </param>
        /// <returns>
        /// Returns true if the supplied value is prime.
        /// Returns false if the supplied value is not prime.
        /// </returns>
        /// <remarks>
        /// Zero can be neither prime nor composite.
        /// Since the excercize requires a boolean be returned, the function throws an exception in this case.
        /// An alternative would be to have a tristate result - an enumm, or some other safe representation.
        /// </remarks>
        public bool IsPrime(int input) {
            if (input == 1 ||
                input == 2)
            {
                return true;
            }
            if (input%2 == 0) //Eliminate evens
            {
                return false;
            }
            var i = 3;
            while (i <= Math.Sqrt(Int32.MaxValue) && i < input) //Eliminate duplicate divisors
            {
                if (input%i == 0) //Check if the input is divisible by the current int
                {
                    return false;
                }
                i = i + 2;
            }
            return true;
        }

        /// <summary>
        /// Determines whether the input value is a "happy prime".
        /// e.g. a prime number that is also a happy number.
        /// </summary>
        /// <param name="input">
        /// An integer to determine the happyness of.
        /// </param>
        /// <returns>
        /// Returns true if the supplied integer is happy.
        /// Returns false if the supplied integer is not happy.
        /// </returns>
	    public bool IsHappyPrime(int input) {
            //TODO: Use isprimefunction property rather than direct call to the internal IsPrime function.
		    throw new NotImplementedException();
	    }
    }
}
