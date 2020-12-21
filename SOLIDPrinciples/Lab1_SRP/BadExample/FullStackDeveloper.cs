using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Lab1_SRP.BadExample
{
   public class FullStackDeveloper
    {

        public void WriteCSharpCode()
        {
            Console.WriteLine("I can write C#.");
        }

        public void WriteSQLCode()
        {
            Console.WriteLine("I can write SQL.");
        }

        public void WriteJavaScriptCode()
        {
            Console.WriteLine("I can write JavaScript.");
        }

        public void WriteCSSCode()
        {
            Console.WriteLine("I can write CSS.");
        }

        //“FullStackDeveloper” sınıfımız C#, SQL, JavaScript ve CSS kodu yazabilen bir yazılım geliştiricisini temsil etsin. 
        //Tek bir geliştiriciye bu kadar işin yüklenmesi geliştiricinin hata yapma olasılığını yükseltecektir. Çünkü, bir 
        //yerden sonra kafa çorbası içilmeye hazır hale gelecektir.
    }
}
