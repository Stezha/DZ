namespace Zadachi
{
    internal class B
    {
        public static void Execute(string number)
        {
            char lastDigit = number[number.Length - 1];
            int count = 0;
            foreach (char digit in number)
                if (digit == lastDigit)
                    count++;

            Console.WriteLine($"б) Цифра {lastDigit} встречается {count} раз(а)");
        }
    }
}
