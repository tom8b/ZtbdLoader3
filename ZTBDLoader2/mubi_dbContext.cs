using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ZTBDLoader2
{
    public partial class mubi_dbContext : DbContext
    {
        public mubi_dbContext()
        {
        }

        public mubi_dbContext(DbContextOptions<mubi_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<ListsUser> ListsUsers { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<RatingsUser> RatingsUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("DataSource=F:\\SourceCode\\ZTBDLoader\\ZTBDLoader2\\ZTBDLoader2\\ZTBDLoader2\\mubi_db.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<List>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lists");

                entity.Property(e => e.ListComments).HasColumnName("list_comments");

                entity.Property(e => e.ListCoverImageUrl).HasColumnName("list_cover_image_url");

                entity.Property(e => e.ListCreationTimestampUtc).HasColumnName("list_creation_timestamp_utc");

                entity.Property(e => e.ListDescription).HasColumnName("list_description");

                entity.Property(e => e.ListFirstImageUrl).HasColumnName("list_first_image_url");

                entity.Property(e => e.ListFollowers).HasColumnName("list_followers");

                entity.Property(e => e.ListId).HasColumnName("list_id");

                entity.Property(e => e.ListMovieNumber).HasColumnName("list_movie_number");

                entity.Property(e => e.ListSecondImageUrl).HasColumnName("list_second_image_url");

                entity.Property(e => e.ListThirdImageUrl).HasColumnName("list_third_image_url");

                entity.Property(e => e.ListTitle).HasColumnName("list_title");

                entity.Property(e => e.ListUpdateTimestampUtc).HasColumnName("list_update_timestamp_utc");

                entity.Property(e => e.ListUrl).HasColumnName("list_url");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<ListsUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("lists_users");

                entity.Property(e => e.ListCreationDateUtc).HasColumnName("list_creation_date_utc");

                entity.Property(e => e.ListId).HasColumnName("list_id");

                entity.Property(e => e.ListUpdateDateUtc).HasColumnName("list_update_date_utc");

                entity.Property(e => e.UserAvatarImageUrl).HasColumnName("user_avatar_image_url");

                entity.Property(e => e.UserCoverImageUrl).HasColumnName("user_cover_image_url");

                entity.Property(e => e.UserEligibleForTrial).HasColumnName("user_eligible_for_trial");

                entity.Property(e => e.UserHasPaymentMethod).HasColumnName("user_has_payment_method");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserSubscriber).HasColumnName("user_subscriber");

                entity.Property(e => e.UserTrialist).HasColumnName("user_trialist");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("movies");

                entity.Property(e => e.DirectorId).HasColumnName("director_id");

                entity.Property(e => e.DirectorName).HasColumnName("director_name");

                entity.Property(e => e.DirectorUrl).HasColumnName("director_url");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.MovieImageUrl).HasColumnName("movie_image_url");

                entity.Property(e => e.MoviePopularity).HasColumnName("movie_popularity");

                entity.Property(e => e.MovieReleaseYear).HasColumnName("movie_release_year");

                entity.Property(e => e.MovieTitle).HasColumnName("movie_title");

                entity.Property(e => e.MovieTitleLanguage).HasColumnName("movie_title_language");

                entity.Property(e => e.MovieUrl).HasColumnName("movie_url");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ratings");

                entity.Property(e => e.Critic).HasColumnName("critic");

                entity.Property(e => e.CriticComments).HasColumnName("critic_comments");

                entity.Property(e => e.CriticLikes).HasColumnName("critic_likes");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.RatingId).HasColumnName("rating_id");

                entity.Property(e => e.RatingScore).HasColumnName("rating_score");

                entity.Property(e => e.RatingTimestampUtc).HasColumnName("rating_timestamp_utc");

                entity.Property(e => e.RatingUrl).HasColumnName("rating_url");

                entity.Property(e => e.UserEligibleForTrial).HasColumnName("user_eligible_for_trial");

                entity.Property(e => e.UserHasPaymentMethod).HasColumnName("user_has_payment_method");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserSubscriber).HasColumnName("user_subscriber");

                entity.Property(e => e.UserTrialist).HasColumnName("user_trialist");
            });

            modelBuilder.Entity<RatingsUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ratings_users");

                entity.Property(e => e.RatingDateUtc).HasColumnName("rating_date_utc");

                entity.Property(e => e.UserAvatarImageUrl).HasColumnName("user_avatar_image_url");

                entity.Property(e => e.UserCoverImageUrl).HasColumnName("user_cover_image_url");

                entity.Property(e => e.UserEligibleForTrial).HasColumnName("user_eligible_for_trial");

                entity.Property(e => e.UserHasPaymentMethod).HasColumnName("user_has_payment_method");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserSubscriber).HasColumnName("user_subscriber");

                entity.Property(e => e.UserTrialist).HasColumnName("user_trialist");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
