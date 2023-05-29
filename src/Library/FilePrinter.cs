using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeDescription recipeDescription)
        {
            File.WriteAllText("Recipe.txt", recipeDescription.GetTextToPrint());
        }
    }
}