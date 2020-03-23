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
        int currPlayerTurn = 1;
        int rounds = 0;
        int diceRolls = 0;
        int numberOfPlayers;
        int playerNamesTypedIn = 0;

        private void buttonRollDices_Click(object sender, RoutedEventArgs e)
        {
            diceRolls++;
            if(diceRolls >= 4 && numberOfPlayers > 0)
            {
                MessageBox.Show("Du må ikke slå terningerne mere end 3 gange! Afslut din tur.");
            }
            else
            {
                RollDice(dice1, checkBox1);
                RollDice(dice2, checkBox2);
                RollDice(dice3, checkBox3);
                RollDice(dice4, checkBox4);
                RollDice(dice5, checkBox5);
                RollDice(dice6, checkBox6);
                if(numberOfPlayers > 0)
                {
                    buttonEndTurn.IsEnabled = true;
                }
                else
                {
                    buttonEndTurn.IsEnabled = false;
                }
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
            int sum = 0;

            foreach(TextBox textbox in pointsPlayer1.Children.OfType<TextBox>())
            {
                int.TryParse(textbox.Text, out int points);
                if(textbox == acesPlayer1 || textbox == twosPlayer1 || textbox == threesPlayer1 || textbox == foursPlayer1 || textbox == fivesPlayer1 || textbox == sixesPlayer1)
                {
                    sum += points;
                    if(sum >= 84)
                    {
                        bonusPlayer1.Text = "50";
                    }
                    else
                    {
                        bonusPlayer1.Text = "";
                    }
                }
                if(textbox != sumPlayer1 && textbox != totalPointsPlayer1)
                {
                    totalPoints += points;
                }
            }
            sumPlayer1.Text = sum.ToString();
            totalPointsPlayer1.Text = totalPoints.ToString();
            if(rounds == 17)
            {
                CheckWinner();
            }
        }

        private void buttonCalculatePointsP2_Click(object sender, RoutedEventArgs e)
        {
            int totalPoints = 0;
            int sum = 0;

            foreach(TextBox textbox in pointsPlayer2.Children.OfType<TextBox>())
            {
                int.TryParse(textbox.Text, out int points);
                if(textbox == acesPlayer2 || textbox == twosPlayer2 || textbox == threesPlayer2 || textbox == foursPlayer2 || textbox == fivesPlayer2 || textbox == sixesPlayer2)
                {
                    sum += points;
                    if(sum >= 84)
                    {
                        bonusPlayer2.Text = "50";
                    }
                    else
                    {
                        bonusPlayer2.Text = "";
                    }
                }
                if(textbox != sumPlayer2 && textbox != totalPointsPlayer2)
                {
                    totalPoints += points;
                }
            }
            sumPlayer2.Text = sum.ToString();
            totalPointsPlayer2.Text = totalPoints.ToString();
            if(rounds == 17)
            {
                CheckWinner();
            }
        }

        private void buttonCalculatePointsP3_Click(object sender, RoutedEventArgs e)
        {
            int totalPoints = 0;
            int sum = 0;

            foreach(TextBox textbox in pointsPlayer3.Children.OfType<TextBox>())
            {
                int.TryParse(textbox.Text, out int points);
                if(textbox == acesPlayer3 || textbox == twosPlayer3 || textbox == threesPlayer3 || textbox == foursPlayer3 || textbox == fivesPlayer3 || textbox == sixesPlayer3)
                {
                    sum += points;
                    if(sum >= 84)
                    {
                        bonusPlayer3.Text = "50";
                    }
                    else
                    {
                        bonusPlayer3.Text = "";
                    }
                }
                if(textbox != sumPlayer3 && textbox != totalPointsPlayer3)
                {
                    totalPoints += points;
                }
            }
            sumPlayer3.Text = sum.ToString();
            totalPointsPlayer3.Text = totalPoints.ToString();
            if(rounds == 17)
            {
                CheckWinner();
            }
        }

        private void buttonCalculatePointsP4_Click(object sender, RoutedEventArgs e)
        {
            int totalPoints = 0;
            int sum = 0;

            foreach(TextBox textbox in pointsPlayer4.Children.OfType<TextBox>())
            {
                int.TryParse(textbox.Text, out int points);
                if(textbox == acesPlayer4 || textbox == twosPlayer4 || textbox == threesPlayer4 || textbox == foursPlayer4 || textbox == fivesPlayer4 || textbox == sixesPlayer4)
                {
                    sum += points;
                    if(sum >= 84)
                    {
                        bonusPlayer4.Text = "50";
                    }
                    else
                    {
                        bonusPlayer4.Text = "";
                    }
                }
                if(textbox != sumPlayer4 && textbox != totalPointsPlayer4)
                {
                    totalPoints += points;
                }
            }
            sumPlayer4.Text = sum.ToString();
            totalPointsPlayer4.Text = totalPoints.ToString();
            if(rounds == 17) 
            {
                CheckWinner();
            }
        }

        private void buttonStartNewGame_Click(object sender, RoutedEventArgs e)
        {
            foreach(TextBox textBox in pointsPlayer1.Children.OfType<TextBox>())
            {
              textBox.Text = "";
            }
            foreach(TextBox textBox in pointsPlayer2.Children.OfType<TextBox>())
            {
                textBox.Text = "";
            }
            foreach(TextBox textBox in pointsPlayer3.Children.OfType<TextBox>())
            {
                textBox.Text = "";
            }
            foreach(TextBox textBox in pointsPlayer4.Children.OfType<TextBox>())
            {
                textBox.Text = "";
            }
            menuBorder.BorderThickness = new Thickness(2);
            menu.Visibility = Visibility.Visible;
            textBlockCurrentTurn.Text = "";
            player1Name.Text = "Spiller 1";
            player2Name.Text = "Spiller 2";
            player3Name.Text = "Spiller 3";
            player4Name.Text = "Spiller 4";
            gridYatzy.IsEnabled = false;
            buttonRollDices.IsEnabled = true;
            buttonEndTurn.IsEnabled = true;
            pointsPlayer1.IsEnabled = true;
            pointsPlayer2.IsEnabled = true;
            pointsPlayer3.IsEnabled = true;
            pointsPlayer4.IsEnabled = true;
            buttonEndTurn.IsEnabled = false;
            diceRolls = 0;
            currPlayerTurn = 1;
            rounds = 0;
            numberOfPlayers = 0;
            playerNamesTypedIn = 0;
        }

        private void ComboBoxSelectNoUfPlayers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            startGame.IsEnabled = true;
        }

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
            textBlockPlayerNumber.Text = "Indtast spiller 1's navn:";
            playerNameInput.Text = "";
        }

        private void buttonPlayerNameInput_Click(object sender, RoutedEventArgs e)
        {
            if(playerNamesTypedIn == 0)
            {
                textBlockPlayerNumber.Text = "Indtast spiller 1's navn:";
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
                        pointsPlayer2.IsEnabled = false;
                        pointsPlayer3.IsEnabled = false;
                        pointsPlayer4.IsEnabled = false;
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
                        pointsPlayer2.IsEnabled = false;
                        pointsPlayer3.IsEnabled = false;
                        pointsPlayer4.IsEnabled = false;
                    }
                }
            }
            else if(numberOfPlayers < 3 && playerNamesTypedIn == 2)
            {
                menuBorder.BorderThickness = new Thickness(0);
                playerNameMenu.Visibility = Visibility.Hidden;
                gridYatzy.IsEnabled = true;
                textBlockCurrentTurn.Text = $"{player1Name.Text}'s tur";
                pointsPlayer2.IsEnabled = false;
                pointsPlayer3.IsEnabled = false;
                pointsPlayer4.IsEnabled = false;
            }
        }


        private void buttonEndTurn_Click(object sender, RoutedEventArgs e)
        {
            diceRolls = 0;
            buttonEndTurn.IsEnabled = false;
            currPlayerTurn++;
            if(currPlayerTurn == 2)
            {
                textBlockCurrentTurn.Text = $"{player2Name.Text}'s tur";
                pointsPlayer1.IsEnabled = false;
                pointsPlayer2.IsEnabled = true;
            }
            else if(numberOfPlayers >= 3 && currPlayerTurn == 3)
            {
                textBlockCurrentTurn.Text = $"{player3Name.Text}'s tur";
                pointsPlayer2.IsEnabled = false;
                pointsPlayer3.IsEnabled = true;
            }
            else if(numberOfPlayers == 4 && currPlayerTurn == 4)
            {
                textBlockCurrentTurn.Text = $"{player4Name.Text}'s tur";
                pointsPlayer3.IsEnabled = false;
                pointsPlayer4.IsEnabled = true;
            }
            else
            {
                if(rounds < 17)
                {
                    currPlayerTurn = 1;
                    textBlockCurrentTurn.Text = $"{player1Name.Text}'s tur";
                    pointsPlayer4.IsEnabled = false;
                    pointsPlayer1.IsEnabled = true;
                    rounds++;
                }
                else
                {
                    textBlockCurrentTurn.Text = "Spillet er slut. Udregn jeres point";
                    buttonRollDices.IsEnabled = false;
                    buttonEndTurn.IsEnabled = false;
                    pointsPlayer1.IsEnabled = false;
                    pointsPlayer2.IsEnabled = false;
                    pointsPlayer3.IsEnabled = false;
                    pointsPlayer4.IsEnabled = false;
                }
            }
        }
        private void CheckWinner()
        {
            int.TryParse(totalPointsPlayer1.Text, out int player1points);
            int.TryParse(totalPointsPlayer2.Text, out int player2points);
            int.TryParse(totalPointsPlayer3.Text, out int player3points);
            int.TryParse(totalPointsPlayer4.Text, out int player4points);
            if(numberOfPlayers == 2)
            {
                if(player1points != 0 && player2points != 0)
                {
                    if(player1points > player2points)
                    {
                        textBlockCurrentTurn.Text = $"{player1Name.Text} har vundet!";
                    }
                    else if(player2points > player1points)
                    {
                        textBlockCurrentTurn.Text = $"{player2Name.Text} har vundet!";
                    }
                    else
                    {
                        textBlockCurrentTurn.Text = "Spillet er uafgjort!";
                    }
                }
            }
            else if(numberOfPlayers == 3) 
            {
                if(player1points != 0 && player2points != 0 && player3points != 0)
                {
                    if(player1points > player2points && player1points > player3points)
                    {
                        textBlockCurrentTurn.Text = $"{player1Name.Text} har vundet!";
                    }
                    else if(player2points > player1points && player2points > player3points)
                    {
                        textBlockCurrentTurn.Text = $"{player2Name.Text} har vundet!";
                    }
                    else if(player3points > player1points && player3points > player2points)
                    {
                        textBlockCurrentTurn.Text = $"{player3Name.Text} har vundet!";
                    }
                    else
                    {
                        textBlockCurrentTurn.Text = "Spillet er uafgjort!";
                    }
                }
            }
            else if(numberOfPlayers == 4)
            {
                if(player1points != 0 && player2points != 0 && player3points != 0 && player4points != 0)
                {
                    if(player1points > player2points && player1points > player3points && player1points > player4points)
                    {
                        textBlockCurrentTurn.Text = $"{player1Name.Text} har vundet!";
                    }
                    else if(player2points > player1points && player2points > player3points && player2points > player4points)
                    {
                        textBlockCurrentTurn.Text = $"{player2Name.Text} har vundet!";
                    }
                    else if(player3points > player1points && player3points > player2points && player3points > player4points)
                    {
                        textBlockCurrentTurn.Text = $"{player3Name.Text} har vundet!";
                    }
                    else if(player4points > player1points && player4points > player2points && player4points > player3points)
                    {
                        textBlockCurrentTurn.Text = $"{player4Name.Text} har vundet!";
                    }
                    else
                    {
                        textBlockCurrentTurn.Text = "Spillet er uafgjort!";
                    }
                }
            }
        }
    }
}