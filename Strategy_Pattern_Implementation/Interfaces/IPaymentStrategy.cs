namespace Strategy_Pattern_Implementation.Interfaces;

public interface IPaymentStrategy
{
    /// <summary>
    /// Pay for a service and return true if successful
    /// </summary>
    /// <param name="amount">Amount to pay</param>
    /// <returns>True on success</returns>
    bool Pay(float amount);

    /// <summary>
    /// Refund any amount
    /// </summary>
    /// <param name="amount">Amount to refund</param>
    void Refund(float amount);
    
    /// <summary>
    /// Show total payment history
    /// </summary>
    void ShowPaymentHistory();

    /// <summary>
    /// Get current balance
    /// </summary>
    /// <returns>Returns current balance</returns>
    float GetBalance();
}
