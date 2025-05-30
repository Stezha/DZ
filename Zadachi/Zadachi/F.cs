namespace Zadachi
{
    internal class F
    {
        public static void Execute(string number)
        {
            int count = 0;
            foreach (char digit in number)
                if (digit == '0' || digit == '5')
                    count++;

            Console.WriteLine($"е) Количество цифр 0 и 5: {count}");
        }
    }
}
