using System;
using System.Collections.Generic;

#nullable disable

namespace ZTBDLoader2
{
    public partial class ListsUser
    {
        public long? UserId { get; set; }
        public long? ListId { get; set; }
        public string ListUpdateDateUtc { get; set; }
        public string ListCreationDateUtc { get; set; }
        public long? UserTrialist { get; set; }
        public long? UserSubscriber { get; set; }
        public string UserAvatarImageUrl { get; set; }
        public string UserCoverImageUrl { get; set; }
        public long? UserEligibleForTrial { get; set; }
        public long? UserHasPaymentMethod { get; set; }
    }
}
