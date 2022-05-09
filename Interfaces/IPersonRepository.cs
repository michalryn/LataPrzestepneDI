using LataPrzestepneDI.Models;

namespace LataPrzestepneDI.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetAllEntries();
        IQueryable<Person> GetEntriesFromToday();
        void AddEntry(Person person);
    }
}
