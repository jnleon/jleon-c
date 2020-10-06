using System;
using System.Collections.Generic;
using System.IO;

namespace file_io_part1_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
C:\Users\Student\workspace\jleon-c\module-1\17_FileIO_Reading_in\student-exercise\dotnet\sample-quiz-file.txt

C:\Users\Student\workspace\jleon-c\module-1\17_FileIO_Reading_in\student-exercise\dotnet\another_quiz.txt
             */

            Console.WriteLine("Enter the fully qualified name of the file to read in for quiz questions");
            string filePath = Console.ReadLine();

            using (StreamReader sr = new StreamReader(filePath))
            {
                int correctOnes = 0;
                int numberQuestions = 0;

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] splitLine = line.Split("|");
                    string question = (splitLine[0]);
                    int correctAnswer = 0;

                    List<string> answer1 = new List<string>();

                    for (int i = 1; i < splitLine.Length; i++)
                    {
                        answer1.Add(splitLine[i]);
                    }

                    Console.WriteLine(question);

                    for (int i = 0; i < answer1.Count; i++)
                    {
                        if (answer1[i].EndsWith("*"))
                        {
                            Console.WriteLine(i + 1 + ". " + answer1[i].Substring(0, splitLine.Length - 1));
                            continue;
                        }
                        Console.WriteLine(i + 1 + ". " + answer1[i]);
                    }

                    correctAnswer = answer1.FindIndex(x => x.EndsWith("*")) + 1;

                    Console.WriteLine("Your answer:");
                    int hello = Convert.ToInt32(Console.ReadLine());

                    if (hello == correctAnswer)
                    {
                        numberQuestions++;
                        correctOnes++;
                        Console.WriteLine("RIGHT!");
                    }
                    else
                    {
                        numberQuestions++;
                        Console.WriteLine("WRONG!");
                    }
                    Console.WriteLine("You got {0} answer(s) correct out of the {1} questions asked.", correctOnes, numberQuestions);
                }
            }
        }
    }
}

