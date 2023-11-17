using ChainOfResponsibility;

class Receiver
{
// банковские переводы
    public bool BankTransfer { get; set; }
// денежные переводы - WesternUnion, Unistream
    public bool MoneyTransfer { get; set; }
// перевод через PayPal
    public bool PayPalTransfer { get; set; }
    public Receiver(bool bt, bool mt, bool ppt)
    {
        BankTransfer = bt;
        MoneyTransfer = mt;
        PayPalTransfer = ppt;
    }
}

abstract class PaymentHandler
{
    public PaymentHandler Successor { get; set; }
    public abstract void Handle(Receiver receiver);
}

class Program
{
    static void Main()
    {
        Receiver receiver = new Receiver(false, true, true);
        PaymentHandler bankPaymentHandler = new BankPaymentHandler();
        PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
        PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
        
        moneyPaymentHnadler.Successor = paypalPaymentHandler;
        bankPaymentHandler.Successor = moneyPaymentHnadler;
        
        bankPaymentHandler.Handle(receiver);
    }
}
