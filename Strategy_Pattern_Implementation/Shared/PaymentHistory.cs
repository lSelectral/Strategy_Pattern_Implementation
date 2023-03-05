namespace Strategy_Pattern_Implementation.Shared;

public class PaymentHistory
{
    public string PaymentMethod { get; set; }

    public float Amount { get; set; }

    public DateTime Date { get; set; }

    public PaymentHistoryEnum PaymentType { get; set; }

    public PaymentHistory(string paymentMethod, float amount, PaymentHistoryEnum paymentType)
    {
        PaymentMethod = paymentMethod;
        Amount = amount;
        Date = DateTime.Now;
        PaymentType = paymentType;
    }

    public override string ToString()
    {
        return $"Payment method: {PaymentMethod}, Amount: {Amount.ToString("F2")}, Date: {Date.ToString("dd-MM-yyyy")}, Payment type: {PaymentType}";
    }
}
