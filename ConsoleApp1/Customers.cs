using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Customers
    {
        Random random;
        double percent= 100;
        public int numberOfCupsToBuy;
        double initialChanceToBuy;
        double chanceToBuy;
        double temperatureProbability;
        double conditionProbability;
        double costProbability;
        public double willPayMax;
        public bool buy;

        public Customers(double WillPayMax, int NumberOfCupsToBuy)
        {
            willPayMax = WillPayMax;
            numberOfCupsToBuy = NumberOfCupsToBuy;
            random = new Random();
            initialChanceToBuy = random.Next(40, 61);
        }
        public void ChanceToBuyTemperature(Weather weather)
        {
            if (weather.temperature <= 70)
            {
                temperatureProbability=percent * 1.15;
            }
            else if (weather.temperature >= 80)
            {
                temperatureProbability = percent * 1.50;
            }
        }
        public void ChanceToBuyCondtion(Weather weather)
        {
            if (weather.condition == "sunny")
            {
                conditionProbability = percent * 1.85;
            }
            else if (weather.condition == "cloudy" || weather.condition == "partly cloudy")
            {
                conditionProbability = percent * 1.45;
            }
            else if (weather.condition == "rainy" || weather.condition == "foggy")
            {
                conditionProbability = percent * 1.15;
            }
        }
        public void ChanceToBuyCost(Day day)
        {
            if (day.willingToPay == .25)
            {
                costProbability = percent * 1.100;
            }
            else if (day.willingToPay == .75)
            {
                costProbability = percent * 1.87;
            }
            else if (day.willingToPay == .90 || day.willingToPay == 1.00)
            {
                costProbability = percent * 1.70;
            }
            else if (day.willingToPay == 1.25)
            {
                costProbability = percent * .50;
            }
        }

        public double WillBuy()
        {
            List<double> actualChanceToBuy = new List<double>();
            actualChanceToBuy.Add(temperatureProbability);
            actualChanceToBuy.Add(conditionProbability);
            actualChanceToBuy.Add(costProbability);
            actualChanceToBuy.Add(initialChanceToBuy);
            double chanceTobuy = actualChanceToBuy.Average();
            this.chanceToBuy = chanceTobuy;
            return this.chanceToBuy;
        }

        public bool CustomerBuysLemonade(int randomValue)
        {
            // use randomValue instead of value
            if (chanceToBuy <= randomValue)
            {
                buy = false;
            }
            else
            {
                buy = true;
            }
            return this.buy;
        }

        public void DeterminesCustomerBuys(Weather weather, Day day, int randomValue) 
        {
            ChanceToBuyTemperature(weather);
            ChanceToBuyCondtion(weather);
            ChanceToBuyCost(day);
            WillBuy();
            CustomerBuysLemonade(randomValue);
        }
    }
}
