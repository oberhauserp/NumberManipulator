using System;

namespace NumberManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string entered = Console.ReadLine();
            int castedenter = 0;
            Int32.TryParse(entered, out castedenter);
            int answer = Math.Pow(castedenter, 2) + 14 - 3;
            Console.WriteLine(answer);
        }
    }
}
