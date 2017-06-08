using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    class BakingDepartment : Department
    {
        int _bakingPerMonth;

        public override string ToString()
        {
            return "Организация: " + _enterpriseName
            + "\nКол-во работников: " + _workmans
            + "\nПлата в час: " + _paymentPerHour
            + "\nЛучший работник: " + _bestWorker
            + "\nРабочих часов в месяц: " + _hoursPerMonth
            + "\nНалог: " + _imposing
            + "\nГлава отделения: " + _superior
            + "\nВыпечки в месяц: " + _bakingPerMonth;
        }

        public BakingDepartment()
        {
            _bakingPerMonth = 1000;
            _enterpriseName = "Funcorp";
            _workmans = 350;
            _paymentPerHour = 220.5;
            _bestWorker = "Serov";
            _hoursPerMonth = 200;
            _imposing = 10.5;
            _superior = "Cherkasova";
        }
    }
}
