using HomeWork.Repositories.Interfaces;
using System.Text.RegularExpressions;

namespace HomeWork.Repositories
{
    public class FileOperations : IFileOperations
    {
        private IWebHostEnvironment env;
        public FileOperations(IWebHostEnvironment env)
        {
            this.env = env;
        }

        public Dictionary<string, string> LoadFile(IFormFile uploadedFile)
        {
            string path = "/Files/" + uploadedFile.FileName;
            var regex = new Regex(@"[a-zA-Z]+");
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach(var items in File.ReadLines(path))
            {
                if (regex.IsMatch(items))
                {
                    var str = items.Split(':');
                    result[str[0]] = str[1];
                }
            }
            return result;
        }

        public void SaveFile(string text)
        {
            string path = env.WebRootPath + "/File/test.txt";
            File.WriteAllText(path, text);
        }
    }
}
