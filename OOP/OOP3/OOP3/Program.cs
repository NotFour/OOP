using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP3
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
        static Queue<Enterprise> queue = new Queue<Enterprise>();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new Form1();
            Application.Run(form);
        }

        public static bool CheckingTBs()
        {
            enterpriseName = form.tbEnterpriseName.Text;
            bestWorker = form.tbBestWorker.Text;
            superior = form.tbSuperior.Text;

            return ((Enterprise.CheckingEnterpriseName(enterpriseName)) &&
                    (Int32.TryParse(form.tbWorkmans.Text, out workmans) && Enterprise.CheckingWorkmans(workmans)) &&
                    (Double.TryParse(form.tbPaymentPerHour.Text, out paymentPerHour) && Enterprise.CheckingPaymentPerHour(paymentPerHour)) &&
                    (Enterprise.CheckingBestWorker(bestWorker)) &&
                    (Int32.TryParse(form.tbHoursPerMonth.Text, out hoursPerMonth) && Enterprise.CheckingHoursPerMonth(hoursPerMonth)) &&
                    (Double.TryParse(form.tbImposing.Text, out imposing) && Enterprise.CheckingImposing(imposing)) &&
                    (Enterprise.CheckingSuperior(superior)));
        }

        public static void CreateEnterprise()
        {
            queue.Enqueue(new Enterprise(enterpriseName, workmans, paymentPerHour, bestWorker, hoursPerMonth, imposing, superior));
        }

        public static void ShowAllEnterprises()
        {
            form.tbOutput.Text = null;
            foreach (Enterprise i in queue)
                form.tbOutput.Text += i.ToString()+"\n";
        }

    }
}
