
namespace OppConcepts.Backend
{
    public class BaseCommisionEmployee : CommisionEmployee
    {
        decimal _salary;

        public BaseCommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commisionPercentaje, decimal sales, decimal salary) :
            base(id, firstName, lastName, isActive, bornDate, hireDate, commisionPercentaje, sales)
        {
            Salary = salary;
        }

        public decimal Salary
        { 
            get => _salary;
            set => _salary = ValidateSalary(value);
        }


        public override decimal GetValueToPay() => base.GetValueToPay() + Salary;


        public override string ToString() => $"{base.ToString()}\n\tSalary Base.....: {Salary,20:C2}";

        private decimal ValidateSalary(decimal salary)
        {
            if (salary < 500000)
            {
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $500,000");
            }
            return salary;

        }
    }
}
