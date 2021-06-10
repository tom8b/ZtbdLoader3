using System;
using System.Collections.Generic;

#nullable disable

namespace ZTBDLoader2
{
    public partial class List
    {
        public long? UserId { get; set; }
        public long? ListId { get; set; }
        public string ListTitle { get; set; }
        public long? ListMovieNumber { get; set; }
        public string ListUpdateTimestampUtc { get; set; }
        public string ListCreationTimestampUtc { get; set; }
        public long? ListFollowers { get; set; }
        public string ListUrl { get; set; }
        public long? ListComments { get; set; }
        public string ListDescription { get; set; }
        public string ListCoverImageUrl { get; set; }
        public string ListFirstImageUrl { get; set; }
        public string ListSecondImageUrl { get; set; }
        public string ListThirdImageUrl { get; set; }
    }
}
