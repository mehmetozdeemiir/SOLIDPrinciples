using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Lab2_OCP.GoodExample
{
    public class AreaCalculator
    {
        public double Area(Shape[] shapes) 
        
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        
        }
    }
}

//Artık her ne kadar farklı hesaplama ve şekil isteği gelse de biliyoruz ki bizim için farketmez, kolaylıkla metodumuzu genişletebiliriz.