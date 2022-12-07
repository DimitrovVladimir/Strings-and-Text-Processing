using System.Numerics;
using System.Text;

namespace Convert_from_base_N_to_base_10
{
    internal class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();

            var @base = int.Parse(numbers[0]);
            var num = numbers[1].Reverse().ToArray();


            var sum = new BigInteger();

            for (int power = 0; power < num.Length; power++)
            {
                var currentNum = int.Parse(num[power].ToString());
                sum += currentNum* BigInteger.Pow(@base, power);
            }
            Console.WriteLine(sum);

        }
    }
}