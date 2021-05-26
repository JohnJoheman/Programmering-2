using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game_Wpf
{
    class QuestionTen : Question
    {
        public QuestionTen()
        {
            QuestionText = "Question 1 - Guess the brand's logo";
            AnswerOne = "Tesla";
            AnswerTwo = "Kia";
            AnswerThree = "Renault";
            AnswerFour = "Volkswagen";
        }
    }
}
