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

        private void buttonUncheckCheckboxes_Click(object sender, RoutedEventArgs e)
        {
            checkBox1.IsChecked = false;
            checkBox2.IsChecked = false;
            checkBox3.IsChecked = false;
            checkBox4.IsChecked = false;
            checkBox5.IsChecked = false;
            checkBox6.IsChecked = false;
        }

        private void buttonCalculatePointsP1_Click(object sender, RoutedEventArgs e)
        {
            int totalPoints = 0;
            int.TryParse(sumPlayer1.Text, out int sum);
            int.TryParse(bonusPlayer1.Text, out int bonus);
            int.TryParse(onePairPlayer1.Text, out int onePair);
            int.TryParse(twoPairsPlayer1.Text, out int twoPairs);
            int.TryParse(threePairsPlayer1.Text, out int threePairs);
            int.TryParse(threeOfAKindPlayer1.Text, out int threeOfAKind);
            int.TryParse(fourOfAKindPlayer1.Text, out int fourOfAKind);
            int.TryParse(twoXThreeOfAKindPlayer1.Text, out int twoXThreeOfAKind);
            int.TryParse(smallStraightPlayer1.Text, out int smallStraight);
            int.TryParse(largeStraightPlayer1.Text, out int largeStraight);
            int.TryParse(royalStraightPlayer1.Text, out int royalStraight);
            int.TryParse(fullHousePlayer1.Text, out int fullHouse);
            int.TryParse(chancePlayer1.Text, out int chance);
            int.TryParse(yatzyPlayer1.Text, out int yatzy);
            totalPoints = (sum + bonus + onePair + twoPairs + threePairs + threeOfAKind + fourOfAKind + 
                twoXThreeOfAKind + smallStraight + largeStraight + royalStraight + fullHouse + chance + yatzy);
            totalPointsPlayer1.Text = totalPoints.ToString(); 

        }

        private void buttonCalculatePointsP2_Click(object sender, RoutedEventArgs e)
        {
            int totalPoints = 0;
            int.TryParse(sumPlayer2.Text, out int sum);
            int.TryParse(bonusPlayer2.Text, out int bonus);
            int.TryParse(onePairPlayer2.Text, out int onePair);
            int.TryParse(twoPairsPlayer2.Text, out int twoPairs);
            int.TryParse(threePairsPlayer2.Text, out int threePairs);
            int.TryParse(threeOfAKindPlayer2.Text, out int threeOfAKind);
            int.TryParse(fourOfAKindPlayer2.Text, out int fourOfAKind);
            int.TryParse(twoXThreeOfAKindPlayer2.Text, out int twoXThreeOfAKind);
            int.TryParse(smallStraightPlayer2.Text, out int smallStraight);
            int.TryParse(largeStraightPlayer2.Text, out int largeStraight);
            int.TryParse(royalStraightPlayer2.Text, out int royalStraight);
            int.TryParse(fullHousePlayer2.Text, out int fullHouse);
            int.TryParse(chancePlayer2.Text, out int chance);
            int.TryParse(yatzyPlayer2.Text, out int yatzy);
            totalPoints = (sum + bonus + onePair + twoPairs + threePairs + threeOfAKind + fourOfAKind +
                twoXThreeOfAKind + smallStraight + largeStraight + royalStraight + fullHouse + chance + yatzy);
            totalPointsPlayer2.Text = totalPoints.ToString();
        }

        private void buttonCalculatePointsP3_Click(object sender, RoutedEventArgs e)
        {
            int totalPoints = 0;
            int.TryParse(sumPlayer3.Text, out int sum);
            int.TryParse(bonusPlayer3.Text, out int bonus);
            int.TryParse(onePairPlayer3.Text, out int onePair);
            int.TryParse(twoPairsPlayer3.Text, out int twoPairs);
            int.TryParse(threePairsPlayer3.Text, out int threePairs);
            int.TryParse(threeOfAKindPlayer3.Text, out int threeOfAKind);
            int.TryParse(fourOfAKindPlayer3.Text, out int fourOfAKind);
            int.TryParse(twoXThreeOfAKindPlayer3.Text, out int twoXThreeOfAKind);
            int.TryParse(smallStraightPlayer3.Text, out int smallStraight);
            int.TryParse(largeStraightPlayer3.Text, out int largeStraight);
            int.TryParse(royalStraightPlayer3.Text, out int royalStraight);
            int.TryParse(fullHousePlayer3.Text, out int fullHouse);
            int.TryParse(chancePlayer3.Text, out int chance);
            int.TryParse(yatzyPlayer3.Text, out int yatzy);
            totalPoints = (sum + bonus + onePair + twoPairs + threePairs + threeOfAKind + fourOfAKind +
                twoXThreeOfAKind + smallStraight + largeStraight + royalStraight + fullHouse + chance + yatzy);
            totalPointsPlayer3.Text = totalPoints.ToString();
        }

        private void buttonCalculatePointsP4_Click(object sender, RoutedEventArgs e)
        {
            int totalPoints = 0;
            int.TryParse(sumPlayer4.Text, out int sum);
            int.TryParse(bonusPlayer4.Text, out int bonus);
            int.TryParse(onePairPlayer4.Text, out int onePair);
            int.TryParse(twoPairsPlayer4.Text, out int twoPairs);
            int.TryParse(threePairsPlayer4.Text, out int threePairs);
            int.TryParse(threeOfAKindPlayer4.Text, out int threeOfAKind);
            int.TryParse(fourOfAKindPlayer4.Text, out int fourOfAKind);
            int.TryParse(twoXThreeOfAKindPlayer4.Text, out int twoXThreeOfAKind);
            int.TryParse(smallStraightPlayer4.Text, out int smallStraight);
            int.TryParse(largeStraightPlayer4.Text, out int largeStraight);
            int.TryParse(royalStraightPlayer4.Text, out int royalStraight);
            int.TryParse(fullHousePlayer4.Text, out int fullHouse);
            int.TryParse(chancePlayer4.Text, out int chance);
            int.TryParse(yatzyPlayer4.Text, out int yatzy);
            totalPoints = (sum + bonus + onePair + twoPairs + threePairs + threeOfAKind + fourOfAKind +
                twoXThreeOfAKind + smallStraight + largeStraight + royalStraight + fullHouse + chance + yatzy);
            totalPointsPlayer4.Text = totalPoints.ToString();
        }
    }
}