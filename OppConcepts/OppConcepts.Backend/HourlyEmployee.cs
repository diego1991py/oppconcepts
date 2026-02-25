namespace OppConcepts.Backend   
{

    public class HourlyEmployee : Employee
    {
        //Fields
        private decimal _hourValue;
        private float _workingHours;

        //Constructors
        public HourlyEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, decimal hourlyValue, float workingHours) :
            base(id, firstName, lastName, isActive, bornDate, hireDate)
        {
            HourlyValue = hourlyValue;
            WorkingHours = workingHours;
        }

        //Properties
        public decimal HourlyValue
        { 
            get => _hourValue;
            set => _hourValue = ValidateHourValue(value);
        }

        public float WorkingHours
        { 
            get => _workingHours;
            set => _workingHours = ValidateWorkingHours(value);
        }


        //Methods
        public override decimal GetValueToPay() => (decimal)WorkingHours * HourlyValue;

        public override string ToString() => base.ToString() + $"\n\t" +
            $"Hourly Value.....: {HourlyValue,20:C}\n\t" +
            $"Working Hours....: {WorkingHours,20:N2}";

        
     

        private decimal ValidateHourValue(decimal hourValue)
        {
            if (hourValue < 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(hourValue), "Hourly value must be greater than or equal to $10.000");
            }
            return hourValue;
        }

        private float ValidateWorkingHours(float workingHours)
        {
            if (workingHours < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(workingHours), "Working Hours value must be greater than or equal to $10.000");
            }
            return workingHours;
        }
    }
}
