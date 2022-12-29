using Debtor.Core;
using System.Net.NetworkInformation;

namespace Debtor
{
    public class DebtorApp
    {
        public BorrowerManager BorrowerManager { get; set; } = new BorrowerManager();

        public void IntroduceDebtorApp()
        {
            Console.WriteLine("Aplikacja Dłużnik");
        }


        public void AddBorower()
        {
            Console.WriteLine("Podaj nazwę dłużnika, która chcesz dodać do listy");
            var userName = Console.ReadLine();

            Console.WriteLine("Podaj nazwę dłużnika, która chcesz dodać do listy");
            var userAmount = Console.ReadLine();


            var amountInDecimal = default(decimal);

            while (!decimal.TryParse(userAmount, out amountInDecimal))
            {
                Console.WriteLine("Podano niepoprawną kwotę");

                Console.WriteLine("Podaj kwotę długu: ");
                
                userAmount = Console.ReadLine();
            }

            BorrowerManager.AddBorrower(userName, amountInDecimal);
        }

        public void DeleteBorrower()
        {
            Console.WriteLine("Podaj nazwę dłużnika, która chcesz usunąć z listy");
            var userName = Console.ReadLine();

            BorrowerManager.DeleteBorrower(userName);

            Console.WriteLine("Udało się usunąć dłużnika");
        }

        public void ListAllBorrowers()
        {
            Console.WriteLine("Lista dłużników");

            foreach (var borrower in BorrowerManager.ListBorrowers())
            {
                Console.WriteLine(borrower);
            }
        }

        public void PrintAllAmount()
        {
            var totalAmount = BorrowerManager.GetTotalAmount();
            Console.WriteLine($"Łączne zadłużenie: {totalAmount}");
        }

        public void AskForAction()
        {
            var userInput = default(string);

            do { 
                Console.WriteLine("Podaj czynność, którą chcesz wykonać: ");

                Console.WriteLine("add - dodaj");
                Console.WriteLine("del - usuń");
                Console.WriteLine("list - wypisz");
                Console.WriteLine("total - łączne zadłużenie");
                Console.WriteLine("exit - wyjdź");

                userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                switch (userInput)
                {
                    case "add":
                        AddBorower(); 
                        break;
                    case "del":
                        DeleteBorrower();
                        break;
                    case "list":
                        ListAllBorrowers();
                        break;
                    case "total":
                        PrintAllAmount();
                        break;
                    default:
                        Console.WriteLine("Podano złą wartość");
                        break;
                }            
            }while(userInput != "exit");
        }
    }
}
