using LataPrzestepneDI.Interfaces;
using LataPrzestepneDI.ViewModels.Person;
using LataPrzestepneDI.Models;

namespace LataPrzestepneDI.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepo;
        public PersonService(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        public List<PersonVM> GetAllEntries()
        {
            var people = _personRepo.GetAllEntries();
            List<PersonVM> result = new List<PersonVM>();
            foreach (var person in people)
            {
                var pVM = new PersonVM()
                {
                    FullName = person.Imie + " " + person.Nazwisko,
                    Rok = person.Rok,
                    Text = person.Text,
                    Date = person.Data
                };
                result.Add(pVM);
            }
            return result;
        }

        public List<PersonVM> GetEntriesFromToday()
        {
            var people = _personRepo.GetEntriesFromToday();
            List<PersonVM> result = new List<PersonVM>();

            foreach (var person in people)
            {
                var pVM = new PersonVM()
                {
                    FullName = person.Imie + " " + person.Nazwisko,
                    Rok = person.Rok,
                    Text = person.Text,
                    Date = person.Data
                };
                result.Add(pVM);
            }
            return result;
        }

        public void AddEntry(Person person)
        {
            _personRepo.AddEntry(person);
        }
    }
}
