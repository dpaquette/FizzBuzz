using System;
using System.IO;

namespace FizzBuzz.Tests
{
    public class FakeTextWriter : StringWriter
    {
        public string[] Results { get; private set; } = { };

        public override void Flush()
        {
            base.Flush();
            Results = base.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
