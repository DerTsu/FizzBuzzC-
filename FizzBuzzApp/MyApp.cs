using FizzBuzzApp.Interfaces;

namespace FizzBuzzApp
{
    public class MyApp
    {
        private readonly IDataStorage _dataHandler;
        private readonly IProblemSolver _problemHandler;

        public MyApp(IDataStorage dataHandler, IProblemSolver problemHandler)
        {
            _dataHandler = dataHandler;
            _problemHandler = problemHandler;
        }

        public void Run()
        {
            var data = _dataHandler.ReadData();
            var results = _problemHandler.ComputeResults(data);
            var outputLines = new List<string>();

            for (int i = 0; i < data.Count; i++)
            {
                outputLines.Add($"{data[i]} {results[i]}");
            }

            _dataHandler.SaveData(outputLines);
        }
    }
}
