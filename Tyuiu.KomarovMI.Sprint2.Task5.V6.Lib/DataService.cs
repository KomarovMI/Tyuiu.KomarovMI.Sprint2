using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KomarovMI.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res;
            switch (value1)
            {
                case 1:
                    res=("Пики ");
                    break;
                case 2:
                    res = ("Трефы ");
                    break;
                case 3:
                    res = ("Бубны ");
                    break;
                case 4:
                    res = ("Червы ");
                    break;
                default:
                    throw new ArgumentException($"Не может быть такого числа, введите от 1 до 4. Значение {value1}");
            }
            

            switch (value2)
            {
                case 6:
                    res = ("Шестерка");
                    break;
                case 7:
                    res = ("Семерка");
                    break;
                case 8:
                    res = ("Восьмерка");
                    break;
                case 9:
                    res = ("Девятка");
                    break;
                case 10:
                    res = ("Десятка");
                    break;
                case 11:
                    res = ("Валет");
                    break;
                case 12:
                    res = ("Дама");
                    break;
                case 13:
                    res = ("Король");
                    break;
                case 14:
                    res = ("Туз");
                    break;
                default:
                    throw new ArgumentException ($"Не может быть такого числа, введите от 6 до 14. Значение {value2}");
                    
                    

            }



            return res;
        }

       


    }
     
}
