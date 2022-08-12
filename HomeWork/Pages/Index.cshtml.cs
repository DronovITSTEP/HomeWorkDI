using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using HomeWork.Repositories.Interfaces;
using HomeWork.Model;

namespace HomeWork.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepository _repository;
        public Dictionary<List<string>, List<string>> animals;
        public IndexModel(IRepository repository)
        {
            _repository = repository;
            animals = new Dictionary<List<string>, List<string>>();
        }

        public void OnGet()
        {
            animals.Add(_repository.GetName(), _repository.GetSound());
        }
    }
}