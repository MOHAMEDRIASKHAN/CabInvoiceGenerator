// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace CabInvoiceGenerator
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double flare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");
        }
    }
}