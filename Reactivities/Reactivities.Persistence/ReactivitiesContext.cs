using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reactivities.Domain;

namespace Reactivities.Persistence
{
    public class ReactivitiesContext : IdentityDbContext<AppUser>
    {
        public ReactivitiesContext(DbContextOptions<ReactivitiesContext> options) : base(options)
        {

        }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityAttendee> ActivityAttendees { get; set; }
        public DbSet<Photo> Photos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ActivityAttendee>(x => x.HasKey(k => new { k.ActivityId, k.AppUserId }));
            modelBuilder.Entity<ActivityAttendee>().HasOne(u => u.AppUser)
                .WithMany(a => a.Activities).HasForeignKey(aa => aa.AppUserId);
            modelBuilder.Entity<ActivityAttendee>().HasOne(a => a.Activity)
                .WithMany(a => a.Attendees).HasForeignKey(aa => aa.ActivityId);
            
        }
    }
}
