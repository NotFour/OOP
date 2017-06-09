namespace OOP6
{
    class PersonnelDepartment : Department
    {
        public static int objects = 0;

        public PersonnelDepartment()
        {
            objects++;
            _enterpriseName = "Funcorp";
            _workmans = 350;
            _paymentPerHour = 220.5;
            _bestWorker = "Serov";
            _hoursPerMonth = 200;
            _imposing = 10.5;
            _superior = "Cherkasova";
        }

        public PersonnelDepartment(string enterpriseName)
        {
            objects++;
            _enterpriseName = enterpriseName;
            _workmans = 350;
            _paymentPerHour = 220.5;
            _bestWorker = "Serov";
            _hoursPerMonth = 200;
            _imposing = 10.5;
            _superior = "Cherkasova";
        }

        public PersonnelDepartment(string enterpriseName, int workmans)
        {
            objects++;
            _enterpriseName = enterpriseName;
            _workmans = workmans;
            _paymentPerHour = 220.5;
            _bestWorker = "Serov";
            _hoursPerMonth = 200;
            _imposing = 10.5;
            _superior = "Cherkasova";
        }

        public PersonnelDepartment(string enterpriseName,
        int workmans,
        double paymentPerHour,
        string bestWorker,
        int hoursPerMonth,
        double imposing,
        string superior)
        {
            objects++;
            _enterpriseName = enterpriseName;
            _workmans = workmans;
            _paymentPerHour = paymentPerHour;
            _bestWorker = bestWorker;
            _hoursPerMonth = hoursPerMonth;
            _imposing = imposing;
            _superior = superior;
        }

        public override string ToString()
        {
            return  "Объектов класса" + objects
            + "\r\nОрганизация: " + _enterpriseName
            + "\r\nКол-во работников: " + _workmans
            + "\r\nПлата в час: " + _paymentPerHour
            + "\r\nЛучший работник: " + _bestWorker
            + "\r\nРабочих часов в месяц: " + _hoursPerMonth
            + "\r\nНалог: " + _imposing
            + "\r\nГлава отделения: " + _superior + "\r\n\r\n";
        }

        public static bool CheckingEnterpriseName(string enterpriseName)
        {
            if (enterpriseName.Length == 0) return false;
            return true;
        }

        public static bool CheckingWorkmans(int workmans)
        {
            if (workmans <= 0)
            {
                throw new MyException(workmans + " - отрицательное число или нуль");
            }
            else
            {
                return true;
            }
        }

        public static bool CheckingPaymentPerHour(double paymentPerHour)
        {
            if (paymentPerHour <= 0)
            {
                throw new MyException(paymentPerHour + " - отрицательное число или нуль");
            }
            else
            {
                return true;
            }
        }

        public static bool CheckingBestWorker(string bestWorker)
        {
            if (bestWorker.Length == 0) return false;
            return true;
        }

        public static bool CheckingHoursPerMonth(int hoursPerMonth)
        {
            if(hoursPerMonth <= 0)
            {
                throw new MyException(hoursPerMonth + " - отрицательное число или нуль");
            }
            else
            {
                return true;
            }
        }

        public static bool CheckingImposing(double imposing)
        {
            if (imposing <= 0)
            {
                throw new MyException(imposing + " - отрицательное число или нуль");
            }
            else
            {
                return true;
            }
        }

        public static bool CheckingSuperior(string superior)
        {
            if (superior.Length == 0) return false;
            return true;
        }
    }
}
