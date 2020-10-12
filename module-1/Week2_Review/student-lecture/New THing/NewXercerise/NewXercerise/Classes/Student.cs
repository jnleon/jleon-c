using System;
using System.Collections.Generic;
using System.Text;

namespace NewXercerise.NewFolder
{
    class Student
    {
        //name
        private string name;
    
        public int age;
        
        public string GetName()
        {
            return name;
        }
        public void SetName(string n)
        {
            name = value;
        }
        //.NET said yo easy peasy cmon now
        public string Name { get; set; }


        //age
        private int _age;
        public int Age {
            get
            {
                return _age;
            }

        
            set 
            {
                if (value> 15 && value <200)
                _age = value;
            } 
        }

        //quizScores
    
    
    
    
    
    
    
    }
}
