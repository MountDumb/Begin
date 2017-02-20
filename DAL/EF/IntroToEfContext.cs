namespace DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class IntroToEfContext : DbContext
    {
        public IntroToEfContext()
            : base("name=IntroToEfContext")
        {
        }

        public virtual DbSet<PET> PET { get; set; }
        public virtual DbSet<Pet_Breed> Pet_Breed { get; set; }
        public virtual DbSet<PET_OWNER> PET_OWNER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PET>()
                .Property(e => e.PetWeight)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Pet_Breed>()
                .Property(e => e.MinWeight)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Pet_Breed>()
                .Property(e => e.MaxWeight)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Pet_Breed>()
                .HasMany(e => e.PET)
                .WithRequired(e => e.Pet_Breed)
                .HasForeignKey(e => e.PetBreed)
                .WillCascadeOnDelete(false);
        }
    }
}
