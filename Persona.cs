using System.ComponentModel.DataAnnotations;

namespace BlazorAppFormulariosValidacion
{
    public class Persona
    {
        [Required (ErrorMessage ="El Nombre es Requerido")]        
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es Requerido")]
        public string Apellido { get; set; }

        public string Direccion { get; set; }
        public DateTime FechaNacimiento {  get; set; }

        public Persona()
        {
                Nombre = string.Empty;
                Apellido = string.Empty;
                Direccion = string.Empty;
        }

        public int Edad ()
        {
            TimeSpan intervalo = DateTime.Now - FechaNacimiento;

            return Convert.ToInt16(intervalo / 365);

        }
    

    }
}
