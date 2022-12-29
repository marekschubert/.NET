using System.Text;

namespace Quiz.Core
{
    public class Task
    {
        public List<string> Answers { get; set; }
        public string Question { get; set; }
        public int NumberOfAnswers { get; set; }
        public int RightAnswer { get; set; }


        public string ToStringToFile()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(NumberOfAnswers.ToString() + "," + RightAnswer.ToString()).AppendLine();
            stringBuilder.Append(Question).AppendLine();

            foreach (var answer in Answers)
            {
                stringBuilder.Append(answer).AppendLine();
            }
            return stringBuilder.ToString();
        }

        public override string? ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Question).AppendLine();

            char letter = 'a';
            foreach (var answer in Answers)
            {
                stringBuilder.Append(letter).Append(". ").Append(answer).AppendLine();
                letter++;
            }

            return stringBuilder.ToString();
        }
    }
}
