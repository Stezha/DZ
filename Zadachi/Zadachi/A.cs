namespace Zadachi
{
    internal class A
    {
        public static void Execute(string number)
        {
            int count = 0;
            foreach (char digit in number)
                if (digit == '3')
                    count++;

            Console.WriteLine($"а) Количество цифр 3: {count}");
        }
    }
}
