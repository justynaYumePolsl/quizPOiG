
using System.Windows;
using System.Windows.Controls;


namespace Quiz.View
{
    using Quiz.Model;
    /// <summary>
    /// Logika interakcji dla klasy UserControl1.xaml
    /// </summary>
    public partial class QuestionView : UserControl
    {
        public QuestionView()
        {
            
            InitializeComponent();
            Question = "Tu wpisz pytanie...";
            Answers = new string[4];
            Answers[0] = "Odpowiedź 1";
            Answers[1] = "Odpowiedź 2";
            Answers[2] = "Odpowiedź 3";
            Answers[3] = "Odpowiedź 4";
            Index = -1;
          
        }
        public static readonly DependencyProperty QuestionProperty =
            DependencyProperty.Register(
                nameof(Question),
                typeof(string),
                typeof(QuestionView));
        public string Question
        {
            get { return (string)GetValue(QuestionProperty); }
            set { SetValue(QuestionProperty, value); }
        }

        public static readonly DependencyProperty AnswersProperty =
           DependencyProperty.Register(
               nameof(Answers),
               typeof(string[]),
               typeof(QuestionView));
        public string[] Answers
        {
            get { return (string[])GetValue(AnswersProperty); }
            set { SetValue(AnswersProperty, value); }
        }

        public static readonly DependencyProperty IndexProperty =
           DependencyProperty.Register(
               nameof(Index),
               typeof(int),
               typeof(QuestionView));
        public int Index
        {
            get { return (int)GetValue(IndexProperty); }
            set { SetValue(IndexProperty, value); }
        }

        public static readonly DependencyProperty WhichAnswerCheckedProperty =
            DependencyProperty.Register(
                nameof(WhichAnswerChecked),
                typeof(int?),
                typeof(QuestionView),
                new PropertyMetadata(new PropertyChangedCallback(ChangeChecked))
                );

        private static void ChangeChecked(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            int? newValue = (int?)e.NewValue;
            if (newValue == null)
            {
                (d as QuestionView).answer0.IsChecked = false;
                (d as QuestionView).answer1.IsChecked = false;
                (d as QuestionView).answer2.IsChecked = false;
                (d as QuestionView).answer3.IsChecked = false;
            }
            if (newValue == 0)
                (d as QuestionView).answer0.IsChecked = true;

            if (newValue == 1)
                (d as QuestionView).answer1.IsChecked = true;

            if (newValue == 2)
                (d as QuestionView).answer2.IsChecked = true;

            if (newValue == 3)
                (d as QuestionView).answer3.IsChecked = true;
        }

        public int? WhichAnswerChecked
        {
            get
            {
                return (int?)GetValue(WhichAnswerCheckedProperty);
            }
            set
            {
                SetValue(WhichAnswerCheckedProperty, value);
                //if(value != -1)
                //{
                //    if (value == 0)
                //        answer0.IsChecked = true;
                //    if (value == 1)
                //        answer1.IsChecked = true;
                //    if (value == 2)
                //        answer2.IsChecked = true;
                //    if (value == 3)
                //        answer3.IsChecked = true;
                //}
                //else
                //{
                //    answer0.IsChecked = false;
                //    answer1.IsChecked = false;
                //    answer2.IsChecked = false;
                //    answer3.IsChecked = false;
                //}
            }
        }
        private void Answer_Checked(object sender, RoutedEventArgs e)
        {
            WhichAnswerChecked = int.Parse((sender as RadioButton).Tag.ToString());
            Index = (int)WhichAnswerChecked;
            
        }
    }
}
