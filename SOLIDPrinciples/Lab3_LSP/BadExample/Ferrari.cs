using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Lab3_LSP.BadExample
{
    public class Ferrari : Car
    {
        public override string Run()
        {
            return "Araba Çalıştı.";
        }

        public override string OpenAirConditioning()
        {
            return "Klima açıldı.";
        }
    }
}
