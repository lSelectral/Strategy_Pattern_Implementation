using Strategy_Pattern_Implementation.Interfaces;

namespace Strategy_Pattern_Implementation;

public class PaymentContext
{
    #region CTOR
    private IPaymentStrategy _paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public PaymentContext() { }

    #endregion

    // Allow external strategy setting
    public PaymentContext SetStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
        return this;
    }

    public void Pay(int amount)
    {
        var result = _paymentStrategy.Pay(amount);

        if (result)
            Console.WriteLine("Payment successful");
        else
            Console.WriteLine("Payment failed");
    }

    public void Refund(int amount)
    {
        Console.WriteLine("Refund requested");
        _paymentStrategy.Refund(amount);
        var totalToken = _paymentStrategy.GetBalance();
        Console.WriteLine("Refund completed. Updated total token is: {0}", 
            totalToken.ToString("F2"));
    }

    public void GetBalance() => 
        Console.WriteLine("\nYour current balance is: {0}\n", 
            _paymentStrategy.GetBalance().ToString("F2"));

    public void ShowPaymentHistory() => _paymentStrategy.ShowPaymentHistory();
}
