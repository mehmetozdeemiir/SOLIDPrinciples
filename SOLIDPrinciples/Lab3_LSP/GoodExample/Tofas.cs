using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Lab3_LSP.GoodExample
{
    public class Tofas : Car
    {
        public override string Run()
        {
            return "Araba Çalıştı.";
        }
    }
}
//Klima özelliğini sadece Ferrari için implement ettiğimizden dolayı, hiç kimse tofaş için OpenAirConditioning 
//metotuna erişemiyecek ve herhangi bir problem ile karşılaşılmayacaktır.