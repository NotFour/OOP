using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7
{
    class BakingDepartment : Department
    {
        int _bakingPerMonth;

        public override string ToString()
        {
            return "Организация: " + _enterpriseName
            + "\r\nКол-во работников: " + _workmans
            + "\r\nПлата в час: " + _paymentPerHour
            + "\r\nЛучший работник: " + _bestWorker
            + "\r\nРабочих часов в месяц: " + _hoursPerMonth
            + "\r\nНалог: " + _imposing
            + "\r\nГлава отделения: " + _superior
            + "\r\nВыпечки в месяц: " + _bakingPerMonth + "\r\n\r\n";
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
