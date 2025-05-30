namespace Zadachi
{
    internal class C
    {
        public static void Execute(string number)
        {
            int count = 0;
            foreach (char digit in number)
                if ((digit - '0') % 2 == 0)
                    count++;

            Console.WriteLine($"в) Количество чётных цифр: {count}");
        }
    }
}
