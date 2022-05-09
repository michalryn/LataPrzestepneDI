using System.ComponentModel.DataAnnotations;

namespace LataPrzestepneDI.ViewModels.Person
{
    public class PersonVM
    {
        [Display(Name = "Imię i Nazwisko użytkownika")]
        public string FullName { get; set; }

        [Display(Name = "Rok")]
        public int? Rok { get; set; }

        [DataType(DataType.Text)]
        public string? Text { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }
    }
}
