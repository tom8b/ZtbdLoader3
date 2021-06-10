#nullable disable

namespace ZTBDLoader2
{
    public partial class RatingsUser
    {
        public long? UserId { get; set; }
        public string RatingDateUtc { get; set; }
        public long? UserTrialist { get; set; }
        public long? UserSubscriber { get; set; }
        public string UserAvatarImageUrl { get; set; }
        public string UserCoverImageUrl { get; set; }
        public long? UserEligibleForTrial { get; set; }
        public long? UserHasPaymentMethod { get; set; }
    }
}
