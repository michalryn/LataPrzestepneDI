using LataPrzestepneDI.ViewModels.Person;
using LataPrzestepneDI.Models;

namespace LataPrzestepneDI.Interfaces
{
    public interface IPersonService
    {
        List<PersonVM> GetAllEntries();
        List<PersonVM> GetEntriesFromToday();
        void AddEntry(Person person);
    }
}
