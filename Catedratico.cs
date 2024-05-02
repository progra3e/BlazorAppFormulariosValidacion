using System.ComponentModel.DataAnnotations;

namespace BlazorAppFormulariosValidacion
{
    public class Catedratico : Persona
    {
        [Required (ErrorMessage = "El Título es Requerido")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El Colegiado es Requerido")]
        [StringLength(6,ErrorMessage = "Deben ser menos de 6 dígitos")]
        public string Colegiado { get; set; }

        public Catedratico()
        {
          Titulo = string.Empty;
          Colegiado = string.Empty;
        }
    }
}
