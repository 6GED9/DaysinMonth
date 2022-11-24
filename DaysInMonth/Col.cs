using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DaysInMonth
{
    internal class Col
    {
        static int nummonth;
        private static int Colculate()
        {
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();
            switch (month)
            {
                case "Январь":
                    nummonth = 1;
                    break;
                case "Февраль":
                    nummonth = 2;
                    break;
                case "Март":
                    nummonth = 3;
                    break;
                case "Апрель":
                    nummonth = 4;
                    break;
                case "Май":
                    nummonth = 5;
                    break;
                case "Июнь":
                    nummonth = 6;
                    break;
                case "Июль":
                    nummonth = 7;
                    break;
                case "Аргуст":
                    nummonth = 8;
                    break;
                case "Сентябрь":
                    nummonth = 9;
                    break;
                case "Октябрь":
                    nummonth = 10;
                    break;
                case "Ноябрь":
                    nummonth = 11;
                    break;
                case "Декабрь":
                    nummonth = 12;
                    break;
                default:
                    return 0;
            }
            int days = System.DateTime.DaysInMonth(year, nummonth);
            return days;
        }
        public static void Vivod()
        {
            int days = Colculate();
            if(days != 0)
            {
                if (days == 1 || days == 21 || days == 31) Console.WriteLine(days + " день");
                else if (days == 2 || days == 3 || days == 4 || days == 22 || days == 23 || days == 24) Console.WriteLine(days + " дня");
                else Console.WriteLine(days + " дней");
            }
            else Console.WriteLine("Такого месяца не существует");
        }
    }
}
