using System;
using System.Collections.Generic;

namespace Krig.Models
{
    public static class CardDeck
    {
        private static double NumberOfDecks { get; set; }
        internal static List<Card> ListOfCards = new List<Card>();
        internal static List<Card> RandomListOfCards = new List<Card>();
        internal static void CreateCards(int numberOfPlayers)
        {
            NumberOfDecks = numberOfPlayers / 2;

            for (int x = 0; x < Math.Floor(NumberOfDecks); x++)
            {
                for (int i = 1; i < 14; i++)
                {
                    HeartsCard NewHeartsCard = new HeartsCard(i);
                    AddCardToList(NewHeartsCard);
                    DiamondsCard NewDiamondsCard = new DiamondsCard(i);
                    AddCardToList(NewDiamondsCard);
                    ClubsCard NewClubsCard = new ClubsCard(i);
                    AddCardToList(NewClubsCard);
                    SpadesCard NewSpadesCard = new SpadesCard(i);
                    AddCardToList(NewSpadesCard);
                }
            }

            GenerateRandomList();
        }
        private static void AddCardToList(Card NewCard)
        {
            ListOfCards.Add(NewCard);
        }
        private static void GenerateRandomList()
        {
            Random RandomNumber = new Random();
            while (ListOfCards.Count > 0)
            {
                int indexOfRandomCard = RandomNumber.Next(0, ListOfCards.Count);
                RandomListOfCards.Add(ListOfCards[indexOfRandomCard]);
                ListOfCards.RemoveAt(indexOfRandomCard);
            }
        }
        internal static void GiveCardsToPlayers(List<Player> listOfPlayers)
        {
            while (RandomListOfCards.Count > 0)
            {
                for (int i = 0; i < listOfPlayers.Count; i++)
                {
                    if (RandomListOfCards.Count > 0)
                    {
                        listOfPlayers[i].PlayersHand.Push(RandomListOfCards[0]);
                        RandomListOfCards.RemoveAt(0);
                    }
                }
            }
        }
    }
}
