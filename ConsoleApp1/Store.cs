using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Store
    {
        double checkOutLemons;
        double checkOutIceCubes;
        double checkOutSugar;
        double checkOutCups;

        //double lemonNeeded;
        public void Restock(Player player)
        {

            Console.WriteLine("What's on your list? [L] for Lemons, [S] for Sugar, [I] for Ice, [C] for Cups, or hit [ENTER] to take you back to the Main Menu. \n\n");

            string need = Console.ReadLine().ToLower();
            switch (need)
            {
                case "l":
                    GetLemons(player);
                    break;
                case "s":
                    GetSugar(player);
                    break;
                case "i":
                    GetIce(player);
                    break;
                case "c":
                    GetCups(player);
                    break;
                //case "m":
                //    
                //    break;
                default:
                    //Console.WriteLine("Sorry! Try [L] for Lemons, [S] for Sugar, [I] for Ice, [C] for Cups, or [ENTER] to take you back to the Main Menu.");
                    //Restock(player);
                    break;

            }
        }
        //lemons
        public int NumberOfLemonsNeeded(Player player)
        {
            Console.WriteLine("Lemons are 5 cents each.\n\n");
            Console.WriteLine("How many lemons would you like?\n\n");
            try
            {
                int lemonsNeeded = int.Parse(Console.ReadLine());
                return lemonsNeeded;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Try a number next time.\n\n");
                Restock(player);
                throw;
            }

        }

        public double NumberOfLemonsPurchased(int NumberOfLemonsToBuy)
        {
            Lemon lemon = new Lemon();
            checkOutLemons = lemon.GetCost() * NumberOfLemonsToBuy;
            return checkOutLemons;
        }
        public void PayForLemons(Player player)
        {
            if (player.wallet.checkIfBankrupt(checkOutLemons))
            {
                Restock(player);
            }
            else
            {
                player.wallet.buyProduct(checkOutLemons);
            }
        }
        //Calling Lemons
        public void GetLemons(Player player)
        {
            int numberOfLemons = NumberOfLemonsNeeded(player);
            NumberOfLemonsPurchased(numberOfLemons);
            PayForLemons(player);
            player.inventory.AddLemons(numberOfLemons);
            Console.WriteLine("\n\n");
            Restock(player);
        }
        public int NumberOfSugarNeeded(Player player)
        {
            Console.WriteLine("Each cup of sugar is 10 cents each.\n\n");
            Console.WriteLine("How many cups of sugar would you like?\n\n");
            try
            {
                int sugarNeeded = int.Parse(Console.ReadLine());
                return sugarNeeded;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Try a number next time.\n\n");
                Restock(player);
                throw;
            }

        }
        public double NumberOfSugarPurchased(int NumberOfSugarNeeded)
        {
            Sugar sugar = new Sugar();
            checkOutSugar = sugar.GetCost() * NumberOfSugarNeeded;
            return checkOutSugar;
        }
        public void PayForSugar(Player player)
        {
            if (player.wallet.checkIfBankrupt(checkOutSugar))
            {
                Restock(player);
            }
            else
            {
                player.wallet.buyProduct(checkOutSugar);
            }
        }
        //Calling Sugar
        public void GetSugar(Player player)
        {
            int numberOfSugar = NumberOfSugarNeeded(player);
            NumberOfSugarPurchased(numberOfSugar);
            PayForSugar(player);
            player.inventory.AddSugar(numberOfSugar);
            Restock(player);
        }
        //ice
        public int NumberOfIceCubesNeeded(Player player)
        {
            Console.WriteLine("Ice Cubes are 1 cents each.\n\n");
            Console.WriteLine("How many ice cubes would you like?\n\n");
            try
            {
                int iceNeeded = int.Parse(Console.ReadLine());
                return iceNeeded;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Try a number next time.\n\n");
                Restock(player);
                throw;
            }

        }

        public double NumberOfIceCubesPurchased(int NumberOfIceCubesNeeded)
        {
            Ice ice = new Ice();
            checkOutIceCubes = ice.GetCost() * NumberOfIceCubesNeeded;
            return checkOutIceCubes;
        }
        public void PayForIce(Player player)
        {
            if (player.wallet.checkIfBankrupt(checkOutIceCubes))
            {
                Restock(player);
            }
            else
            {
                player.wallet.buyProduct(checkOutIceCubes);
            }
        }

        //Calling Ice
        public void GetIce(Player player)
        {
            int numberOfIce = NumberOfIceCubesNeeded(player);
            NumberOfIceCubesPurchased(numberOfIce);
            PayForIce(player);
            player.inventory.AddIce(numberOfIce);
            Restock(player);
        }

        //Cups
        public int NumberOfCupsNeeded(Player player)
        {
            Console.WriteLine("Each cup is 3 cents each.\n\n");
            Console.WriteLine("How many cups would you like?\n\n");
            try
            {
                int cupsNeeded = int.Parse(Console.ReadLine());
                return cupsNeeded;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Try a number next time.\n\n");
                Restock(player);
                throw;
            }
        }
        public double NumberOfCupsPurchased(int NumberOfCupsNeeded)
        {
            Cup cup = new Cup();
            checkOutCups = cup.GetCost() * NumberOfCupsNeeded;
            return checkOutCups;
        }
        public void PayForCups(Player player)
        {
            if (player.wallet.checkIfBankrupt(checkOutCups))
            {
                Restock(player);
            }
            else
            {
                player.wallet.buyProduct(checkOutCups);
            }
        }
        //calling Cups
        public void GetCups(Player player)
        {
            int numberOfCups = NumberOfCupsNeeded(player);
            NumberOfCupsPurchased(numberOfCups);
            PayForCups(player);
            player.inventory.AddCups(numberOfCups);
            Restock(player);
        }
    }
}
