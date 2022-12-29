// See https://aka.ms/new-console-template for more information
using DayOfTheWeekApp.Core;

namespace DayOfTheWeekApp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var guesser = new DayGuesser();

        guesser.IntroduceTheApplication();
        guesser.AskUserForTheirDateOfBirth();
        guesser.CalculateDayOfTheWeek();
        guesser.PrintDayOfTheWeek();

        

    }
}