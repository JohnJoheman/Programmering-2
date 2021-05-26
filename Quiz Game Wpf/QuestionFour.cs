using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game_Wpf
{
    class QuestionFour : Question
    {
        public QuestionFour()
        {
            QuestionText = "Question 4 - Guess the brand's logo";
            AnswerOne = "Toyota";
            AnswerTwo = "Peugeot";
            AnswerThree = "Hyundai";
            AnswerFour = "Honda";
        }
    }
}
