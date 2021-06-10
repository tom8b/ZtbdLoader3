using System;
using System.Collections.Generic;

#nullable disable

namespace ZTBDLoader2
{
    public partial class Movie
    {
        public long? MovieId { get; set; }
        public string MovieTitle { get; set; }
        public double? MovieReleaseYear { get; set; }
        public string MovieUrl { get; set; }
        public string MovieTitleLanguage { get; set; }
        public long? MoviePopularity { get; set; }
        public string MovieImageUrl { get; set; }
        public string DirectorId { get; set; }
        public string DirectorName { get; set; }
        public string DirectorUrl { get; set; }
    }
}
