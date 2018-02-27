using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ice : ICost
    {
        double iceCost = .01;
        string iceName;
        //public void setIceCost()
        //{
        //    iceCost = 0.05;
        //}
        public double GetCost()
        {
            return iceCost;
        }
        public void setIceName()
        {
            iceName = "Ice";
        }
        public string getIceName()
        {
            return iceName;
        }
    }
}
