
using System;

namespace TabuadaComFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Digite o número que você quer para a tabuada");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
            {
                Console.WriteLine($"{n1} X {multiplicador} = {n1*multiplicador} ");
            }
        }
    }
}
