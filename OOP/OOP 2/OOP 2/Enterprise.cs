using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Enterprise
    {
        public string _enterpriseName;
        public int _workmans;
        public double _paymentPerHour;
        public string _bestWorker;
        public int _hoursPerMonth;
        public double _imposing;
        public string _superior;

        public Enterprise() { }

        public Enterprise(string enterpriseName)
        {
            _enterpriseName = enterpriseName;
        }

        public Enterprise(string enterpriseName, int workmans)
        {
            _enterpriseName = enterpriseName;
            _workmans = workmans;
        }

        public Enterprise(string enterpriseName,
        int workmans,
        double paymentPerHour,
        string bestWorker,
        int hoursPerMonth,
        double imposing,
        string superior)
        {
            _enterpriseName = enterpriseName;
            _workmans = workmans;
            _paymentPerHour = paymentPerHour;
            _bestWorker = bestWorker;
            _hoursPerMonth = hoursPerMonth;
            _imposing = imposing;
            _superior = superior;
        }

        public string GetEnterpriseName()
        {
            return _enterpriseName;
        }

        public int GetWorkmans()
        {
            return _workmans;
        }

        public double GetPaymentPerHour()
        {
            return _paymentPerHour;
        }

        public string GetBestWorker()
        {
            return _bestWorker;
        }

        public int GetHoursPerMonth()
        {
            return _hoursPerMonth;
        }

        public double GetImposing()
        {
            return _imposing;
        }

        public string GetSuperior()
        {
            return _superior;
        }

        public override string ToString()
        {
            return "Организация: " + _enterpriseName
            + "\nКол-во работников: " + _workmans
            + "\nПлата в час: " + _paymentPerHour
            + "\nЛучший работник: " + _bestWorker
            + "\nРабочих часов в месяц: " + _hoursPerMonth
            + "\nНалог: " + _imposing
            + "\nГлава отделения: " + _superior;
        }

        public static bool checkingEnterpriseName(string enterpriseName)
        {
            if (enterpriseName.Length == 0) return false;
            return true;
        }

        public static bool checkingWorkmans(int workmans)
        {
            if (workmans <= 0) return false;
            return true;
        }

        public static bool checkingPaymentPerHour(double paymentPerHour)
        {
            if (paymentPerHour <= 0) return false;
            return true;
        }

        public static bool checkingBestWorker(string bestWorker)
        {
            if (bestWorker.Length == 0) return false;
            return true;
        }

        public static bool checkingHoursPerMonth(int hoursPerMonth)
        {
            if (hoursPerMonth <= 0) return false;
            return true;
        }

        public static bool checkingImposing(double imposing)
        {
            if (imposing <= 0) return false;
            return true;
        }

        public static bool checkingSuperior(string superior)
        {
            if (superior.Length == 0) return false;
            return true;
        }
    }
}
