using System;

namespace Demo.Vs2019Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteMain();
        }

        private static void WriteMain()
        {
            var result = new DataGenerator().Generate(50);

            result.ForEach(dataDemo =>
            {
                Console.WriteLine($"Ingrese el nuevo valor para {dataDemo.Key}");
                dataDemo.ChangeValue(Console.ReadLine());
            });
        }
    }
}
