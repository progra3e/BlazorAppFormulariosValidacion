namespace BlazorAppFormulariosValidacion
{
    public class Alumno : Persona
    {
        public string NumeroCarne { get; set; }
        public List<int> Notas { get; set; }

        public Alumno()
        {
            NumeroCarne = string.Empty;
            Notas = new List<int>();            
        }

    }
}
