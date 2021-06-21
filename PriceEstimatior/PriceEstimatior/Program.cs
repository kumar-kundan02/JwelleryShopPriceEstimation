using PriceEstimatior.Estimation;
using PriceEstimatior.Models;
using PriceEstimatior.Services;
using System;

namespace PriceEstimatior
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Welcome To Jwellery Shop *****");

            string loginAsDiffrentUser = "Y";

            while(loginAsDiffrentUser.ToUpper() == "Y")
            {
                Console.WriteLine("***Enter UserName and Password for Login to System***");
                Console.Write("Enter UserName: ");
                string userName = Console.ReadLine();

                Console.Write("Enter Password: ");
                string password = Console.ReadLine();


                LoginService customerLogin = new LoginService();
                Customer customer = customerLogin.Authenticate(userName, password);
                if (customer == null)
                    Console.WriteLine("Authentication Failed");
                else
                {
                    Console.WriteLine("Authentication Successfull");

                    string repeat = "Y";

                    if (customer.Category == CustomerType.Regular)
                    {
                        while (repeat.ToUpper() == "Y")
                        {
                            ExecuteForRegularCustomer();
                            Console.Write("Want to Calulate Again? (Y/N): ");
                            repeat = Console.ReadLine();
                            Console.WriteLine();
                        }

                    }
                    else if (customer.Category == CustomerType.Privilege)
                    {
                        while (repeat.ToUpper() == "Y")
                        {
                            ExecuteForPrivilegeCustomer();
                            Console.Write("Want to Calulate Again? (Y/N): ");
                            repeat = Console.ReadLine();
                            Console.WriteLine();
                        }

                    }

                    Console.WriteLine("Want to Login as Different User? (Y/N): ");
                    loginAsDiffrentUser = Console.ReadLine();
                }
            }
            
            Console.ReadLine();
        }

        private static void ExecuteForRegularCustomer()
        {
            Console.Write("Enter Gold Price: ");
            double.TryParse(Console.ReadLine(), out double price);
            Console.Write("Enter Gold Weight: ");
            double.TryParse(Console.ReadLine(), out double weight);

            IEstimationStratgy estimationStratgy = new RegularEstimator(price, weight);
            double totalPrice = estimationStratgy.Calculate();

            Console.Write("Select Print Target. Screen(S), File(F), Paper(P):");
            string printTarget = Console.ReadLine();
            Console.WriteLine();

            PrintService printService = new PrintService(printTarget);
            printService.Print(totalPrice);
        }

        private static void ExecuteForPrivilegeCustomer()
        {
            Console.Write("Enter Gold Price: ");
            double.TryParse(Console.ReadLine(), out double price);
            Console.Write("Enter Gold Weight: ");
            double.TryParse(Console.ReadLine(), out double weight);
            Console.Write("Enter Discount: ");
            double.TryParse(Console.ReadLine(), out double discount);

            IEstimationStratgy estimationStratgy = new PrivilegeEstimator(price, weight, discount);
            double totalPrice = estimationStratgy.Calculate();

            Console.Write("Select Print Target. Screen(S), File(F), Paper(P):");
            string printTarget = Console.ReadLine();            

            PrintService printService = new PrintService(printTarget);
            printService.Print(totalPrice);
        }
    }
}
