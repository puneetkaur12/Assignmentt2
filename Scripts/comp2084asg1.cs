namespace WebApplication1.Scripts
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class comp2084asg1 : DbContext
    {
        public comp2084asg1()
            : base("name=DefaultConnections")
        {
        }

        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<table2> table2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_1>()
                .Property(e => e.subsid)
                .IsUnicode(false);

            modelBuilder.Entity<table2>()
                .Property(e => e.subs)
                .IsUnicode(false);

            modelBuilder.Entity<table2>()
                .Property(e => e.topings)
                .IsUnicode(false);

            modelBuilder.Entity<table2>()
                .Property(e => e.size)
                .IsUnicode(false);
        }
    }
}
