using System.Numerics;
using System.Text;

namespace Conver_from_base_10_to_base_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();

            var @base = int.Parse(numbers[0]);
            var num = BigInteger.Parse(numbers[1]);

            var result = new StringBuilder();
            while (num > 0)
            {
                var remainder = num % @base;
                result.Append(remainder);
                num /= @base;

            }
            var reversedResult =new string( result.ToString().Reverse().ToArray());

            Console.WriteLine(reversedResult);
        }
    }
}