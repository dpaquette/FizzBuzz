using System;
using System.Diagnostics;

namespace FizzBuzz
{
    public class Rule
    {       
        private readonly Func<int, bool> _matchFunction;

        /// <summary>
        /// Creates a new rule for the FizzBuzzEngine engine
        /// </summary>
        /// <param name="matchFunction">A function that returns true if the specificed integer matches this rule</param>
        /// <param name="text">The text that will be used when this rule matches</param>
        public Rule(Func<int, bool> matchFunction, string text)
        {
            Debug.Assert(matchFunction != null, "matchFunction cannot be null");
            Debug.Assert(!string.IsNullOrWhiteSpace(text), "text cannot be null or whitespace");

            _matchFunction = matchFunction;
            Text = text;
        }

        public string Text { get; }

        public bool IsMatch(int value)
        {
            return _matchFunction(value);
        }

    }
}
