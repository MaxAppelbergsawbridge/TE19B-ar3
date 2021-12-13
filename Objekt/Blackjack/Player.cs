using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Player
    {
        public List<Card> Hand;
        public Card LastDrawnCard;
        public int LowValue;
        public int HighValue;
        public int BestOfValue;
        public void Reset()
        {

        }
    }
}