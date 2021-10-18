using Krig;
using Krig.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Krig
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            #region Visibility startpage

            CardPlayer1.Visibility = Visibility.Collapsed;
            CardPlayer2.Visibility = Visibility.Collapsed;
            CardPlayer3.Visibility = Visibility.Collapsed;
            CardPlayer4.Visibility = Visibility.Collapsed;
            Player1.Visibility = Visibility.Collapsed;
            Player2.Visibility = Visibility.Collapsed;
            Player3.Visibility = Visibility.Collapsed;
            Player4.Visibility = Visibility.Collapsed;
            BtnPlay.IsEnabled = false;
            #endregion
        }

        private void BtnDeal_Click(object sender, RoutedEventArgs e)
        {
            CardDeal.GeneratePlayerHands();
            #region Visibility
            BtnDeal.IsEnabled = false;
            BtnPlay.IsEnabled = true;
            CardPlayer1.Visibility = Visibility.Visible;
            CardPlayer2.Visibility = Visibility.Visible;
            CardPlayer3.Visibility = Visibility.Visible;
            CardPlayer4.Visibility = Visibility.Visible;
            Player1.Visibility = Visibility.Visible;
            Player2.Visibility = Visibility.Visible;
            Player3.Visibility = Visibility.Visible;
            Player4.Visibility = Visibility.Visible;
            #endregion
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            Game NewGame = new Game();
            NewGame.FindWinningCard();

            #region Visibility
            string imgPlayer1 = ShowCard.ShowPlayedCard(NewGame, 1);
            string imgPlayer2 = ShowCard.ShowPlayedCard(NewGame, 2);
            string imgPlayer3 = ShowCard.ShowPlayedCard(NewGame, 3);
            string imgPlayer4 = ShowCard.ShowPlayedCard(NewGame, 4);
            Uri uriPlayer1 = new Uri(imgPlayer1);
            Uri uriPlayer2 = new Uri(imgPlayer2);
            Uri uriPlayer3 = new Uri(imgPlayer3);
            Uri uriPlayer4 = new Uri(imgPlayer4);
            CardPlayer1.Source = new BitmapImage(uriPlayer1);
            CardPlayer2.Source = new BitmapImage(uriPlayer2);
            CardPlayer3.Source = new BitmapImage(uriPlayer3);
            CardPlayer4.Source = new BitmapImage(uriPlayer4);
            TxtScore1.Content = $"Player 1: {CardDeal.ListOfPlayers[0].CardsWon.Count}";
            TxtScore2.Content = $"Player 2: {CardDeal.ListOfPlayers[1].CardsWon.Count}";
            TxtScore3.Content = $"Player 3: {CardDeal.ListOfPlayers[2].CardsWon.Count}";
            TxtScore4.Content = $"Player 4: {CardDeal.ListOfPlayers[3].CardsWon.Count}";
            #endregion

            if (NewGame.IsGameOver())
            {
                BtnPlay.IsEnabled = false;
                MessageBox.Show(NewGame.GameMessage());
                CardDeck.ListOfCards.Clear();
                CardDeck.RandomListOfCards.Clear();
                CardDeal.ListOfPlayers.Clear();
                NewGame.ListOfPlayedCards.Clear();
                MainWindow newwindow = new MainWindow();
                Application.Current.MainWindow = newwindow;
                newwindow.Show();
                this.Close();
            }
        }
    }
}


