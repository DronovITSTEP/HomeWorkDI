namespace HomeWork.Repositories.Interfaces
{
    public interface IFileOperations
    {
        void SaveFile(string text);
        Dictionary<string, string> LoadFile(IFormFile uploadedFile);
    }
}
