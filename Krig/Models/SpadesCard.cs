using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Models
{
    public class SpadesCard : Card
    {
        public SpadesCard(int value_input)
        {
            CardColor = "Spades";
            CardValue = value_input;
        }
    }
}
