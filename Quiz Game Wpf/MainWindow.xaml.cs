using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Quiz_Game_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //En lista som innehåller 10st integers vilket motsvarar antalet frågor. 
        //questionNumbers är namnet på listan. 

        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //fördefinierar olika variabler så att jag slipper göra det senare i koden.

        int qNum = 0;

        int i;

        int score;


        //En class som innehåller metoder som körs under spelets gång. 
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }


        //En metod som kollar om det gissade svaret är rätt eller inte, är det rätt så ökar
        //"score" med 1. Under spelets gång så ser man hur många rätt man har hittills. 
        //Sedan så laddas "nextQuestion" för att spelet ska fortsätta med nästa fråga.
        //qNum = numret på frågan / vilken fråga det är.
        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if(qNum < 0)
            {
                qNum = 0;
            }
            
            else
            {
                qNum++;
            }


            scoreText.Content = "Answered Correctly " + score + "/" + questionNumbers.Count;

            

            NextQuestion();
        }

        //En metod som startar om spelet och nollställer score, i och qNum.
        //qNum är satt som -1 för att när man svarat på alla frågor så vill jag inte 
        //att man direkt ska börja om, utan man måste trycka en ytterliggare gång på en knapp
        //för att börja om. Sedan så startas spelet igen med hjälp av StartGame();.


        private void RestartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartGame();
        }

        //Metoden gör så att spelet fortsätter tills dess att alla frågor är besvarade. 
        //Då startar den om allting automatiskt. 
        //questionNumber.Count är hur många tal/ints listan innehåller, alltså 10 i detta fallet. 
        private void NextQuestion()
        {
            if(qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }

            //I den här metoden så sätter vi värdet på alla knappar till 0 och ger även knapparna
            //en bakgrundsfärg. Sedan finns det en switchcase som switchar mellan alla frågor och ändrar
            //innehållet på knapparna, dess värde och bilden beroende på vilken fråga.
            //varje switchcase hämtar data från olika klasser med olika innehåll.

            foreach (var x in MyCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.Yellow;
            }
            Question question;
            switch (i)
            {
                case 1:
                    question = new QuestionOne();

                    //frågetexten hämtad från QuestionOne();
                    txtQuestion.Text = question.QuestionText;

                    //de fyra olika svarsalterantiven, hämtade från QuestionOne();
                    ans1.Content = question.AnswerOne;
                    ans2.Content = question.AnswerTwo;
                    ans3.Content = question.AnswerThree;
                    ans4.Content = question.AnswerFour;

                    //bestämmer vilket av svaren som är rätt och ger det värdet 1
                    ans2.Tag = "1";

                    //hämtar en specifik bild från en mapp
                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/Audilogotyp.jpg"));

                    //avslutar caset
                    break;

                case 2:
                    question = new QuestionTwo();
                    txtQuestion.Text = question.QuestionText;


                    ans1.Content = question.AnswerOne;
                    ans2.Content = question.AnswerTwo;
                    ans3.Content = question.AnswerThree;
                    ans4.Content = question.AnswerFour;

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/dodge.jpg"));

                    break;

                case 3:

                    question = new QuestionThree();
                    txtQuestion.Text = question.QuestionText;


                    ans1.Content = question.AnswerOne;
                    ans2.Content = question.AnswerTwo;
                    ans3.Content = question.AnswerThree;
                    ans4.Content = question.AnswerFour;

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/ferrari.jpg"));

                    break;

                case 4:

                    question = new QuestionFour();
                    txtQuestion.Text = question.QuestionText;

                    ans1.Content = question.AnswerOne;
                    ans2.Content = question.AnswerTwo;
                    ans3.Content = question.AnswerThree;
                    ans4.Content = question.AnswerFour;

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/hyundai.jpg"));

                    break;

                case 5:

                    question = new QuestionFive();
                    txtQuestion.Text = question.QuestionText;

                    ans1.Content = question.AnswerOne;
                    ans2.Content = question.AnswerTwo;
                    ans3.Content = question.AnswerThree;
                    ans4.Content = question.AnswerFour;

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/koenigsegg.jpg"));

                    break;

                case 6:

                    question = new QuestionSix();
                    txtQuestion.Text = question.QuestionText;

                    ans1.Content = question.AnswerOne;
                    ans2.Content = question.AnswerTwo;
                    ans3.Content = question.AnswerThree;
                    ans4.Content = question.AnswerFour;

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/maserati.jpg"));

                    break;

                case 7:

                    question = new QuestionSeven();
                    txtQuestion.Text = question.QuestionText;

                    ans1.Content = question.AnswerOne;
                    ans2.Content = question.AnswerTwo;
                    ans3.Content = question.AnswerThree;
                    ans4.Content = question.AnswerFour;

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/mercedes.jpg"));

                    break;

                case 8:

                    question = new QuestionEight();
                    txtQuestion.Text = question.QuestionText;

                    ans1.Content = question.AnswerOne;
                    ans2.Content = question.AnswerTwo;
                    ans3.Content = question.AnswerThree;
                    ans4.Content = question.AnswerFour;

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/polestar.jpg"));

                    break;

                case 9:

                    question = new QuestionNine();
                    txtQuestion.Text = question.QuestionText;

                    ans1.Content = question.AnswerOne;
                    ans2.Content = question.AnswerTwo;
                    ans3.Content = question.AnswerThree;
                    ans4.Content = question.AnswerFour;

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/Subaru.jpg"));

                    break;

                case 10:

                    question = new QuestionTen();
                    txtQuestion.Text = question.QuestionText;

                    ans1.Content = question.AnswerOne;
                    ans2.Content = question.AnswerTwo;
                    ans3.Content = question.AnswerThree;
                    ans4.Content = question.AnswerFour;

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri("pack://application:,,,/Images/tesla.jpg"));

                    break;
            }

        }

        //En metod som startar spelet och går från fråga 1 till 10.
        private void StartGame()
        {

            

            for(int i = 0; i < questionNumbers.Count; i++)
            {
                questionNumbers[i].ToString();

               
            }
        }
    }
}
