using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recipe_sharp_dotnet.Models
{
    internal class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Cuisine { get; set; }
        public int DifficultyLevel { get; set; }
        public int PreperationTime { get; set; }
        public int CookingTime { get; set; }
        public int Servings { get; set; }
        public int AuthorId { get; set; }

        public Recipe(string title, string description, string cuisine, int difficultyLevel,
        int preperationTime, int cookingTime, int servings, int authorId)
        {
            Title = title;
            Description = description;
            Cuisine = cuisine.ToLower();
            DifficultyLevel = difficultyLevel;
            PreperationTime = preperationTime;
            CookingTime = cookingTime;
            Servings = servings;
            AuthorId = authorId;
        }

        public Recipe(string name, string cuisine, string description)
        {
            Title = name;
            Cuisine = cuisine;
            Description = description;
        }

        public Recipe()
        {

        }
    }
}
