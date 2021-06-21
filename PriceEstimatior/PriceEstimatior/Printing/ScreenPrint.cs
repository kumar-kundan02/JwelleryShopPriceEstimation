namespace PriceEstimatior.Printing
{
    internal class ScreenPrint : IPrint
    {
        public void Print(double totalPrice)
        {
            System.Console.WriteLine($"Printing in Screen :: Total Price : {totalPrice}");
        }
    }
}