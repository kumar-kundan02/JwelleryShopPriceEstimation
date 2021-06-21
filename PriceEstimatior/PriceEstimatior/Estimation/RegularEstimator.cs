namespace PriceEstimatior.Estimation
{
    internal class RegularEstimator: IEstimationStratgy
    {
        public double Price { get; private set; }
        public double Weight { get; private set; }

        public RegularEstimator(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }

        public virtual double Calculate()
        {
            System.Console.WriteLine("Inside Regular Calculate");
            return Price * Weight;
        }

    }
}