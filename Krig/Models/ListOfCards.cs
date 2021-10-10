using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Models
{
    public static class ListOfCards
    {
        public static List<Card> ListOf52Cards = new List<Card>();

        public static void AddCardToList(Card NewCard)
        {
            ListOf52Cards.Add(NewCard);
        }
    }
}
