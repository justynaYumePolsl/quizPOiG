
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Quiz.Model
{
    
        public class QuizQuestionsList
        {
            public List<QuizQuestion> listOfQuestions;
            public string Title;

            public QuizQuestionsList()
            {
                Title = "";
                listOfQuestions = new List<QuizQuestion>();
            }

            

            public void Add(QuizQuestion q) => listOfQuestions.Add(q);

            public QuizQuestion this[int index]
            {
                get { return listOfQuestions[index]; }
            }


            public void LoadQuestions(string pathToFile)
            {
                if (File.Exists(pathToFile))
                {
                    string[] lines = File.ReadAllLines(pathToFile);
                    string title = lines[0];
                    int index = -1;
                    try
                    {
                        for (int i = 1; i < lines.Length; i += 6)
                        {

                            string question = lines[i];
                            string[] answers = { lines[i + 1].Substring(2), lines[i + 2].Substring(2), lines[i + 3].Substring(2), lines[i + 4].Substring(2) };
                            if (lines[i + 1].Substring(0, 1) == "1")
                            {
                                index = 0;
                            }
                            else if (lines[i + 2].Substring(0, 1) == "1")
                            {
                                index = 1;
                            }
                            else if (lines[i + 3].Substring(0, 1) == "1")
                            {
                                index = 2;
                            }
                            else if (lines[i + 4].Substring(0, 1) == "1")
                            {
                                index = 3;
                            }
                            QuizQuestion m = new QuizQuestion(question, answers);
                            m.Index = index;
                            listOfQuestions.Add(m);
                            Title = title;
                        }
                    }
                catch (Exception e)
                {
                    MessageBox.Show("Plik nie jest w odpowiednim formacie lub jego treść jest źle sformatowana!", "B Ł Ą D");
                    listOfQuestions.Clear();
                }
                }
                else
                {
                    throw new FileNotFoundException("Nie znaleziono pliku z pytaniami.");
                }
            }

            public void SaveQuestions(string pathToFile, QuizQuestionsList list)
            { 
                if(pathToFile.Substring(pathToFile.Length - 4) != ".txt")
            {
                MessageBox.Show("Nazwa pliku musi się kończyć rozszerzeniem .txt!", "B Ł Ą D");
                return;
            }
                string text = list.Title+"\n";

                foreach (QuizQuestion q in list.listOfQuestions)
                {
                    text += q.Question + "\n";
                    for (int i = 0; i < 4; i++)
                    {
                        if (i == q.Index)
                        {
                            text += "1|" + q.Answers[i] + "\n";
                        }
                        else
                        {
                            text += "0|" + q.Answers[i] + "\n";
                        }
                    }
                    text += "**********\n";
                }
                
                File.WriteAllText(pathToFile, text);
            }
        }
}



