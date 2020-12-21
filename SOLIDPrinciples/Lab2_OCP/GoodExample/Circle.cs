using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Lab2_OCP.GoodExample
{
    public class Circle : Shape
    {
        public double Radius { get; set; }


        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
