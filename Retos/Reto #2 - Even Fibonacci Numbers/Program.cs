/*
    # Reto #2 - Even Fibonacci Numbers
    # Dificultad: Facil / Solucion: 11/09/2023
*/

/*
* Cada nuevo término en la secuencia de Fibonacci se genera sumando los dos 
* términos anteriores. Al comenzar con 1 y 2, los primeros 10 términos serán:
* 1,2,3,5,8,13,21,34,55,89,...
* Considerando los términos de la secuencia de Fibonacci cuyos valores no superan 
* los cuatro millones, encuentre la suma de los términos pares.
*/

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int sum = a + b;
            int sumPar = 0;
            while(sum < 4000000)
            {
                if (sum % 2 == 0) sumPar += sum;
                a = b;
                b = sum;
                sum = a + b;
            }
            Console.WriteLine(sumPar);
        }
    }
}