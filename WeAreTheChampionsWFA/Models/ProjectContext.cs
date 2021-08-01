using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampionsWFA.Models
{
    public class ProjectContext : DbContext
    {
       
        public ProjectContext() : base("name=ConnectionSentence")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ProjectContext>());
      
        }


        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Color> Colors { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Team>().HasMany(i => i.Team1).WithRequired().WillCascadeOnDelete(false);
        //    modelBuilder.Entity<Team>().HasMany(i => i.Team2).WithRequired().WillCascadeOnDelete(false);
        //}

    }
}
