using FizzBuzzApp.Interfaces;

namespace FizzBuzzApp.problem_solver
{
    public class FizzBuzz : IProblemSolver
    {
        public List<string> ComputeResults(List<string> data)
        {
            var results = new List<string>();

            foreach (var numberStr in data)
            {
                if (long.TryParse(numberStr, out long number))
                {
                    results.Add(_fizzBuzz(number));
                }
            }

            return results;
        }

        public string Solve(int v)
        {
            throw new NotImplementedException();
        }

        private string _fizzBuzz(long number)
        {
            return number % 15 == 0 ? "FizzBuzz" :
                   number % 3 == 0 ? "Fizz" :
                   number % 5 == 0 ? "Buzz" :
                   number.ToString();
        }
    }
}
