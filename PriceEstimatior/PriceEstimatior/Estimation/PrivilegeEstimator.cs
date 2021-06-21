namespace PriceEstimatior.Estimation
{
    internal class PrivilegeEstimator: RegularEstimator
    {
        public double Discount { get; private set; } = 2;

        public PrivilegeEstimator(double price, double weight, double discount): base(price, weight)
        {
            if (discount > Discount)
                Discount = discount;
        }

        public override double Calculate()
        {
            System.Console.WriteLine("Inside Privilege Calculate");
            double totalPrice = base.Calculate();
            return totalPrice - totalPrice * Discount / 100;
        }
    }
}