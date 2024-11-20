using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie3; 

namespace prZadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tema func = new Tema();

            func.PrintMessage("Влад");

            Console.WriteLine($"Сумма  = {func.AddAndPrint(5, 5)}");

            int sum = func.AddIntegers(10, 5);
            Console.WriteLine($"Сумма 10 + 5 = {sum}");

            double average = func.CalculateAverage(25.5, 15.5);
            Console.WriteLine($"Среднее 25.5 и 15.5 = {average}");

            string greeting = func.GetGreeting("Влад Филатов ");
            Console.WriteLine(greeting);

            Console.ReadLine();

        }
    }
}
