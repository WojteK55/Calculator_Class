using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_class
{
    class MathAction
    {

        private float num_1;
        private float num_2;


        public float A()
        {
            return num_1;
        }
        public float B()
        {
            return num_2;
        }

        public void _Hum_1()
        {
            
            num_1 = float.Parse(Console.ReadLine());
            
        }

        public void _Hum_2()
        {
            
            num_2 = float.Parse(Console.ReadLine());
          
        }

        public static float Fact(ref float firstNum)
        {
            Console.WriteLine("Факториал какого числа вы хотите узнать?");
            int limit = int.Parse(Console.ReadLine());
            firstNum = 1;
            for (int i = 1; i <= limit; i++)
            {
                firstNum = firstNum * i;
            }
            return firstNum;
        }



        public float Sum()
        {
            float Sum = num_1 + num_2;
            Console.WriteLine($"Cумма равна {Sum}");
            return Sum;
        }
        public float Mines()
        {
            float Mines = num_1 - num_2;
            Console.WriteLine($"Разность равна {Mines}");
            return Mines;
        }
        public float Mulpty()
        {
            float Mulpty = num_1 * num_2;
            Console.WriteLine($"Произведение равно {Mulpty}");
            return Mulpty;
        }
        public float Divide()
        {
            float Divide = num_1 / num_2;
            Console.WriteLine($"Частное равно {Divide}");
            return Divide;
        }
        public void MathAction_1()
        {
            string Action = Console.ReadLine();
            switch (Action)
            {
                case "+":
                    Sum();
                    float resultSum = Sum();
                   
                    break;
                case "-":
                    Mines();
                    float resultMines = Mines();
                    break;
                case "*":
                    Mulpty();
                    float resultMulpty = Mulpty();
                    break;
                case "/":
                    Divide();
                    float resultDivide = Divide();

                    break;
               
                case "Fact":
                    Fact(ref num_1);
                    float resultFact = Fact(ref num_1);
                    Console.WriteLine(resultFact);
                    break;
                default:
                    break;
                case "Rest":
                    Rest();
                    float resultRest = Rest();
                    break;

            }

        }

      
        public float Rest()
        {
            float intnum = num_1 / num_2;
            int _num_1 = Convert.ToInt32(num_1);
            int _num_2 = Convert.ToInt32(num_2);
            int _intnum = _num_1 / _num_2;
            float Rest = intnum - _intnum;
            Console.WriteLine($"остаток от деления равен {Rest}");
            return Rest;

        }





    }
}
