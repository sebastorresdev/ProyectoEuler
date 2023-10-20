/*
    # Reto #1 - Multiple of 3 or 5
    # Dificultad: Facil / Solucion: 11/09/2023
*/

/*
* Si enumeramos todos los números naturales a continuación que son múltiplos 
* de 3 o 5, obtenemos 3,5,6 y 9. La suma de estos múltiplos es 23.
* Encuentra la suma de todos los múltiplos de 3 o 5 abajo de 1000.
*/

namespace ConsoleApp;
internal class Program
{
    static void Main(string[] args)
    {
        int number = 1000;
        int sum = 0;
        for (int n = 0; n < number; n++)
            if (n % 3 == 0 || n % 5 == 0) sum += n;

        Console.WriteLine(sum);
    }
}