using FizzBuzzApp.problem_solver;
using FizzBuzzApp.Interfaces;

namespace FizzBuzzApp.Tests
{
    public class FizzBuzzTests
    {
        private readonly IProblemSolver fizzBuzz;

        public FizzBuzzTests()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Fact]
        public void TestFizz()
        {
            var result = fizzBuzz.ComputeResults(new List<string> { "3" });
            Assert.Equal(new List<string> { "Fizz" }, result);
        }

        [Fact]
        public void TestBuzz()
        {
            var result = fizzBuzz.ComputeResults(new List<string> { "5" });
            Assert.Equal(new List<string> { "Buzz" }, result);
        }

        [Fact]
        public void TestFizzBuzz()
        {
            var result = fizzBuzz.ComputeResults(new List<string> { "15" });
            Assert.Equal(new List<string> { "FizzBuzz" }, result);
        }

        [Fact]
        public void TestNumber()
        {
            var result = fizzBuzz.ComputeResults(new List<string> { "2" });
            Assert.Equal(new List<string> { "2" }, result);
        }

        [Fact]
        public void TestMultipleValues()
        {
            var result = fizzBuzz.ComputeResults(new List<string> { "3", "5", "15", "7" });
            Assert.Equal(new List<string> { "Fizz", "Buzz", "FizzBuzz", "7" }, result);
        }

        [Fact]
        public void TestZero()
        {
            var result = fizzBuzz.ComputeResults(new List<string> { "0" });
            Assert.Equal(new List<string> { "FizzBuzz" }, result);
        }

        [Fact]
        public void TestLargeNumber()
        {
            var result = fizzBuzz.ComputeResults(new List<string> { "901352955" });
            Assert.Equal(new List<string> { "FizzBuzz" }, result);
        }

        [Fact]
        public void TestNegativeNumber()
        {
            var result = fizzBuzz.ComputeResults(new List<string> { "-1" });
            Assert.Equal(new List<string> { "-1" }, result);
        }
    }
}
