using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki.")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Nazwisko")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki.")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Niepoprawny format adresu email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Prosze podaj Hasło")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków.")]
        [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną małą literę i jedną dużą literę.")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Prosze Potwierdź Hasło")]
        [Compare("Haslo", ErrorMessage = "Hasła nie zgadzają się.")]
        public string HasloPotwierdzenie { get; set; }

        [Required(ErrorMessage = "Prosze podaj Numer Telefonu")]
        [DataType(DataType.PhoneNumber)]
        public string NumerTelefonu { get; set; }

        [Required(ErrorMessage = "Prosze podaj swój Wiek")]
        [Range(10, 80, ErrorMessage = "Wiek musi być od 10 do 80 lat.")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Prosze wybierz Miasto")]
        public string Miasto { get; set; }

        public enum Miasta { Bydgoszcz = 1, Radom = 2, Białystok = 3, Marianów = 4, Węgrzce = 5 }

    }
}
