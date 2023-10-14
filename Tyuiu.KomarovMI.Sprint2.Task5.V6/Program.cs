using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovMI.Sprint2.Task5.V6.Lib;

namespace Tyuiu.KomarovMI.Sprint2.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Комаров М.И. | ПКТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #2                                                                *");
            Console.WriteLine("* Тема:                                                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Комаров Максим Игоревич | ПКТБ-23-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
            Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите порядковый номер карты:");
            int numName = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер достоинства карты:");
            int numValue = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numName < 1) || (numName > 4))
            {
                res=("Неверное значение порядкового номера");
            }
            else
            {
                if ((numValue < 6) || (numValue > 14))
                {
                    res=("Неверное значение достоинтсва карты");
                }
                else
                {
                    res = ds.FindCardNameAndValue(numName, numValue);
                }

            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
