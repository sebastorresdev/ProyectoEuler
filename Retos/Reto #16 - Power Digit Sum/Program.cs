# SOLUCION 1 - Usando BigInteger

using System.Numerics;

int sum = 0;

var pow = BigInteger.Pow(2, 1000).ToString();

for (int d = 0; d < pow.Length; d++)
    sum += Convert.ToChar(pow[d]) - 48;

Console.WriteLine(sum);


// # SOLUCION 2 - Usando List

// static int CalculatePow(int pow)
// {
//     var number = new List<int> { 1 };
//     int carry = 0;

//     for (int i = 0; i < pow; i++)
//     {
//         number = number.Select(d =>
//         {
//             var tmp = d * 2 + carry;
//             if (tmp > 9)
//             {
//                 carry = tmp / 10;
//                 return tmp % 10;
//             }
//             carry = 0;
//             return tmp;
//         }).ToList();

//         if (carry > 0)
//         {
//             number.Add(carry);
//             carry = 0;
//         }
//     }
//     return number.Sum(d => d);
// }

// Console.WriteLine(CalculatePow(1000));