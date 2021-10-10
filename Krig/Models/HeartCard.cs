using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Models
{
    public class HeartsCard : Card
    {
        public HeartsCard(int value_input)
        {
            CardColor = "Hearts";
            CardValue = value_input;
        }
    }
}
