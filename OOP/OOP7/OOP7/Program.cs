using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP7
{
    static class Program
    {
        static Form1 form;
        static string enterpriseName;
        static int workmans;
        static double paymentPerHour;
        static string bestWorker;
        static int hoursPerMonth;
        static double imposing;
        static string superior;
        static MyQueue queue;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            queue = new MyQueue();
            queue.onCount += new Handler().Message;
            Application.Run(form);
        }

        public static bool CheckingTBs()
        {
            enterpriseName = form.tbEnterpriseName.Text;
            bestWorker = form.tbBestWorker.Text;
            superior = form.tbSuperior.Text;
            try
            {
                return ((PersonnelDepartment.CheckingEnterpriseName(enterpriseName)) &&
                        (Int32.TryParse(form.tbWorkmans.Text, out workmans) && PersonnelDepartment.CheckingWorkmans(workmans)) &&
                        (Double.TryParse(form.tbPaymentPerHour.Text, out paymentPerHour) && PersonnelDepartment.CheckingPaymentPerHour(paymentPerHour)) &&
                        (PersonnelDepartment.CheckingBestWorker(bestWorker)) &&
                        (Int32.TryParse(form.tbHoursPerMonth.Text, out hoursPerMonth) && PersonnelDepartment.CheckingHoursPerMonth(hoursPerMonth)) &&
                        (Double.TryParse(form.tbImposing.Text, out imposing) && PersonnelDepartment.CheckingImposing(imposing)) &&
                        (PersonnelDepartment.CheckingSuperior(superior)));
            }
            catch (MyException e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        public static void CreateEnterprise()
        {
            queue = queue+(new PersonnelDepartment(enterpriseName, workmans, paymentPerHour, bestWorker, hoursPerMonth, imposing, superior));
        }

        public static void ShowAllEnterprises()
        {
            form.tbOutput.Text = null;
            foreach (PersonnelDepartment i in queue)
                form.tbOutput.Text += i.ToString()+"\n";
        }
    }
}
