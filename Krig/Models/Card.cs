using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Models
{
    public abstract class Card
    {
        public int CardValue { get; init; }
        public string CardColor { get; init; }
    }
}
