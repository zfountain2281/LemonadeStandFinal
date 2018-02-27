using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cup : ICost

    {
        private double cupCost = .01;
        private string cupName;
        //public void setCupCost()
        //{
        //    cupCost = 0.05;
        //}
        public double GetCost()
        {
            return cupCost;
        }
        public void setCupName()
        {
            cupName = "Cups";
        }
        public string getCupName()
        {
            return cupName;
        }

    }
}
