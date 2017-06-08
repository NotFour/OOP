namespace OOP6
{
    abstract class Department
    {
        protected string _enterpriseName;
        protected int _workmans;
        protected double _paymentPerHour;
        protected string _bestWorker;
        protected int _hoursPerMonth;
        protected double _imposing;
        protected string _superior;

        public abstract override string ToString();

        public void SetEnterpriseName(string enterpriseName)
        {
            _enterpriseName = enterpriseName;
        }

        public void SetWorkmans(int workmans)
        {
            _workmans = workmans;
        }

        public void SetPaymentPerHour(double paymentPerHour)
        {
            _paymentPerHour = paymentPerHour;
        }

        public void SetBestWorker(string bestWorker)
        {
            _bestWorker = bestWorker;
        }

        public void SetHoursPerMonth(int hoursPerMonth)
        {
            _hoursPerMonth = hoursPerMonth;
        }

        public void SetImposing(double imposing)
        {
            _imposing = imposing;
        }

        public void SetSuperior(string superior)
        {
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
    }
}
