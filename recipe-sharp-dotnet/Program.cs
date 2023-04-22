using System;
using System.Collections.Generic;

namespace recipe_sharp
{
    class Program
    {
        public static void Main(string[] args)
        { 
            
        }
    }
    /*
    public class RecipeApp {
        public List<Recipe> recipes;
        public List<Rating> ratings;
        public List <Ingredient> ingredients;

        public RecipeApp() {
            recipes = new List<Recipe>();
            ratings = new List<Rating>();
            ingredients = new List<Ingredient>();
        }

        // maybe add extra checks ensure uniqueness 
        public void CreateRecipe(Recipe recipe) {
            recipe.Id = recipes.Count + 1; // we can delete this when we are working with the database and id is already always unique, just for testing purposes
            recipes.Add(recipe); 
        }
        public void CreateRating(Rating rating) {
            ratings.Add(rating);
        }

        public void CreateIngredient(Ingredient ingredient) {
            ingredients.Add(ingredient);
        }

        public Ingredient ReadIngredient(int id) {
            return ingredients.Find(ingredient => ingredient.Id == id); // possible null return, check this, maybe throw an exception
        }

        public Rating ReadRating(int id) {
            return ratings.Find(rating => rating.Id == id); // possible null return, check this, maybe throw an exception
        }

        public Recipe ReadRecipe(int id) {
            return recipes.Find(recipe => recipe.Id == id); // possible null return, check this, maybe throw an exception
        }

        // FINDS THE INDEX THEN UPDATES THE RECIPE, RETURNS -1 ON FAIL, 0 ON SUCCESS 
        public void UpdateRecipe(int id, Recipe updatedRecipe)
        {
            int index = recipes.FindIndex(recipe => recipe.Id == id);
            if (index != -1)
            {
                recipes[index] = updatedRecipe;
            }
        }

        // FINDS THE INDEX THEN UPDATES THE RATING, RETURNS -1 ON FAIL, 0 ON SUCCESS 
        public int UpdateRating(Rating rating) {
            int index = ratings.FindIndex(x => x.Id == rating.Id);
            
            if (index == -1) {
                return -1;
            }
            ratings[index] = rating;
            return 0;
        }

        // FINDS THE INDEX THEN UPDATES THE INGREDIENT, RETURNS -1 ON FAIL, 0 ON SUCCESS 
        public int UpdateIngredient(Ingredient ingredient) {
            int index = ingredients.FindIndex(x => x.Id == ingredient.Id);
            
            if (index == -1) {
                return -1;
            }
            ingredients[index] = ingredient;
            return 0;
        }

        public int DeleteRecipe(int id) {
            int index = recipes.FindIndex(r => r.Id == id);
            if (index == -1) return -1;
            recipes.RemoveAt(index);
            return 0;
        }

        public int DeleteRating(int id) {
            int index = ratings.FindIndex(r => r.Id == id);
            if (index == -1) return -1;
            ratings.RemoveAt(index);
            return 0;
        }

        public int DeleteIngredients(int id) {
            int index = ingredients.FindIndex(r => r.Id == id);
            if (index == -1) return -1;
            ingredients.RemoveAt(index);
            return 0;
        }

        public List<Recipe> SearchCuisine(String cuisine) {
            return recipes.FindAll(recipe => recipe.Cuisine.ToLower() == cuisine.ToLower());
        }*/
    /*
    public class Recipe {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Cuisine { get; set; }
        public int DifficultyLevel { get; set; }
        public int PreperationTime { get; set; }
        public int CookingTime { get; set; }
        public int Servings { get; set; }
        public int AuthorId { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Recipe(string title, string description, string cuisine, int difficultyLevel,
        int preperationTime, int cookingTime, int servings, int authorId, List<Ingredient> ingredients) 
        {
            Title = title;
            Description = description;
            Cuisine = cuisine.ToLower();
            DifficultyLevel = difficultyLevel;
            PreperationTime = preperationTime;
            CookingTime = cookingTime;
            Servings = servings;
            AuthorId = authorId;
            Ingredients = ingredients ?? new List<Ingredient>();
        }

        public Recipe(string name, string cuisine, string description)
        {
            Title = name;
            Cuisine = cuisine;
            Description = description;
            Ingredients = new List<Ingredient>();
        }

        public Recipe() {
            Ingredients = new List<Ingredient>();
        }
    }*/
    /*
    public class Rating {
        public int Id { get; set; }
        public int Value { get; set; }
        public int RecipeId { get; set; } 

        public Rating(int id, int value, int recipe_id) {
            Id = id;
            Value = value;
            RecipeId = recipe_id;
        }
    }
    */
    /*
    public class Ingredient {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int RecipeId { get; set; }

        public Ingredient(int id, string name, int quantity, string unit, int recipe_id) {
            Id = id;
            Name = name;
            Quantity = quantity;
            Unit = unit;
            RecipeId = recipe_id;
        }
    }
    */
}