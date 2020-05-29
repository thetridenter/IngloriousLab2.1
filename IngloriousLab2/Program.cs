using System;

namespace IngloriousLab2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть номер квартири (1-45)");
            int num = Convert.ToInt32(Console.ReadLine());

            int flag;
            if (num >= 1 && num <= 5)
            { 
                flag = 1;
            }
            else if (num > 5 && num <= 10)
            {
                flag = 2;
            }
            else if (num > 10 && num <= 15)
            {
                flag = 3;
            }
            else if (num > 15 && num <= 20)
            {
                flag = 4;
            }
            else if (num > 20 && num <= 25)
            {
                flag = 5;
            }
            else if (num > 25 && num <= 30)
            {
                flag = 6;
            }
            else if (num > 30 && num <= 35)
            {
                flag = 7;
            }
            else if (num > 35 && num <= 40)
            {
                flag = 8;
            }
            else
            {
                flag = 9;
            }



            switch (flag)
            {
                case 1:
                    Console.WriteLine("Квартира розташована на 1-ому поверсі");
                    break;

                case 2:
                    Console.WriteLine("Квартира розташована на 2-ому поверсі");
                    break;

                case 3:
                    Console.WriteLine("Квартира розташована на 3-ому поверсі");
                    break;

                case 4:
                    Console.WriteLine("Квартира розташована на 4-ому поверсі");
                    break;

                case 5:
                    Console.WriteLine("Квартира розташована на 5-ому поверсі");
                    break;

                case 6:
                    Console.WriteLine("Квартира розташована на 6-ому поверсі");
                    break;

                case 7:
                    Console.WriteLine("Квартира розташована на 7-ому поверсі");
                    break;
                case 8:
                    Console.WriteLine("Квартира розташована на 8-ому поверсі");
                    break;

                case 9:
                    Console.WriteLine("Квартира розташована на 9-ому поверсі");
                    break;
            }
        }
    }
}
