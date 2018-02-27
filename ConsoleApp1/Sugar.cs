using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sugar : ICost
    {
        double sugarCost = .10;
        string sugarName;
        //public void setSugarCost()
        //{
        //    sugarCost = 0.50;
        //}
        public double GetCost()
        {
            return sugarCost;
        }
        public void setSugarName()
        {
            sugarName = "Sugar";
        }
        public string getSugarName()
        {
            return sugarName;
        }
    }
}
