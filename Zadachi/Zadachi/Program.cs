namespace Zadachi;

class Program
{

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введите натуральное число: ");
        string input = Console.ReadLine();

        if (!ulong.TryParse(input, out ulong number))
        {
            Console.WriteLine("Ошибка: введено не натуральное число.");
            return;
        }

        A.Execute(input);
        B.Execute(input);
        C.Execute(input);
        D.Execute(input);
        E.Execute(input);
        F.Execute(input);

    }
}