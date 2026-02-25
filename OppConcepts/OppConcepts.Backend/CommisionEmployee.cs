using System.Reflection.Metadata.Ecma335;

namespace OppConcepts.Backend
{
    public class CommisionEmployee : Employee
    {
       float _commisionPercentaje;
       decimal _sales;

        public CommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commisionPercentaje, decimal sales) :
            base(id, firstName, lastName, isActive, bornDate, hireDate)
        {
            CommisionPercentaje = commisionPercentaje;
            Sales = sales;
        }

        public float CommisionPercentaje
        {
            get => _commisionPercentaje;
            set => _commisionPercentaje = ValidateCommisionPercentaje(value);
        }
        public decimal Sales
        { 
            get => _sales;
            set => _sales = ValidateSales(value);
        }

        public override decimal GetValueToPay() => (Sales * (decimal)CommisionPercentaje);

        public override string ToString() => base.ToString() + $"\n\t" +
            $"Commision Percentaje.: {CommisionPercentaje,18:P2}\n\t" +
            $"Sales............: {Sales,20:C}";


        private float ValidateCommisionPercentaje(float commisionPercentaje)
        {
            if (commisionPercentaje < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(commisionPercentaje), "Commision Percentaje  value must be between 0 and 1");
            }
            return  commisionPercentaje;
        }

        private decimal ValidateSales(decimal sales)
        {
            if (sales < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sales), "Sales  value must be greater than 0");
            }
            return sales;            
        }
       

    }
}
