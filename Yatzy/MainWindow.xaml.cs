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

        int diceRolls = 0;
        private void buttonRollDices_Click(object sender, RoutedEventArgs e)
        {
            diceRolls++;            
            if(diceRolls < 4)
            {
                RollDice(dice1, checkBox1);
                RollDice(dice2, checkBox2);
                RollDice(dice3, checkBox3);
                RollDice(dice4, checkBox4);
                RollDice(dice5, checkBox5);
                RollDice(dice6, checkBox6);
                buttonEndTurn.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Du må ikke slå terningerne mere end 3 gange! Afslut din tur.");
            }
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
            int.TryParse(acesPlayer1.Text, out int aces);
            int.TryParse(twosPlayer1.Text, out int twos);
            int.TryParse(threesPlayer1.Text, out int threes);
            int.TryParse(foursPlayer1.Text, out int fours);
            int.TryParse(fivesPlayer1.Text, out int fives);
            int.TryParse(sixesPlayer1.Text, out int sixes);
            sumPlayer1.Text = (aces + twos + threes + fours + fives + sixes).ToString();
            int.TryParse(sumPlayer1.Text, out int sum);

            if(sum >= 84)
            {
                bonusPlayer1.Text = "50";
            }
            else
            {
                bonusPlayer1.Text = "";
            }

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
            int.TryParse(acesPlayer2.Text, out int aces);
            int.TryParse(twosPlayer2.Text, out int twos);
            int.TryParse(threesPlayer2.Text, out int threes);
            int.TryParse(foursPlayer2.Text, out int fours);
            int.TryParse(fivesPlayer2.Text, out int fives);
            int.TryParse(sixesPlayer2.Text, out int sixes);
            sumPlayer2.Text = (aces + twos + threes + fours + fives + sixes).ToString();
            int.TryParse(sumPlayer2.Text, out int sum);

            if(sum >= 84)
            {
                bonusPlayer2.Text = "50";
            }
            else
            {
                bonusPlayer2.Text = "";
            }

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
            int.TryParse(acesPlayer3.Text, out int aces);
            int.TryParse(twosPlayer3.Text, out int twos);
            int.TryParse(threesPlayer3.Text, out int threes);
            int.TryParse(foursPlayer3.Text, out int fours);
            int.TryParse(fivesPlayer3.Text, out int fives);
            int.TryParse(sixesPlayer3.Text, out int sixes);
            sumPlayer3.Text = (aces + twos + threes + fours + fives + sixes).ToString();
            int.TryParse(sumPlayer3.Text, out int sum);

            if(sum >= 84)
            {
                bonusPlayer3.Text = "50";
            }
            else
            {
                bonusPlayer3.Text = "";
            }

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
            int.TryParse(acesPlayer4.Text, out int aces);
            int.TryParse(twosPlayer4.Text, out int twos);
            int.TryParse(threesPlayer4.Text, out int threes);
            int.TryParse(foursPlayer4.Text, out int fours);
            int.TryParse(fivesPlayer4.Text, out int fives);
            int.TryParse(sixesPlayer4.Text, out int sixes);
            sumPlayer4.Text = (aces + twos + threes + fours + fives + sixes).ToString();
            int.TryParse(sumPlayer4.Text, out int sum);

            if(sum >= 84)
            {
                bonusPlayer4.Text = "50";
            }
            else
            {
                bonusPlayer4.Text = "";
            }

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

        private void buttonNullifyScoreBlock_Click(object sender, RoutedEventArgs e)
        {
            foreach(TextBox textBox in gridScoreBlock.Children.OfType<TextBox>())
            {
                if(((SolidColorBrush)textBox.Background).Color != Colors.LightGray)
                {
                    textBox.Text = "";
                }
            }
        }

        private void ComboBoxSelectNoUfPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            startGame.IsEnabled = true;
        }
        int numberOfPlayers;
        private void startGame_Click(object sender, RoutedEventArgs e)
        {

            if(ComboBoxSelectNoUfPlayers.SelectedItem == testMode)
            {
                menuBorder.BorderThickness = new Thickness(0);
                menu.Visibility = Visibility.Hidden;
                gridYatzy.IsEnabled = true;
            }
            else if(ComboBoxSelectNoUfPlayers.SelectedItem == twoPlayers)
            {
                numberOfPlayers = 2;
                menu.Visibility = Visibility.Hidden;
                playerNameMenu.Visibility = Visibility.Visible;
            }
            else if(ComboBoxSelectNoUfPlayers.SelectedItem == threePlayers)
            {
                numberOfPlayers = 3;
                menu.Visibility = Visibility.Hidden;
                playerNameMenu.Visibility = Visibility.Visible;
            }
            else if(ComboBoxSelectNoUfPlayers.SelectedItem == fourPlayers)
            {
                numberOfPlayers = 4;
                menu.Visibility = Visibility.Hidden;
                playerNameMenu.Visibility = Visibility.Visible;
            }
        }
        int playerNamesTypedIn = 0;
        private void buttonPlayerNameInput_Click(object sender, RoutedEventArgs e)
        {
            if(playerNamesTypedIn == 0)
            {
                if(playerNameInput.Text != "")
                {
                    player1Name.Text = playerNameInput.Text;
                    playerNameInput.Text = "";
                    playerNamesTypedIn++;
                }
            }
            if(playerNamesTypedIn == 1)
            {
                textBlockPlayerNumber.Text = "Indtast spiller 2's navn:";
                if(playerNameInput.Text != "")
                {
                    player2Name.Text = playerNameInput.Text;
                    playerNameInput.Text = "";
                    playerNamesTypedIn++;
                }
            }
            if(numberOfPlayers == 3)
            {
                if(playerNamesTypedIn == 2)
                {
                    textBlockPlayerNumber.Text = "Indtast spiller 3's navn:";
                    if(playerNameInput.Text != "")
                    {
                        player3Name.Text = playerNameInput.Text;
                        menuBorder.BorderThickness = new Thickness(0);
                        playerNameMenu.Visibility = Visibility.Hidden;
                        gridYatzy.IsEnabled = true;
                        textBlockCurrentTurn.Text = $"{player1Name.Text}'s tur";
                    }
                }
            }
            else if(numberOfPlayers == 4)
            {
                if(playerNamesTypedIn == 2)
                {
                    textBlockPlayerNumber.Text = "Indtast spiller 3's navn:";
                    if(playerNameInput.Text != "")
                    {
                        player3Name.Text = playerNameInput.Text;
                        playerNameInput.Text = "";
                        playerNamesTypedIn++;
                    }
                }
                if(playerNamesTypedIn == 3)
                {
                    textBlockPlayerNumber.Text = "Indtast spiller 4's navn:";
                    if(playerNameInput.Text != "")
                    {
                        player4Name.Text = playerNameInput.Text;
                        menuBorder.BorderThickness = new Thickness(0);
                        playerNameMenu.Visibility = Visibility.Hidden;
                        gridYatzy.IsEnabled = true;
                        textBlockCurrentTurn.Text = $"{player1Name.Text}'s tur";
                    }
                }
            }
            else if(numberOfPlayers < 3 && playerNamesTypedIn == 2)
            {
                menuBorder.BorderThickness = new Thickness(0);
                playerNameMenu.Visibility = Visibility.Hidden;
                gridYatzy.IsEnabled = true;
                textBlockCurrentTurn.Text = $"{player1Name.Text}'s tur";
            }
        }

        int currPlayerTurn = 1;
        private void buttonEndTurn_Click(object sender, RoutedEventArgs e)
        {
            diceRolls = 0;
            buttonEndTurn.IsEnabled = false;
            currPlayerTurn++;
            if(currPlayerTurn == 2) 
            {
                textBlockCurrentTurn.Text = $"{player2Name.Text}'s tur";
            }
            else if(numberOfPlayers >= 3 && currPlayerTurn == 3) 
            {
                textBlockCurrentTurn.Text = $"{player3Name.Text}'s tur";
            }
            else if(numberOfPlayers == 4 && currPlayerTurn == 4) 
            {
                textBlockCurrentTurn.Text = $"{player4Name.Text}'s tur";
            }
            else
            { 
                currPlayerTurn = 1;
                textBlockCurrentTurn.Text = $"{player1Name.Text}'s tur";
            }
        }
    }
}