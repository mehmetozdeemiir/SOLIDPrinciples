using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Lab2_OCP.BadExample
{
    public class AreaCalculator
    {
        public double Area(Rectangle[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Width * shape.Height;
            }
            return area;

        }
    }
}
//Evet her şey oldukça güzel görünüyor değil mi? Rectangle’ın alanını hesaplayabiliyoruz.Peki müşterimizden 
//gelen bir istek ile Circle(Daire)’ında alanını hesaplamak istediğini belirtti bize.
//Aklımıza gelen ilk şey olarak artık Rectangle tipinde bir dizi yerine object tipinde dizi tanımlayarak bunu da ufak
//bir if else bloğuna sokarak bir type kontrolü ile halledebiliriz sanırım

/*          public class AreaCalculator
    {
        public double Area(object[] shapes)
    {
        double area=0;
        foreach(var shape in shapes)
        {
            if(shape is Retangle)
            {
                Rectangle rec=(Rectangle)shape;
                area+=rec.Width* rec.Height;
            }
            else
            {

                Circle circ=(Circle)shape;
                 area+=circ.Radius* circ.Radius*Math.PI;
         }
         }

                return area;
            }

*/


/*Şuan için yine oldukça güzel duruyor  Sanırım müşterimizin isteğini yerine getirmiş olduk ve artık Circle’ın da alanını hesaplayabiliyoruz.
Her şey güzel gidiyor derken müşterimizden gelen bir haber ile tekrar bir yeni isteği olduğunu belirtiyor. 
Bu seferde Triangles (Üçgen) için bir alan hesaplamak istiyor. Elbette bunu 
hesaplamak çok zor değil fakat yine kodumuzda değişiklikler gerekiyor.
Git gide open-closed’a karşı bir yapı kuruyoruz. Gelişime açık, değişime kapalı olmamız
gerekirken sürekli kodumuzu değiştiriyoruz. Bu duruma hemen open-closed prensibine uygun bir yaklaşımla
bakarsak AreaCalculator class’ımız değişime kapalı değildir aksine yeni istek için sürekli değiştirmemiz gerekmektedir.
*/  
