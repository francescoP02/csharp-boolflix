namespace csharp_boolflix.Models
{
    public class Episode : MediaContent
    {
        public int DurationInMinutes { get; set; }
        public int Season { get; set; }
        public int TvSeriesId { get; set; }
        public TvSerie TvSeries { get; set; }
        public Episode()
        {

        }
    }
}
