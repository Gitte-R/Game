using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Models
{
    public class ClubsCard : Card
    {
        public ClubsCard(int value_input)
        {
            CardColor = "Clubs";
            CardValue = value_input;
        }
    }
}
