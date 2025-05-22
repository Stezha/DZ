namespace L3_oop
{
    internal class Rectangle
    {
        //Свойства обьекта
        private double a;//катет1
        private double b;//катет2
        public double s; //площадь

        public double h()
        {
            return Math.Sqrt(a * a + b * b);
        }



        //конструктор класса
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.s = 0.5 * a * b;
        }
        //Метод возвращающий периметр треугольника
        public double getPerimeter()
        {
            return a + b + h();
        }

    }
}
