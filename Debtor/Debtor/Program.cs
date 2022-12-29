namespace Debtor
{
    public class Program
    {
        static void Main(string[] args)
        {
            DebtorApp debtorApp = new DebtorApp();
            debtorApp.IntroduceDebtorApp();
            debtorApp.AskForAction();
        }
    }
}