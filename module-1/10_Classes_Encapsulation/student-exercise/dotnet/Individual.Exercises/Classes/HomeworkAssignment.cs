namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
		public int EarnedMarks { get; set; }      // Gets or sets the total number of correct marks submitter received on the assignment.
		public int PossibleMarks { get; private set; }                       // Gets the number of possible marks on the assignment.
		public string SubmitterName { get; private set; }                 // Gets or sets the submitter's name for the assignment.
		public string LetterGrade {

            get
			{
				double gradeA = EarnedMarks / (double)PossibleMarks;			
					if (gradeA >= 0.9) return "A";
					else if (gradeA >= 0.80 && gradeA <= 0.89) return "B";		//METHOOOOD
					else if (gradeA >= 0.7 && gradeA <= 0.79) return "C";
					else if (gradeA >= 0.6 && gradeA <= 0.69) return "D";
					else return "F";
			}
		}
		public HomeworkAssignment(int possibleMarks , string submitterName)			//CONSTRUCTOR
        {
			PossibleMarks = possibleMarks;
			SubmitterName = submitterName;
		}
	}
}
