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

namespace Battleships
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int[,] buttonListPlayer1 = new int[10, 10]
        {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } ,
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } ,
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } ,
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } ,
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } ,
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } ,
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } ,
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } ,
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } ,
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } ,

          
        };

       

        public void MyGrid_Loaded(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                var row = new RowDefinition();
                row.Height = new GridLength(45);
                BattleGround.RowDefinitions.Add(row);
                var col = new ColumnDefinition();
                col.Width = new GridLength(50);
                BattleGround.ColumnDefinitions.Add(col);

                for (int j = 0; j < 10; j++)
                {
                    var button = new Button();
                    int[,] buttonListPlayer1 = new int[10, 10];
                    

                    button.Click += new RoutedEventHandler((x, y) => {
                        var Row = Grid.GetRow(button);
                        var Column = Grid.GetColumn(button);
                        buttonListPlayer1[Row, Column] = 1;

                        if (buttonListPlayer1 = 1)
                        {
                            button.Content = 1;
                        }
                    });
                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);
                    BattleGround.Children.Add(button);
                }

            }



        }

        private void MyGrid_Loaded2(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var row = new RowDefinition();
                row.Height = new GridLength(45);
                BattleGround2.RowDefinitions.Add(row);
                var col = new ColumnDefinition();
                col.Width = new GridLength(50);
                BattleGround2.ColumnDefinitions.Add(col);

                for (int j = 0; j < 10; j++)
                {
                    var button = new Button();
                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);
                    BattleGround2.Children.Add(button);
                }

            }

        }


        
        public void Game()
        {

        }


    }
}
