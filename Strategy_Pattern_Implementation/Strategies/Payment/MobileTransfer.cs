using Strategy_Pattern_Implementation.Interfaces;
using Strategy_Pattern_Implementation.Shared;

namespace Strategy_Pattern_Implementation.Strategies.Payment;

public class MobileTransfer : IPaymentStrategy
{
    private float totalMoney = 0f;
    private readonly List<PaymentHistory> _paymentHistories;

    public MobileTransfer(float totalMoney)
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
            "Mobile Transfer",
            amount,
            PaymentHistoryEnum.Paid
            ));

        Console.WriteLine("Paid {0} with mobile transfer. Remained: {1}", amount.ToString("F2"), totalMoney.ToString("F2"));

        return true;
    }

    public void Refund(float amount)
    {
        totalMoney += amount;

        _paymentHistories.Add(new PaymentHistory(
            "Mobile Transfer",
            amount,
            PaymentHistoryEnum.Refunded
            ));

        Console.WriteLine("Refunded {0} with mobile transfer. Updated balance: {1}", amount.ToString("F2"), totalMoney.ToString("F2"));
    }

    public void ShowPaymentHistory()
    {
        _paymentHistories.ShowPaymentHistory();
    }

    public float GetBalance() => totalMoney;
}
