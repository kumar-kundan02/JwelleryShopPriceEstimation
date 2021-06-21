using PriceEstimatior.Printing;
using System;

namespace PriceEstimatior.Services
{
    internal class PrintService
    {
        readonly IPrint _printTarget = null;
        public PrintService(string printTarget)
        {
            PrintFactory printFactory = new PrintFactory();
            _printTarget = printFactory.GetPrintTargetObject(printTarget);            
        }
        
        public void Print(double totalPrice)
        {
            try
            {
                _printTarget.Print(totalPrice);
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"Not Implemented Exception: {ex.Message}");                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            
        }
    }
}