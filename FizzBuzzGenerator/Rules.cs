namespace FizzBuzz
{
    /// <summary>
    /// Some built-in rules for the FizzBuzzEngine engine
    /// </summary>
    public static class Rules
    {
        public static readonly Rule FizzRule = new Rule(i => i % 3 == 0, "Fizz");
        public static readonly Rule BuzzRule = new Rule(i => i % 5 == 0, "Buzz");
    }
}
