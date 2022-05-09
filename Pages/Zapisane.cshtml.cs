using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LataPrzestepneDI.Interfaces;
using LataPrzestepneDI.ViewModels.Person;

namespace LataPrzestepneDI.Pages
{
    public class ZapisaneModel : PageModel
    {
        private readonly IPersonService _personService;

        public ZapisaneModel(IPersonService personService)
        {
            _personService = personService;
        }
        public IList<PersonVM> Persons { get; set; }
        public void OnGet()
        {
            Persons =  _personService.GetAllEntries();
            Persons.OrderByDescending(p => p.Date);
        }
    }
}
