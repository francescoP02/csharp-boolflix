using csharp_boolflix.Models;

public class TvSerie : MediaContent
{
    public int SeasonsCount { get; set; }
    //public int EpisodeCount { get; set; } 
    public MediaInfo MediaInfo { get; set; }
    public List<Episode> Episodes { get; set; }
    public int PegiId { get; set; }
    public Pegi Pegi { get; set; }
    public TvSerie()
    {

    }
}
