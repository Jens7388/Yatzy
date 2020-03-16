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

namespace Yatzy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonRollDices_Click(object sender, RoutedEventArgs e)
        {
            RollDice(dice1, checkBox1);
            RollDice(dice2, checkBox2);
            RollDice(dice3, checkBox3);
            RollDice(dice4, checkBox4);
            RollDice(dice5, checkBox5);
            RollDice(dice6, checkBox6);
        }
        private void RollDice(Rectangle dice, CheckBox checkBox)
        {
            Random diceRoll = new Random();
            if(checkBox.IsChecked == false)
            {
                int diceRollResult = diceRoll.Next(1, 7);
                switch(diceRollResult)
                {
                    case 1:
                        dice.Fill = new ImageBrush
                        {
                            ImageSource = new BitmapImage(new Uri(@"C:\tilyatzy\1.bmp"))
                        };
                        break;
                    case 2:
                        dice.Fill = new ImageBrush
                        {
                            ImageSource = new BitmapImage(new Uri(@"C:\tilyatzy\2.bmp"))
                        };
                        break;
                    case 3:
                        dice.Fill = new ImageBrush
                        {
                            ImageSource = new BitmapImage(new Uri(@"C:\tilyatzy\3.bmp"))
                        };
                        break;
                    case 4:
                        dice.Fill = new ImageBrush
                        {
                            ImageSource = new BitmapImage(new Uri(@"C:\tilyatzy\4.bmp"))
                        };
                        break;
                    case 5:
                        dice.Fill = new ImageBrush
                        {
                            ImageSource = new BitmapImage(new Uri(@"C:\tilyatzy\5.bmp"))
                        };
                        break;
                    case 6:
                        dice.Fill = new ImageBrush
                        {
                            ImageSource = new BitmapImage(new Uri(@"C:\tilyatzy\6.bmp"))
                        };
                        break;
                }
            }
        }
    }
}