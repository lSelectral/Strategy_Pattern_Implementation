namespace Strategy_Pattern_Implementation.Shared;

public static class PaymentHistoryExtensions
{
    public static void ShowPaymentHistory(this IEnumerable<PaymentHistory> paymentHistory)
    {
        foreach (var payment in paymentHistory)
        {
            Console.WriteLine(payment);
        }
    }
}
