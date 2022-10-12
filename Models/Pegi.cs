namespace csharp_boolflix.Models
{
    public class Pegi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Film> Films { get; set; }
        public List<TvSerie> TVSeries { get; set; }

        public Pegi()
        {

        }
    }
}
