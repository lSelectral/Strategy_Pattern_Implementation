using Strategy_Pattern_Implementation.Interfaces;
using Strategy_Pattern_Implementation.Shared;

namespace Strategy_Pattern_Implementation.Strategies.Payment;

public class CreditCard : IPaymentStrategy
{
    private float totalMoney = 0f;
    private readonly List<PaymentHistory> _paymentHistories;
    
    public CreditCard(float totalMoney)
    {
        this.totalMoney = totalMoney;
        _paymentHistories = new List<PaymentHistory>();
    }

    public bool Pay(float amount) 
    {
        if (totalMoney < amount)
            return false;

        totalMoney -= amount;

        _paymentHistories.Add(new PaymentHistory(
            "Credit Card",
            amount,
            PaymentHistoryEnum.Paid
            ));

        Console.WriteLine("Paid {0} with credit card. Remained: {1}", amount.ToString("F2"), totalMoney.ToString("F2")); 
        
        return true;
    }

    public void Refund(float amount)
    {
        totalMoney += amount;

        _paymentHistories.Add(new PaymentHistory(
            "Credit Card",
            amount,
            PaymentHistoryEnum.Refunded
            ));

        Console.WriteLine("Refunded {0} with credit card. Updated balance: {1}", amount.ToString("F2"), totalMoney.ToString("F2"));
    }

    public void ShowPaymentHistory()
    {
        _paymentHistories.ShowPaymentHistory();
    }

    public float GetBalance() => totalMoney;
}
