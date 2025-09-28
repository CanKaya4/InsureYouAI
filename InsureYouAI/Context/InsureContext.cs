using InsureYouAI.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsureYouAI.Context
{
    public class InsureContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=InsureYouDb;Trusted_Connection=True;integrated Security=true;Trust server certificate=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutItem> AboutItems { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Comment>  Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PricingPlan> pricingPlans { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TrailerVideo> trailerVideos { get; set; }
    }
}
