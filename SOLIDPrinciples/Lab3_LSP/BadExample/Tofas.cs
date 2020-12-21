using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Lab3_LSP.BadExample
{
    public class Tofas : Car
    {
        public override string OpenAirConditioning()
        {
            return null; //burda Null verdik aslında program patlamadı ama yapmamız gereken bu değil solid prensibine uymadık
        
        //tofas model arabanın klima özelliği olmayabilir
        }

        public override string Run()
        {
            return "Araba Çalıştı.";
        }
    }
}
