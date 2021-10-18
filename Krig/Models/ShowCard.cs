namespace Krig.Models
{
    public static class ShowCard
    {
        internal static string ShowPlayedCard(Game NewGame, int player)
        {
            string playedCardNbr = string.Empty;
            string playedCardColor = string.Empty;

            for (int i = 0; i < NewGame.ListOfPlayedCards.Count; i++)
            {
                switch (NewGame.ListOfPlayedCards[player - 1].CardValue)
                {
                    case 1: 
                        playedCardNbr = "A";
                        break;
                    case 2: 
                        playedCardNbr = "2";
                        break;
                    case 3:
                        playedCardNbr = "3";
                        break;
                    case 4:
                        playedCardNbr = "4";
                        break;
                    case 5:
                        playedCardNbr = "5";
                        break;
                    case 6:
                        playedCardNbr = "6";
                        break;
                    case 7:
                        playedCardNbr = "7";
                        break;
                    case 8:
                        playedCardNbr = "8";
                        break;
                    case 9:
                        playedCardNbr = "9";
                        break;
                    case 10:
                        playedCardNbr = "10";
                        break;
                    case 11:
                        playedCardNbr = "J";
                        break;
                    case 12:
                        playedCardNbr = "Q";
                        break;
                    case 13:
                        playedCardNbr = "K";
                        break;
                    default:
                        break;
                }

                switch (NewGame.ListOfPlayedCards[i].CardColor)
                {
                    case "Diamond":
                        playedCardColor = "D";
                        break;
                    case "Clubs":
                        playedCardColor = "C";
                        break;
                    case "Hearts":
                        playedCardColor = "H";
                        break;
                    case "Spades":
                        playedCardColor = "S";
                        break;
                    default:
                        break;
                }
            }
            string NewImg = $"C:/Users/gitte/OneDrive/Skrivebord/Krig/Krig/Resources/{playedCardNbr}{playedCardColor}.png";
            return NewImg;
        }
    }
}
