﻿using csharp_boolflix.Models;

namespace csharp_boolflix.Models
{
    public abstract class MediaContent
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; } //Durata definita in minuti
        public string Description { get; set; }
        public int VisualizationCount { get; set; }
    }
}
