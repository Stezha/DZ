namespace L3_oop
{
    internal class Overload
    {

        public void DisplayOverload(int a)
        {
            System.Console.WriteLine("DisplayOverload " + a);
        }

        public void DisplayOverload(string a)
        {
            System.Console.WriteLine("DisplayOverload " + a);
        }

        public void DisplayOverload(string a, int b)
        {
            System.Console.WriteLine("DisplayOverload " + a + b);
        }
    }
}
