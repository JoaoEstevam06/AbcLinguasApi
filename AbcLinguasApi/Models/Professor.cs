namespace AbcLinguasApi.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Titulacao { get; set; }

        public Curso Curso { get; set; }
    }
}