namespace PicnicBitesApp.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public int Servings { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string[] Ingredients { get; set; } = Array.Empty<string>();
        public string[] Instructions { get; set; } = Array.Empty<string>();

        public Recipe()
        {
        }

        public Recipe(int recipeId, string title, string description, int prepTime, int cookTime,
                      int servings, string imageUrl, string[] ingredients, string[] instructions)
        {
            RecipeId = recipeId;
            Title = title;
            Description = description;
            PrepTime = prepTime;
            CookTime = cookTime;
            Servings = servings;
            ImageUrl = imageUrl;
            Ingredients = ingredients;
            Instructions = instructions;
        }

        public string[] GetDetails()
        {
            return new string[]
            {
                Title,
                Description,
                $"Prep Time: {PrepTime} minutes",
                $"Cook Time: {CookTime} minutes",
                $"Servings: {Servings}"
            };
        }
    }
}