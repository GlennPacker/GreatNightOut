using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GNO.Models
{
    public class GreatNightOutContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<GreatNightOutContext.Web.Models.GreatNightOutContext>());

        public GreatNightOutContext() : base("DefaultConnection")
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<MeetupMember> MeetupMembers { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<PartyImage> PartyImages { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Runner> Runner { get; set; }
        public DbSet<SiteParameter> SiteParamters { get; set; }
        public DbSet<TripAdvisor> TripAdvisor { get; set; }
        public DbSet<TripAdvisorReview> TripAdvisorReviews { get; set; } 
        public DbSet<UserAccount> UserAccount { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<Log> Log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Introducing FOREIGN KEY constraint 'FK_dbo.Friends_dbo.UserAccounts_FriendToID' on table 'Friends' may cause cycles or multiple cascade paths. 
            //    Specify ON DELETE NO ACTION or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
        }


    }
}
