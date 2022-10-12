namespace csharp_boolflix.Models
{
    public class Film : MediaContent
    {
        public int DurationInMinutes { get; set; }
        public MediaInfo MediaInfo { get; set; }
        public int PegiId { get; set; }
        public Pegi Pegi { get; set; }
        public Film()
        {

        }
    }
}
