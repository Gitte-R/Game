using System.Collections.Generic;

namespace Krig.Models
{
    public class Player
    {
        public Stack<Card> PlayersHand = new Stack<Card>();
        public Queue<Card> CardsWon = new Queue<Card>();
    }
}
