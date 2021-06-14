using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Quiz
{
    using Quiz.Model;
    using static Quiz.Model.Quiz;
    using Quiz.ViewModel;

    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            //int index = 0;
            //QuizQuestion q = new QuizQuestion(questionField.Question, questionField.Answers);
            //q.Index = index;
            //listBox.Items.Add(q);
            //MessageBox.Show(q.Question + "\nPoprawna odpowiedź: " + q.Answers[q.Index], "Dodano pytanie do listy!");

        }

        private void RemoveButtonClick(object sender, RoutedEventArgs e)
        {
            //if (listBox.SelectedIndex > -1)
            //{
            //    var wynik = MessageBox.Show("Czy chesz usunąć to pytanie?", "U W A G A", MessageBoxButton.YesNoCancel);

            //    if (wynik == MessageBoxResult.Yes)
            //    {
            //        listBox.Items.Remove(listBox.SelectedItem);
            //        questionField.Question = "";
            //        questionField.textBox0.Text = "";
            //        questionField.textBox1.Text = "";
            //        questionField.textBox2.Text = "";
            //        questionField.textBox3.Text = "";
            //        questionField.answer0.IsChecked = false;
            //        questionField.answer1.IsChecked = false;
            //        questionField.answer2.IsChecked = false;
            //        questionField.answer3.IsChecked = false;
            //    }
            //    else
            //    {
            //        if (wynik == MessageBoxResult.No)
            //        {
            //            questionField.Question = "";
            //            questionField.textBox0.Text = "";
            //            questionField.textBox1.Text = "";
            //            questionField.textBox2.Text = "";
            //            questionField.textBox3.Text = "";
            //            questionField.answer0.IsChecked = false;
            //            questionField.answer1.IsChecked = false;
            //            questionField.answer2.IsChecked = false;
            //            questionField.answer3.IsChecked = false;
            //        }
            //    }
            //}
        }



        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {

            string destination = tbWhereToSave.Text;
            string title = quizName.Text;
            QuizQuestionsList list = new QuizQuestionsList();
            foreach (QuizQuestion q in listBox.Items)
            {
                list.Add(q);

            }

            list.SaveQuestions(destination, list);
        }

        
    }
}
