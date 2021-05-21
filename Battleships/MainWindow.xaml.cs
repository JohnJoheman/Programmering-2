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

        private void MyGrid_Loaded(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                var row = new RowDefinition();
                row.Height = new GridLength(46);
                BattleGround.RowDefinitions.Add(row);
                var col = new ColumnDefinition();
                col.Width = new GridLength(55);
                BattleGround.ColumnDefinitions.Add(col);

                for (int j = 0; j < 10; j++)
                {
                    var button = new Button();
                    button.Click += new RoutedEventHandler((x, y) => {
                        button.Content = "Hit";
                    });
                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);
                    BattleGround.Children.Add(button);
                }

            }
        }

        
    }
}
