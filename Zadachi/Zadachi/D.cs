namespace Zadachi
{
    internal class D
    {
        public static void Execute(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                int d = digit - '0';
                if (d > 5)
                    sum += d;
            }

            Console.WriteLine($"г) Сумма цифр больше 5: {sum}");
        }
    }
}
