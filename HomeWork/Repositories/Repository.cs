using HomeWork.Repositories.Interfaces;
using HomeWork.Model;

namespace HomeWork.Repositories
{
    public class Repository : IRepository
    {
        private readonly IEnumerable<Animal> _animals;
        private List<string> listName { get; set; } = new List<string>();
        private List<string> listSound { get; set; } = new List<string>();
        public Repository(IEnumerable<Animal> animals)
        {
            _animals = animals;
        }
     
        public List<string> GetName()
        {
            foreach (var name in _animals)
                listName.Add(name.Name);
            return listName;
        }

        public List<string> GetSound()
        {
            foreach (var sound in _animals)
                listSound.Add(sound.Sound);
            return listSound;
        }
    }
}
