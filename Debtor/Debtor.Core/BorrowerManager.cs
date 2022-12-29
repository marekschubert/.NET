using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Debtor.Core
{
    public class BorrowerManager
    {
        private List<Borrower> Borrowers { get; set; }

        private string FileName { get; set; } = "borrowers.txt";

        private void ReadBorrowersList()
        {
            Borrowers = new List<Borrower>();

            if(!File.Exists(FileName))
            {
                return;
            }

            var allLines =  File.ReadAllLines(FileName);

            foreach (var line in allLines)
            {
                var lineElements = line.Split(';');

                var name = lineElements[0];
                var amount = decimal.Parse(lineElements[1]);

                AddBorrower(name, amount, false);
            }
        }

        public BorrowerManager()
        {
            ReadBorrowersList();
        }

        public void AddBorrower(string name, decimal amount, bool shouldSaveToFile = true)
        {
            var borrower= new Borrower { Name = name, Amount= amount };

            Borrowers.Add(borrower);

            if(shouldSaveToFile)
            {
                File.AppendAllLines(FileName, new List<string> { borrower.ToStringToFile() });
            }
        }

        public void DeleteBorrower(string name, bool shouldSaveToFile = true)
        {
            foreach (var borrower in Borrowers)
            {
                if (borrower.Name == name)
                {
                    Borrowers.Remove(borrower);
                    break;
                }
            }

            if (shouldSaveToFile)
            {
                var listToSave = new List<string>();
                foreach (var borrower in Borrowers)
                {
                    listToSave.Add(borrower.ToStringToFile());
                }

                File.Delete(FileName);
                File.WriteAllLines(FileName, listToSave);
            }

        }

        public List<string> ListBorrowers()
        {
            var borrowersStrings = new List<string>();
            var indexer = 1;

            foreach (var borrower in Borrowers)
            {
                var borrowerString = indexer + ". " + borrower.Name + " - " + borrower.Amount + " zł";
                borrowersStrings.Add(borrowerString);
                indexer++;
            }
            return borrowersStrings;
        }

        public decimal GetTotalAmount()
        {
            var totalAmount = default(decimal);

            foreach (var borrower in Borrowers)
            {
                totalAmount += borrower.Amount;
            }
            return totalAmount;
        }




    }
}
