namespace OmerSeyfettinApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OmerSeyfettinAppDb : DbContext
    {
        public OmerSeyfettinAppDb()
            : base("name=OmerSeyfettinAppDb")
        {
        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
      
        //  public virtual DbSet<DataHelper> DataHelper { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        //  [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
        modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

     
        //  [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
        modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);


        //  [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
        modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

        }
    }
}
