namespace Letters_Change_Numbers
{
    internal class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var sum = 0d;


            foreach(var str in strings)
            {
                var firstLetter = str.First();
                var lastLetter = str.Last();

                var number = double.Parse(str.Substring(1, str.Length -2));

               if (char.IsUpper(firstLetter))
                {
                    int charPosition = firstLetter - ('A' - 1);
                    number /= charPosition;
                }
                else
                {
                    number*= firstLetter - ('a' - 1);
                }
               if(char.IsUpper(lastLetter))
                {
                    number -= lastLetter- ('A' - 1);
                }
                else
                {
                    number+= lastLetter - ('a' - 1);
                }
                sum += number;
            }
            Console.WriteLine($"{0:F2}", sum);
        }
    }
}