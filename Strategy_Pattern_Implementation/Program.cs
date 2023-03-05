using Strategy_Pattern_Implementation.Strategies.Payment;

namespace Strategy_Pattern_Implementation;

internal class Program
{
    static void Main(string[] args)
    {
        PaymentContext paymentContext = new PaymentContext();

        while (true)
        {
            Console.WriteLine("Please select a payment method: 1 or 2");
            Console.WriteLine("1. Mobile Transfer");
            Console.WriteLine("2. Credit Card");
            var paymentMethod = Console.ReadLine();

            if (paymentMethod != "1" && paymentMethod != "2")
                continue;

            if (paymentMethod == "1")
            {
                Console.WriteLine("You have selected Mobile Transfer and given 1000 tokens");
                var mobileTransferStrategy = new MobileTransfer(1000);
                paymentContext.SetStrategy(mobileTransferStrategy);
            }
            else if (paymentMethod == "2")
            {
                Console.WriteLine("You have selected Credit Card and given 1000 tokens");
                var creditCardStrategy = new CreditCard(1000);
                paymentContext.SetStrategy(creditCardStrategy);
            }
            else
            {
                Console.WriteLine("Invalid payment method");
            }
            Console.WriteLine("\n-----------\n");
            break;
        }

        while (true)
        {
            Console.WriteLine("Please select an action: 1, 2, 3 or 4");
            paymentContext.GetBalance();
            Console.WriteLine("1. Pay");
            Console.WriteLine("2. Refund");
            Console.WriteLine("3. Get Balance");
            Console.WriteLine("4. Show Payment History");
            var action = Console.ReadLine();

            if (action == "1")
            {
                Console.WriteLine("Please enter the amount to pay");
                var amount = Convert.ToInt32(Console.ReadLine());
                paymentContext.Pay(amount);
            }
            else if (action == "2")
            {
                Console.WriteLine("Please enter the amount to refund");
                var amount = Convert.ToInt32(Console.ReadLine());
                paymentContext.Refund(amount);
            }
            else if (action == "3")
            {
                paymentContext.GetBalance();
            }
            else if (action == "4")
            {
                paymentContext.ShowPaymentHistory();
            }
            else
            {
                Console.WriteLine("Invalid action");
            }
            Console.WriteLine("\n-----------\n");
        }
    }
}
