using Ayesha1281246.Factrories;
using Ayesha1281246.Tests;
using Ayesha1281246.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ayesha1281246
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Test 1: Consturctor injections");
            Console.WriteLine("*******************************");
            Test1 s1 = new Test1(new RepositoryFactoryImpl());
            s1.Run();
            Console.WriteLine("///////////////////Test 1////////////");
            Console.WriteLine("Test 2: Injection in method");
            Console.WriteLine("*******************************");
            Test2 t1 = new Test2();
            t1.Run(new RepositoryFactoryImpl());
            Console.WriteLine("///////////////////Test 2////////////");
            Console.WriteLine("Test 3: Repository injection");
            Console.WriteLine("*******************************");
            IRepositoryFactory factory = new RepositoryFactoryImpl();
            Test3 s2 = new Test3(factory.GetRepo<students>());
            s2.run();
            Test4 t2 = new Test4();
            t2.Run(factory.GetRepo<Teachers>());
            Console.WriteLine("///////////////////Test 3////////////");
            Console.ReadLine();
        }
    }
}
