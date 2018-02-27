using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Day
    {
        public Weather weather;
        public Customers customer;
        int customersThoughoutDay = 50;
        public double stopSelling;
        Random random;
        int userInput;
        double moneyEarned;
        double sale;
        public double willingToPay;
        int cupsToBeBought;
        double pricePerCup;
        public List<Customers> customers = new List<Customers>();
        List<double> costCustomersWillPay = new List<double> { .25, 1.00, .75, .90, 1.25 };
        List<int> cupsCustomersWillBuy = new List<int> { 1, 2, 1, 3, 1 };
        public Day(Random random)
        {
            weather = new Weather(random);
            this.random = random;
        }
        public double PriceOfCup()
        {
            Console.WriteLine("Before we start the day, please set the cost for 1 cup of lemonade:");
            try
            {
                double pricePerCup = double.Parse(Console.ReadLine());
                this.pricePerCup = pricePerCup;
                return this.pricePerCup;
            }
            catch (Exception)
            {
                Console.WriteLine("Oops! Something's not right. Try selling a cup for $0.25 or $1.00.");
                PriceOfCup();
                throw;
            }
        }

        public double PayingCustomers()
        {
            int customersWillingToPay = random.Next(0, costCustomersWillPay.Count);
            willingToPay = costCustomersWillPay[customersWillingToPay];
            return willingToPay;

        }
        public int CustomersWillingnessToBuy()
        {
            int howManyCupsWillBeBought = random.Next(0, cupsCustomersWillBuy.Count);
            cupsToBeBought = cupsCustomersWillBuy[howManyCupsWillBeBought];
            return cupsToBeBought;
        }

        public void CreateCustomers()
        {
            for (int i = 0; i < customersThoughoutDay; i++)
            {
                int numberOfCups = CustomersWillingnessToBuy();
                double amountToPay = PayingCustomers();
                Customers customer = new Customers(amountToPay, numberOfCups);
                customers.Add(customer);
            }
        }

        public double SellLemonade(Player player)
        {
            for (int i = 0; i < stopSelling; i++)
            {
                if (customers[i].buy == true)
                {
                    sale = pricePerCup;
                    player.wallet.moneyInWallet += sale;
                    moneyEarned = sale * stopSelling;
                }
            }
            Console.WriteLine("You earned {0}!", moneyEarned);
            return player.wallet.moneyInWallet;
        }
        public void CalculatingWhenToStopSelling(Player player)
        {
            stopSelling = player.recipe.cupsForRecipe * player.recipe.numberOfPitchers;
        }
    }
}
