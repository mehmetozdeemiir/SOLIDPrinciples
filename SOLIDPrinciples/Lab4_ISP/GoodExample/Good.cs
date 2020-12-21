using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Lab4_ISP.GoodExample
{
    public class Good
    {
        public interface IWorkable
        {
            void Work();
        }
        public interface IFeedable
        {
            void Eat();
        }
        public class Worker : IWorkable, IFeedable
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
        public class SuperWorker : IWorkable, IFeedable
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
        public class Robot : IWorkable
        {
            public void Work()
            {
                Console.WriteLine("Cok fazla is yapar, yemek yemez");
            }
        }
        public class Manager
        {
            IWorkable worker;
            public void SetWorker(IWorkable w)
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
