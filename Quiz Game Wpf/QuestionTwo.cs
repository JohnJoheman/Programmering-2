using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game_Wpf
{
    class QuestionTwo : Question
    {
        public QuestionTwo()
        {
            QuestionText = "Question 2 - Guess the brand's logo";
            AnswerOne = "Dodge";
            AnswerTwo = "Hummer";
            AnswerThree = "BMW";
            AnswerFour = "Volvo";
        }
    }
}
