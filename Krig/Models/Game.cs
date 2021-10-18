using System.Collections.Generic;
using System.Linq;

namespace Krig.Models
{
    public class Game
    {
        internal List<Card> ListOfPlayedCards = new List<Card>();
        internal void FindWinningCard()
        {
            int winningCard = 0;
            for (int i = 0; i < CardDeal.userInput; i++)
            {
                if (CardDeal.ListOfPlayers[i].PlayersHand.Count > 0)
                {
                    ListOfPlayedCards.Add(CardDeal.ListOfPlayers[i].PlayersHand.Pop());
                }
            }
            
            foreach (var card in ListOfPlayedCards)
            {
                if (card.CardValue > winningCard)
                {
                    winningCard = card.CardValue;
                }
            }
            ScoreMethod(winningCard);
        }
        private void ScoreMethod(int winningCard)
        {
            for (int i = 0; i < ListOfPlayedCards.Count; i++)
            {
                if (ListOfPlayedCards[i].CardValue == winningCard) 
                {
                    CardDeal.ListOfPlayers[i].CardsWon.Enqueue(ListOfPlayedCards[i]);
                }
            }
        }
        internal bool IsGameOver()
        {
            for (int i = 0; i < ListOfPlayedCards.Count; i++)
            {
                if (CardDeal.ListOfPlayers[i].PlayersHand.Count == 0)
                {
                    return true;
                }
            }
            return false;
        }
        internal List<int> FindWinner()
        {
            List<int> ListOfWinningPlayers = new List<int>();
            //int numberOfWins = 0;
            List<int> ListOfCardsWon = new List<int>();

            for (int i = 0; i < CardDeal.ListOfPlayers.Count; i++)
            {
                ListOfCardsWon.Add(CardDeal.ListOfPlayers[i].CardsWon.Count);
            }

            for (int i = 0; i < ListOfCardsWon.Count; i++)
            {
                if (CardDeal.ListOfPlayers[i].CardsWon.Count == ListOfCardsWon.Max())
                {
                    ListOfWinningPlayers.Add(i + 1);
                }
            }
            return ListOfWinningPlayers;

        }
        internal string GameMessage()
        {
            string endGameMessage = string.Empty;
            if (FindWinner().Count == 1)
            {
                endGameMessage = $"The winner is player: {FindWinner()[0]}";
            }
            else if (FindWinner().Count == 2)
            {
                endGameMessage = $"The winner is player: {FindWinner()[0]} and {FindWinner()[1]}";
            }
            else if (FindWinner().Count == 3)
            {
                endGameMessage = $"The winner is player: {FindWinner()[0]} and {FindWinner()[1]} and {FindWinner()[2]}";
            }
            else
            {
                endGameMessage = "Congratulation. You are all winners!";
            }
            return endGameMessage;
        }
    }
}
