#nullable disable

namespace ZTBDLoader2
{
    public partial class Rating
    {
        public long? MovieId { get; set; }
        public long? RatingId { get; set; }
        public string RatingUrl { get; set; }
        public double? RatingScore { get; set; }
        public string RatingTimestampUtc { get; set; }
        public string Critic { get; set; }
        public long? CriticLikes { get; set; }
        public long? CriticComments { get; set; }
        public long? UserId { get; set; }
        public long? UserTrialist { get; set; }
        public long? UserSubscriber { get; set; }
        public long? UserEligibleForTrial { get; set; }
        public long? UserHasPaymentMethod { get; set; }
    }
}
