using Xunit;
using FizzBuzzApp.data_storage;
using System.Collections.Generic;
using System.IO;
using FizzBuzzApp.Interfaces;

namespace FizzBuzzApp.Tests
{
    public class FileStorageTests : IDisposable
    {
        private readonly string _inputPath;
        private readonly string _outputPath;
        private readonly IDataStorage _storage;

        public FileStorageTests()
        {
            _inputPath = "test_input.txt";
            _outputPath = "test_output.txt";
            _storage = new FileStorage(_inputPath, _outputPath);

            // Simular los datos de entrada
            File.WriteAllLines(_inputPath, new[] { "3", "5", "15", "7" });
        }

        [Fact]
        public void ReadData_ShouldReturnCorrectData()
        {
            // Verificar que el método ReadData lea correctamente los datos del archivo de entrada
            var data = _storage.ReadData();
            Assert.Equal(new List<string> { "3", "5", "15", "7" }, data);
        }

        [Fact]
        public void SaveData_ShouldSaveCorrectData()
        {
            // Guardar datos en el archivo de salida y verificar que se guardan correctamente
            var data = new List<string> { "Fizz", "Buzz", "FizzBuzz", "7" };
            _storage.SaveData(data);

            var savedData = File.ReadAllLines(_outputPath);
            Assert.Equal(data, savedData);
        }

        public void Dispose()
        {
            // Limpiar los archivos temporales después de cada prueba
            if (File.Exists(_inputPath))
            {
                File.Delete(_inputPath);
            }

            if (File.Exists(_outputPath))
            {
                File.Delete(_outputPath);
            }
        }
    }
}
