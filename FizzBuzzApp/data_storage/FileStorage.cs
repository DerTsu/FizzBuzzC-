using FizzBuzzApp.Interfaces;

namespace FizzBuzzApp.data_storage
{
    public class FileStorage : IDataStorage
    {
        private readonly string _inputPath;
        private readonly string _outputPath;

        public FileStorage(string inputPath, string outputPath)
        {
            _inputPath = inputPath;
            _outputPath = outputPath;
        }

        public List<string> ReadData()
        {
            return File.ReadAllLines(_inputPath).ToList();
        }

        public void SaveData(List<string> data)
        {
            File.WriteAllLines(_outputPath, data);
        }
    }
}
