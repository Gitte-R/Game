using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Models
{
    public class DiamondsCard : Card
    {
        public DiamondsCard(int value_input)
        {
            CardColor = "Diamonds";
            CardValue = value_input;
        }
    }
}
