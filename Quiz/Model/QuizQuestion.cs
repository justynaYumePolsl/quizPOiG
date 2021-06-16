namespace Quiz.Model
{
    public class QuizQuestion
    {
        public string Question { get; set; }
        public string[] Answers { get; set; }
        public int Index { get; set; }

        public QuizQuestion(string q, string[] a)
        {
            Question = q;
            Answers = a;
            
        }

        public override string ToString()
        {
            return $"{Question}, 1){Answers[0]}, 2){Answers[1]}, 3){Answers[2]}, 4){Answers[3]}, Poprawna:{Index+1}";
        }

       
    }
}
