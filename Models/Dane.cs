using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Prosze podaj Temat")]
        //public string Temat { get; set; }
        //[Required(ErrorMessage = "Prosze podaj Tresc wiadomosci")]
        //[MinLength(10), MaxLength(50)]
        //public string Tresc { get; set; }
        public string Haslo { get; set; }
        public string HasloPotwierdzenie { get; set; }
        public int NumerTelefonu { get; set; }
        public int Wiek { get; set; }
        public string Miasto { get; set; }
        public enum Miasta { Bydgoszcz = 1, Radom = 2, Białystok = 3, Marianów = 4, Węgrzce = 5 }

    }
}
