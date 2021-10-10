using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Models
{
    public class CardDeck
    {
        public void CreateCardDeck(int numberOdDecks)
        {
            for (int x = 0; x < numberOdDecks; x++)
            {
                for (int i = 1; i < 14; i++)
                {
                    HeartsCard NewHeartsCard = new HeartsCard(i);
                    ListOfCards.AddCardToList(NewHeartsCard);
                    DiamondsCard NewDiamondsCard = new DiamondsCard(i);
                    ListOfCards.AddCardToList(NewDiamondsCard);
                    ClubsCard NewClubsCard = new ClubsCard(i);
                    ListOfCards.AddCardToList(NewClubsCard);
                    SpadesCard NewSpadesCard = new SpadesCard(i);
                    ListOfCards.AddCardToList(NewSpadesCard);
                }
            }
        }
    }
}
