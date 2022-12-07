namespace Character_Multiplier
{
    internal class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split();

            var firstString = strings[0];
            var secondString = strings[1];

            var sum = 0;

            var shorterLength = Math.Min(firstString.Length, secondString.Length);


            for (int i = 0; i < shorterLength; i++)
            {
                var firstLetter = firstString[i];
                var secondLetter = secondString[i];
                sum += firstLetter * secondLetter;
            }

            var longerString = firstString.Length > secondString.Length?  firstString : secondString;
            for (int i = shorterLength; i < longerString.Length; i++)
            {
                sum += longerString[i];
            }
            Console.WriteLine(sum);
        }
    }
}