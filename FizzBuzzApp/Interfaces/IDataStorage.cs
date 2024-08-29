namespace FizzBuzzApp.Interfaces
{
    public interface IDataStorage
    {
        List<string> ReadData();
        void SaveData(List<string> data);
    }
}
