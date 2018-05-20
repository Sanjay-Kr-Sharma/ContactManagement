namespace SampleDataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContactModel : DbContext
    {
        
        Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        public ContactModel()
            : base("name=ContactModel")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property(e => e.PrimaryPhone)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Phone1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Contact>()
                .Property(e => e.Phone2)
                .HasPrecision(18, 0);
        }
    }
}
