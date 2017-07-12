using System.IO;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzEngine
    {        
        private readonly TextWriter _output;
        private readonly Rule[] _rules;

        public FizzBuzzEngine(TextWriter output, params Rule[] rules)
        {            
            _output = output;
            _rules = rules;
        }

        public void Run(int upperBound)
        {
            
            for (int i = 1; i <= upperBound; i++)
            {               
                var matchingRules = _rules.Where(r => r.IsMatch(i)).ToArray();
                if (matchingRules.Length > 0)
                {
                    _output.WriteLine(string.Join(string.Empty, matchingRules.Select(r => r.Text)));
                }
                else
                {
                    _output.WriteLine(i);
                }                
            }

            _output.Flush();

        }
    }
}
