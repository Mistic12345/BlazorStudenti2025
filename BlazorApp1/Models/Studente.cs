using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BlazorApp1.Models
{
    public class Studente
    {
         public int Id { get; set; }

       [Required(ErrorMessage = "Il nome è obbligatorio")] public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "Il cognome è obbligatorio")] public string Cognome { get; set; } = string.Empty;
        public int Eta { get; set; }
        public DateTime DataNascita { get; set; }
        public string Doc { get; set; }
    }
}
