namespace Quiz.Core
{
    public class QuizManager
    {
        public List<Task> Tasks { get; set; }

        public string FileName { get; set; } = "tasks.txt";

        public QuizManager()
        {
            LoadTasksFromFile();
        }

        public void LoadTasksFromFile()
        {
            Tasks = new List<Task>();

            if(!File.Exists(FileName))
            {
                return;
            }
            
            var allLinesInFile = File.ReadAllLines(FileName);

            for (int i = 0; i < allLinesInFile.Length; i++)
            {
                var firstLineItems = allLinesInFile[i].Split(',');
                var numberOfAnswers = int.Parse(firstLineItems[0]);
                var rightAnswer = int.Parse(firstLineItems[1]);
                i++;
                var question = allLinesInFile[i];
                i++;
                var answers = new List<string>();
                int j;
                for (j = i; j < i + numberOfAnswers; j++)
                {
                    answers.Add(allLinesInFile[j]);
                }
                i = j;

                AddTask(numberOfAnswers, rightAnswer, question, answers, false);
            }
        }

        public void SaveTasksToFile()
        {
            List<string> tasksToFile = new List<string>();
            
            foreach (var task in Tasks)
            {
                tasksToFile.Add(task.ToStringToFile());
            }

            File.WriteAllLines(FileName, tasksToFile);
        }

        public void AddTask(int numberOfQuestions, int rightAnswer, string question, List<string> answers, bool ifToSaveToFile = true)
        {
            var newTask = new Task()
            {
                Question = question,
                NumberOfAnswers = numberOfQuestions,
                RightAnswer = rightAnswer,
                Answers = answers
            };

            Tasks.Add(newTask);

            if(ifToSaveToFile)
            {
                SaveTasksToFile();
            }
        }




    }
}
