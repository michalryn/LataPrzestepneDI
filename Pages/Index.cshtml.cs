using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LataPrzestepneDI.Interfaces;
using LataPrzestepneDI.Models;
using LataPrzestepneDI.ViewModels.Person;

namespace LataPrzestepneDI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IPersonService _personService;

        [BindProperty]
        public Person Person { get; set; }
        [BindProperty]
        public List<PersonVM>? Persons { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        public void OnGet()
        {
            Persons = _personService.GetEntriesFromToday();
            Persons.OrderByDescending(p => p.Date);
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                TempData["Message"] = Person.AlertMessage();
                _personService.AddEntry(Person);

                return Redirect("/Index");
            }
            Persons = _personService.GetEntriesFromToday();
            Persons.OrderByDescending(p => p.Date);
            return Page();
        }
    }
}