namespace Strategy_Pattern_Implementation.Interfaces;

public interface IPaymentStrategy
{
    bool Pay(float amount);

    void Refund(float amount);
    
    void ShowPaymentHistory();

    float GetBalance();
}
