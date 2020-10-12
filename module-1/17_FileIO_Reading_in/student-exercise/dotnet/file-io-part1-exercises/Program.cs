using System;
using System.Collections.Generic;
using System.IO;

namespace file_io_part1_exercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
C:\Users\Student\workspace\jleon-c\module-1\17_FileIO_Reading_in\student-exercise\dotnet\sample-quiz-file.txt

C:\Users\Student\workspace\jleon-c\module-1\17_FileIO_Reading_in\student-exercise\dotnet\another_quiz.txt
             */

            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions");
            string filePath = Console.ReadLine();

            List<QuizQuestion> quizQuestions = new List<QuizQuestion>();
            int correctans = 0;
            int bruh = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    QuizQuestion MethodQuestion = new QuizQuestion(line);
                    quizQuestions.Add(MethodQuestion);
                }
              
            }
            foreach (QuizQuestion question in quizQuestions)
            {
                Console.WriteLine(question.QuestionTest);
                foreach(string answers in question.Answers)
                {
                    Console.WriteLine(answers);
                }
                string correctMaybe = Console.ReadLine();


                Console.WriteLine("Your answer : {0}" ,correctMaybe);
                
                if (correctMaybe == question.CorrectAnswer[0].ToString())
                {
                    bruh++;
                    correctans++;
                    Console.WriteLine("RIGHT");
                }
                else
                {
                    bruh++;
                    Console.WriteLine("WRONG");
                }
            }
            Console.WriteLine("You got {0} answer(s) correct out of the {1} questions asked.", correctans, bruh);
        }
    }
}

