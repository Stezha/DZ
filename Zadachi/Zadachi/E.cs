namespace Zadachi
{
    internal class E
    {
        public static void Execute(string number)
        {
            int product = 1;
            bool hasValid = false;
            foreach (char digit in number)
            {
                int d = digit - '0';
                if (d > 7)
                {
                    product *= d;
                    hasValid = true;
                }
            }

            Console.WriteLine($"д) Произведение цифр больше 7: {(hasValid ? product : 0)}");
        }
    }
}