namespace PracticeTest
{

    public class CardPayment
    {
        public CardPayment() {
            Console.WriteLine("Paid using card");
        }

        public void Show()
        {
            Console.WriteLine("Shown from cardpayment");
        }
    }
    public class WalletPayment
    {
        public WalletPayment()
        {
            Console.WriteLine("Paid using wallet");
        }

        public void Show()
        {
            Console.WriteLine("Shown from walletpayment");
        }
    }
    
}
