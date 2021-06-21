namespace PriceEstimatior.Printing
{
    internal class FilePrint : IPrint
    {
        public void Print(double totalPrice)
        {
            System.Console.WriteLine($"Printing in File :: Total Price : {totalPrice}");
        }
    }
}