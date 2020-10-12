using System;
using System.Collections.Generic;
using System.Text;

namespace file_io_part1_exercises
{
    public class QuizQuestion
    {

        public string QuestionTest { get; set; }

        public string CorrectAnswer { get; set; }

        public List<string> Answers { get; set; } = new List<string>();


        public QuizQuestion(string question )
        {
            string[] splitLine = question.Split("|");
            QuestionTest = (splitLine[0]);
        
            
            for (int i = 1; i < splitLine.Length; i++)
            {

                if (splitLine[i].EndsWith("*"))
                {
                    CorrectAnswer = i +". " + splitLine[i].Replace("*", "");
                    Answers.Add(CorrectAnswer);
                }
                else
                {
                    Answers.Add(i + ". " + splitLine[i]);
                }
            }
        }
    }
}
