using DayOfTheWeekApp.Core;
using DayOfTheWeekApp.Core.Enums;

namespace DayOfTheWeekApp
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }

        public DateTimeOffset UserDateOfBirth { get; set; }
        public DayOfTheWeek UserDayOfTheWeek { get; set; }

        public void IntroduceTheApplication()
        {
            Console.WriteLine("Hey, jestem botem który potrafi wyliczać dzień tygodnia na podstawie Twojej daty urodzenia.");
            Calculator = new DayCalculator();
        }

        public void AskUserForTheirDateOfBirth()
        {
            Console.WriteLine("Podaj mi proszę swoją datę urodzenia: ");

            var userDate = Console.ReadLine();

            var succeded = DateTimeOffset.TryParse(userDate, out var date);
        
            if (succeded)
            {
                UserDateOfBirth = date;
                return;
            }

            Console.WriteLine("Format daty był zły. Proszę go podać w dd/mm/yyyy");
            AskUserForTheirDateOfBirth();            
        }


        public void CalculateDayOfTheWeek()
        { 
            if(UserDateOfBirth == null)
            {
                Console.WriteLine("Próbowano obliczyć dzień tygodnia bez podania daty urodzenia");
                return;
            }

            UserDayOfTheWeek = Calculator.CalculateDayOfTheWeek(UserDateOfBirth);
        
        }

        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Obliczony dzień tygodnia to: " + UserDayOfTheWeek.Translate());

        }


    }
}
