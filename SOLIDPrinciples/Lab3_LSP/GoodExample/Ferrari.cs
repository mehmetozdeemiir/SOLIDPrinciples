using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Lab3_LSP.GoodExample
{
    public class Ferrari : Car, IAirConditionable
    {
        public string OpenAirConditioning()
        {
            return "Klima Çalıştı";
        }

        public override string Run()
        {
            return "Araba Çalıştı";
        }
    }
}
