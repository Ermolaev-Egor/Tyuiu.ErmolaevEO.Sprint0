using Tyuiu.ErmolaevEO.Sprint0.Task7.V0.Lib;

namespace Tyuiu.ErmolaevEO.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Ермолаев Е. О. | ИБКСб-26-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Ермолаев Егор Олегович | ИБКСб-26-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух    *");
            Console.WriteLine("* одиныковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arrauNums1 = new int[] {1, 2, 3, 4, 5};

            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < arrauNums1.Length; i++)
            {
                Console.Write(arrauNums1[i]+ ", ");
            }

            Console.WriteLine();

            int[] arrauNums2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < arrauNums2.Length; i++)
            {
                Console.Write(arrauNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (arrauNums1.Length == arrauNums2.Length)
            {
                int[] resulArray = DataService.AdditionArrays(arrauNums1 , arrauNums2);
                Console.WriteLine("Сумма элементов массива равна:");
                for (int i = 0;i < resulArray.Length;i++ )
                {
                    Console.Write(resulArray[i] + ", ");
                }
                
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey();
        }
    }
}
