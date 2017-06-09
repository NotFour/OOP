using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterpriseName;
            int workmans;
            double paymentPerHour;
            string bestWorker;
            int hoursPerMonth;
            double imposing;
            string superior;

            Console.WriteLine("Лабораторная работа №1, вариант №7 (Отдел кадров)" +
            "\nВыполнили студенты группы 15ВП1\nБляхарский Роман и Серов Евгений\n");

            do
            {
                Console.WriteLine("Введите наименование предприятия: ");
                enterpriseName = Console.ReadLine();
            } while (!Enterprise.checkingEnterpriseName(enterpriseName));
            Console.WriteLine();

            do
            {
                Console.WriteLine("Введите число работников (это должно быть целым числом)");
            } while (!Int32.TryParse(Console.ReadLine(), out workmans)||!Enterprise.checkingWorkmans(workmans));
            Console.WriteLine();

            do
            {
                Console.WriteLine("Введите заработную плату в час (это должно быть числом)");
            } while (!Double.TryParse(Console.ReadLine(), out paymentPerHour)||!Enterprise.checkingPaymentPerHour(paymentPerHour));
            Console.WriteLine();

            do
            {
                Console.WriteLine("Введите ФИО лучшего работника предприятия");
                bestWorker = Console.ReadLine();
            } while (!Enterprise.checkingBestWorker(bestWorker));
            Console.WriteLine();

            do
            {
                Console.WriteLine("Введите количество рабочих часов в месяц (это должно быть целым числом)");
            } while (!Int32.TryParse(Console.ReadLine(), out hoursPerMonth)||!Enterprise.checkingHoursPerMonth(hoursPerMonth));
            Console.WriteLine();

            do
            {
                Console.WriteLine("Введите размер налога (это должно быть числом)");
            } while (!Double.TryParse(Console.ReadLine(), out imposing)||!Enterprise.checkingImposing(imposing));
            Console.WriteLine();

            do
            {
                Console.WriteLine("Введите ФИО начальника отдела");
                superior = Console.ReadLine();
            } while (!Enterprise.checkingSuperior(superior));
            Console.WriteLine();

            Enterprise file = new Enterprise(enterpriseName, workmans, paymentPerHour, bestWorker,
            hoursPerMonth, imposing, superior);

            Console.WriteLine(file.ToString());
            Console.WriteLine();
            Console.WriteLine("Число работников: " + file._workmans);
            Console.WriteLine("Наименование предприятия: " + file.GetEnterpriseName());
            Console.WriteLine("Число работников в 16ричной системе: " + Convert.ToString(Convert.ToInt32(file._workmans), 16));

            Console.ReadKey();
        }
    }
}
