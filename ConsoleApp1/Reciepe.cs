using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Recipe
    {
        public int numberOfPitchers;
        public int removeLemonsFromInventory;
        public int removeSugarFromInventory;
        public int removeIceFromInventory;
        public int removeCupFromInventory;
        int lemonsForRecipe = 5;
        int sugarForRecipe = 5;
        int iceForRecipe = 20;
        public int cupsForRecipe = 10;
        public void ChooseRecipe()
        {
            Console.WriteLine("\n\nWe have a preset reciepe or you can use your own. \n\n");
            Console.WriteLine("The preset reciepe contains 5 lemons, 5 cups of sugar, 20 ice cubes making 10 cups of lemonade.\n\n");
            Console.WriteLine("Would you like to the preset recipe? [Y] or [N]");
            string userinput = Console.ReadLine().ToUpper();
            switch (userinput)
            {
                case "Y":
                    ChooseNumberOfPitchers();
                    break;
                case "N":
                    MakeCustomRecipeLemons();
                    MakeCustomRecipeSugar();
                    MakeCustomRecipeIce();
                    DisplayCustomRecipe();
                    ChooseNumberOfPitchers();
                    break;

                default:
                    Console.WriteLine("Sorry, that is not an option.");
                    break;
            }
        }
        public int ChooseNumberOfPitchers()
        {
            Console.WriteLine("Things to keep in mind:");
            Console.WriteLine("1. The weather (the hotter it is the more cups you may sell)");
            Console.WriteLine("2. You can not save unused lemonade you did not sell the previous day.\n\n");
            Console.WriteLine("How many pitchers do you want to make?");
            try
            {
                int numberOfPitchers = int.Parse(Console.ReadLine());
                this.numberOfPitchers = numberOfPitchers;
                return this.numberOfPitchers;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! You have to make less pitchers or run back to the store.");
                ChooseNumberOfPitchers();
                throw;
            }
        }

        public int MakeCustomRecipeLemons()
        {
            Console.WriteLine("Let's create your custom recipe:");
            Console.WriteLine("How many lemons would you like to add?");
            try
            {
                int lemonsForRecipe = int.Parse(Console.ReadLine());
                return this.lemonsForRecipe = lemonsForRecipe;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a vaild number");
                MakeCustomRecipeLemons();
                throw;
            }
        }
        public int MakeCustomRecipeSugar()
        {
            Console.WriteLine("How much sugar would you like to add?");
            try
            {
                int sugarForRecipe = int.Parse(Console.ReadLine());
                return this.sugarForRecipe = sugarForRecipe;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a vaild number");
                MakeCustomRecipeSugar();
                throw;
            }
        }
        public int MakeCustomRecipeIce()
        {
            Console.WriteLine("How much Ice would you like to add?");
            try
            {
                int iceForRecipe = int.Parse(Console.ReadLine());
                return this.iceForRecipe = iceForRecipe;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a vaild number");
                MakeCustomRecipeIce();
                throw;
            }
        }
        public void DisplayCustomRecipe()
        {
            Console.WriteLine("Your recipe consists of {0} lemons, {1} cups of sugar, {2} cubes of ice which makes {3} cups of lemonade!", lemonsForRecipe, sugarForRecipe, iceForRecipe, cupsForRecipe);
        }
        public int TakeLemonsOut()
        {
            try
            {
                removeLemonsFromInventory = numberOfPitchers * lemonsForRecipe;
                return removeLemonsFromInventory;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! You don't have enough lemons. Let's start this recipe over.\n\n");
                ChooseRecipe();
                throw;
            }

        }
        public int TakeSugarOut()
        {
            try
            {
                removeSugarFromInventory = numberOfPitchers * sugarForRecipe;
                return removeSugarFromInventory;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! You don't have enough sugar.Let's start this recipe over.\n\n");
                ChooseRecipe();
                throw;
            }

        }
        public int TakeIceOut()
        {
            try
            {
                removeIceFromInventory = numberOfPitchers * iceForRecipe;
                return removeIceFromInventory;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! You don't have enough ice. Let's start this recipe over.\n\n");
                ChooseRecipe();
                throw;
            }

        }
        public int TakeCupsOut()
        {
            try
            {
                removeCupFromInventory = numberOfPitchers * cupsForRecipe;
                return removeCupFromInventory;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! You don't have enough ice. Let's start this recipe over.\n\n");
                ChooseRecipe();
                throw;
            }
        }
    }
}
