namespace PracticeTest
{
    public class Bank
    {
        int bankBalance;
        public void Deposit(int deposit)
        {
            bankBalance += deposit;
        }
        public void Withdrawn(int withdraw)
        {
            bankBalance -= withdraw;
        }
        public void setBankBalance(int balance)
        {
            bankBalance = balance;
        }
        public int getBankBalance()
        {
            return bankBalance;
        }
    }
}
