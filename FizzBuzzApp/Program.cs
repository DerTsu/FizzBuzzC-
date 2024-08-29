using FizzBuzzApp.data_storage;
using FizzBuzzApp.problem_solver;
using FizzBuzzApp.Interfaces;

namespace FizzBuzzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputPath = "input.txt";
            var outputPath = "output.txt";
            IDataStorage storage = new FileStorage(inputPath, outputPath);
            IProblemSolver problemSolver = new FizzBuzz();
            var app = new MyApp(storage, problemSolver);
            app.Run();
        }
    }
}
