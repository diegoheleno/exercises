using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Selecione o exercício: ");
            var input = Console.ReadLine();
            var index = int.Parse(input);
            var number = index < 10 ? $"0{index}" : $"{index}";

            Type type = Type.GetType($"exercises.Exercise{number}");
            var exercise = Activator.CreateInstance(type);

            Console.ReadKey();
        }
    }
}
