using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Lab4_ISP.BadExample
{
    public class Bad
    {
        public interface IWorker
        {
            void Work();
            void Eat();
        }
        public class Worker : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Az is yapar");
            }
            public void Eat()
            {
                Console.WriteLine("Az yemek yer");
            }
        }
        public class SuperWorker : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Cok is yapar");
            }
            public void Eat()
            {
                Console.WriteLine("Cok yemek yer");
            }
        }
        public class Manager
        {
            IWorker worker;
            public void SetWorker(IWorker w)
            {
                worker = w;
            }
            public void Manage()
            {
                worker.Work();
            }
        }
    }
}
