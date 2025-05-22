using L3_oop;


class Program
{
    static void Main(string[] args)
    {
        //Создаем экземпляр класса Rectangle
        Rectangle rec1 = new Rectangle(2, 4);
        //Выведим площадь прямоугольника
        System.Console.WriteLine("Площадь:" + rec1.s);
        //Выведим периметр прямоугольника
        System.Console.WriteLine("Периметр:" + rec1.getPerimeter());
        Overload overload = new Overload();
        overload.DisplayOverload(100);
        overload.DisplayOverload("method overloading");
        overload.DisplayOverload("method overloading", 100);
        Console.ReadKey();
    }



}

