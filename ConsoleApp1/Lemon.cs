using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Lemon : ICost
    {
        private double lemonCost = .05;
        private string lemonName;
        //public void setLemonCost()
        //{
        //    lemonCost = 0.10;
        //}
        public double GetCost()
        {
            return lemonCost;
        }
        public void setLemonName()
        {
            lemonName = "Lemon";
        }
        public string getLemonName()
        {
            return lemonName;
        }
    }
}
