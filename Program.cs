using System;

namespace calculator_class
{
    class Program
    {
        static void Main(string[] args)
        {

            MathAction Caltulator = new MathAction();
            Console.WriteLine("Введите первое число");
            Caltulator._Hum_1();
            Console.WriteLine("Введите второе число");
            Caltulator._Hum_2();
            Console.WriteLine("Выберете действие из предложеннх: '+','-','*','/','Fact','Rest'.");
            Caltulator.MathAction_1();


        }
    }
}
