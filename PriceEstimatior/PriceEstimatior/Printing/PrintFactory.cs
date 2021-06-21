using System;

namespace PriceEstimatior.Printing
{
    internal class PrintFactory
    {
        internal IPrint GetPrintTargetObject(string printTarget)
        {
            switch(printTarget.ToUpper())
            {
                case "S":
                    return new ScreenPrint();
                case "F":
                    return new FilePrint();
                case "P":
                    return new PaperPrint();
                default:
                    return new ScreenPrint();
            }
        }
    }
}