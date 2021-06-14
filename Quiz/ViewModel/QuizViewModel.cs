using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Quiz.ViewModel
{
    using static Quiz.Model.Quiz;
    using Quiz.View;
    using BaseClass;
    using Model;
    using System.IO;
    using System.Windows.Input;
    using System.Collections.ObjectModel;

    class QuizViewModel: ViewModelBase
    {
        public QuizViewModel()
        {

        }


        private ICommand _loadButtonClick;
        public ICommand LoadButtonClick
        {
            get
            {
                if (_loadButtonClick == null)
                {
                    _loadButtonClick = new RelayCommand(arg => Load(), arg => true);
                }
                return _loadButtonClick;
            }
        }
        private void Load()
        {
            string destination = Path;
            QuizQuestionsList list = new QuizQuestionsList();
            list.LoadQuestions(@destination);
            Title = list.Title;
            
            list.listOfQuestions.Cast<QuizQuestion>().ToList().ForEach(SetFileObjectCollection());
            
            

        }



        private string _title;

        public string Title
        {
            get => _title;
            set
            {
                SetProperty(ref _title, value);
            }
        }
       
        private QuizQuestion selectedFileObjects;
        public QuizQuestion SelectedFileObject
        {
            get { return selectedFileObjects; }
            set
            {
                if (value != this.selectedFileObjects)
                    selectedFileObjects = value;
                OnPropertyChanged("SelectedFileObject");
            }
        }
 

        private ObservableCollection<QuizQuestion> fileObjectCollection;
        public ObservableCollection<QuizQuestion> FileObjectCollection
        {
            get { return fileObjectCollection; }
            set
            {
                fileObjectCollection = value;
                FileObjectCollection = fileObjectCollection;
                OnPropertyChanged("FileObjectCollection");
                
            }
        }
  
        
        private string path = @"D:\Studia\POiG\quiz\Quiz\bin\Debug\quiz.txt";
        public string Path
        {
            get { return path; }
            set
            {
                if (value != this.path)
                    path = value;
                OnPropertyChanged("Path");
            }
        }
       
       
        private Action<QuizQuestion> SetFileObjectCollection()
        {
            fileObjectCollection = new ObservableCollection<QuizQuestion>();
            return f =>
            {
                QuizQuestion temp = new QuizQuestion(f.Question, f.Answers);
                fileObjectCollection.Add(temp);
                OnPropertyChanged("FileObjectCollection");
            };
        }

        public void SelectionChanged()
        {
            string[] q=new string[]{ "","","",""};
            QuizQuestion p = new QuizQuestion("",q);

            if (FileObjectCollection.IndexOf(SelectedFileObject) > -1)
            {
                p = (QuizQuestion)SelectedFileObject;
                QuestionUpdate = p.Question;
                AnswersUpdate = p.Answers;
                
                

            }
            
        }

        private string questionUpdate;

        public string QuestionUpdate
        {
            get { return questionUpdate; }
            set
            {
                if (value != this.questionUpdate)
                    questionUpdate = value;
                OnPropertyChanged("QuestionUpdate");
            }

        }

        private string[] answersUpdate;

        public string[] AnswersUpdate
        {
            get { return answersUpdate; }
            set
            {
                if (value != this.answersUpdate)
                    answersUpdate = value;
                OnPropertyChanged("AnswersUpdate");
            }

        }


    }

    

}    

    



