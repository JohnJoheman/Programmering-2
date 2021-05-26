using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Game_Wpf
{                   //En abstract class vid namn Question som definierar Frågetexten samt frågorna 1-4.
                    //så att jag i alla mina andra klassen kan referera och använda mig av samma namn fast med olika innehåll
                    //Jag sätter ett värde på stringen i de andra klasserna och hämtar innehållet i huvudklassen (MainWindow.xaml.cs)
                    //Jag kan använda samma string hur många gånger som helst och sätta olika värde på det sålänge det inte är i samma klass. 
    abstract class Question
    {
        public string QuestionText { get; set; }
        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public string AnswerThree { get; set; }
        public string AnswerFour { get; set; }


    }
}
