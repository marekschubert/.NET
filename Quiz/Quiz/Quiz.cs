using Quiz.Core;

namespace Quiz
{
    public class Quiz
    {
        public QuizManager QuizManager { get; set; } = new QuizManager();

        public int Score { get; set; } = 0;

        public void PrintTask(Core.Task task)
        {
            Console.WriteLine(task.ToString());
        }

        public void AnswerATask(Core.Task task)
        {
            Console.WriteLine("Podaj odpowiedź: ");

            var userAnswer = Console.ReadLine();

            var userAnswerInt = char.Parse(userAnswer) - 'a';

            if(userAnswerInt == task.RightAnswer)
            {
                Score++;                
            }
        }

        public void RunQuiz()
        {
            Score= 0;
            foreach (var task in QuizManager.Tasks)
            {
                PrintTask(task);
                AnswerATask(task);
            }
            Console.WriteLine($"Wynik: {Score}/{QuizManager.Tasks.Count}");
            Console.WriteLine("Naciśnij y, aby zagrać jeszcze raz");
            var userAnswer = Console.ReadLine();
            if(userAnswer == "y") RunQuiz();
        }

        public void MainMenu()
        {

            var userInput = default(string);
            do
            {
                Console.WriteLine("1 - Dodaj zadanie");
                Console.WriteLine("2 - Zagraj");
                Console.WriteLine("3 - Wyjdź");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        RunQuiz();
                        break;
                }    
            }while(userInput != "3");
        }

        public void AddTask()
        {
            Console.WriteLine("Podaj pytanie:");

            var question = Console.ReadLine();

            Console.WriteLine("Podaj liczbę odpowiedzi:");

            var numberOfAnswers = int.Parse(Console.ReadLine());

            var answers = new List<string>();

            for (int i = 0; i < numberOfAnswers; i++)
            {
                Console.Write(i+ ": ");
                answers.Add(Console.ReadLine());
            }

            Console.WriteLine("Wybierz właściwą odpowiedź: ");

            var rightAnswer = int.Parse(Console.ReadLine());

            QuizManager.AddTask(numberOfAnswers, rightAnswer, question, answers);

        }


    }
}
