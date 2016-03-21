using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge
{
    public class ElectricCar : Vehicle
    {
        public ElectricCar(string make, string model) : base(make, model)
        {

        }

        public int NumOfGears { get; set; } = 1;
        public int NumOfTires { get; set; } = 4;

        public override string ToString()
        {
            return $"This is a {Make} {Model}";
        }
    }
}
