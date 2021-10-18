using System.Collections.Generic;

namespace Krig.Models
{
    public static class CardDeal
    {
        internal static readonly int userInput = 4;
        internal static List<Player> ListOfPlayers = new List<Player>();
        internal static void GeneratePlayerHands()
        {
            CardDeck.CreateCards(userInput);

            for (int i = 0; i < userInput; i++)
            {
                Player NewPlayer = new Player();
                ListOfPlayers.Add(NewPlayer);
            }
            CardDeck.GiveCardsToPlayers(ListOfPlayers);

        }
    }
}
