using System;
using IronPython.Hosting;
namespace TestingPython
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = Python.CreateEngine();
            dynamic py = engine.ExecuteFile(@"E:\RPA Calculator\TestingPython\TestingPython\calc.py");

            dynamic calc = py.Calculator();
            Console.WriteLine(calc.__class__.__name__);
            //write 'Calculator'

            double a = 7.5;
            double b = 2.5;
            double res;
            res = calc.add(a, b);
            Console.WriteLine("{0} + {1} = {2}", a, b, res);
            res = calc.sub(a, b);
            Console.WriteLine("{0} - {1} = {2}", a, b, res);
            Console.WriteLine("Press any key to finish...");
            Console.ReadLine();
        }
    }
}
