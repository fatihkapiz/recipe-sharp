using Microsoft.EntityFrameworkCore;
using recipe_sharp_dotnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_sharp_dotnet.Data
{
    internal class recipeContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
        }
    }
}
