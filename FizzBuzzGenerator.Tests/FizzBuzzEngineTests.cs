using System.Linq;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzEngineTests
    {
        [Test]
        public void OutputShouldContainALineForEveryEntryBetween1AndTheUpperBound([Values(1, 10, 100, 1000, 42789)] int upperBound)
        {
            var writer = new FakeTextWriter();
            var engine = new FizzBuzzEngine(writer);
            engine.Run(upperBound);
            Assert.AreEqual(upperBound, writer.Results.Length);
        }

        [Test]
        public void NumbersDivisibleBy3ShouldOutputFizz()
        {
            var writer = new FakeTextWriter();

            var engine = new FizzBuzzEngine(writer, Rules.FizzRule);

            engine.Run(15);
            Assert.AreEqual("Fizz", writer.Results[2]);
            Assert.AreEqual("Fizz", writer.Results[5] );
            Assert.AreEqual("Fizz", writer.Results[8]);
            Assert.AreEqual("Fizz", writer.Results[11]);
            Assert.AreEqual("Fizz", writer.Results[14]);
        }

        [Test]
        public void WhenMultipleRulesMatchBothValuesShouldBeOutput()
        {
            var writer = new FakeTextWriter();

            var engine = new FizzBuzzEngine(writer, Rules.FizzRule, Rules.BuzzRule);

            engine.Run(15);            

            Assert.AreEqual(15, writer.Results.Length);
            Assert.AreEqual(writer.Results.Last(), "FizzBuzz");
        }



        [Test]
        public void WhenNoRulesAreSpecifiedTheResultsShouldBeAListOfNumbers()
        {
            var writer = new FakeTextWriter();
            var engine = new FizzBuzzEngine(writer);
            engine.Run(15);
            Assert.AreEqual(15, writer.Results.Length);

            CollectionAssert.AreEquivalent(new [] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"}, 
                                           writer.Results);            
        }
    }
}
