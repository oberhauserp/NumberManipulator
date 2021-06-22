using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string entered = Console.ReadLine();
            double castedenter = Convert.ToDouble(entered);
            double answer = Math.Pow(castedenter, 2) + 14 - 3;
            Console.WriteLine(answer);
        }
    }
}
