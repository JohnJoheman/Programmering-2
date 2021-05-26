using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game_Wpf
{
    //QuestionOne ärver från klassen Question så att jag i denna klassen kan använda mig av innehållet från klassen Question.
    //Eftersom jag i alla dessa liknande klasser ärver från Question så kan jag sätta olika värden på de strings som finns i klassen Question
    //Informationen sparas i detta fallet i QuestionOne.
    class QuestionOne : Question
    {

        //En class som sätter värde på QuestionText och Answer1-4 som ärvs från klassen Question.
        public QuestionOne()
        {
            QuestionText = "Question 1 - Guess the brand's logo";
            AnswerOne = "Volvo";
            AnswerTwo = "Audi";
            AnswerThree = "Mercedes";
            AnswerFour = "Skoda";

        }
    }
}
