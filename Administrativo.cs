namespace BlazorAppFormulariosValidacion
{
    public class Administrativo : Persona
    {
        public string Profesion {  get; set; }
        public string Igss {  get; set; }

        public Administrativo()
        {
            Profesion = string.Empty;
            Igss = string.Empty;
        }
    }
}
